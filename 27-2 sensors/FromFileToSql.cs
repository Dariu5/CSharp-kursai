using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data.Linq;

namespace _27_2_sensors
{
    class FromFileToSql
    {

        public void Converter(string path)

        {
            StreamReader reader = new StreamReader(path);

            string data = reader.ReadToEnd();
            data = data.Replace("\n", "");
            data = data.Replace("\r", "");
            data = data.Replace(".", ",");
            string[] datastring = data.Split(';');
            reader.Dispose();

            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darius.vainilavicius\Documents\Visual Studio 2015\Projects\CS_kursai\27-2 sensors\sensors.mdf;Integrated Security=True";

            DataContext db = new DataContext(connectionstring);
            Table<Sensor> sensor = db.GetTable<Sensor>();
            Table<Measurement> measurement = db.GetTable<Measurement>();

            Sensor sen = new Sensor();
            sen.Id = long.Parse(datastring[93]);
            sen.DateOfRecrd = DateTime.Parse(datastring[90]);
            sen.StationNumber = datastring[91];
            sen.SV = int.Parse(datastring[96]);

            for (int i = 100; i < datastring.Length-2; i+=5)
            {

                Measurement temp = new Measurement();
                temp.SN = long.Parse(datastring[93]);

                temp.Vout = decimal.Parse(datastring[i + 1]);
                temp.Min = decimal.Parse(datastring[i + 3]);
                temp.Max = decimal.Parse(datastring[i + 4]);

                measurement.InsertOnSubmit(temp);

              
                    db.SubmitChanges();
               
             
            }



            sensor.InsertOnSubmit(sen);

            try
            {
                db.SubmitChanges();
            }

            catch

            {
                ;
            }




        }


    }
}
