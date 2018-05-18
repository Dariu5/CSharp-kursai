using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_2_uzduotis2
{

    public interface IDarbuotojas

    {

        string Name { get; }
        int ID { get; }

        void PrintOutData();


    }


    class DarbuotojasConsole : IDarbuotojas
    {

        public int ID { get; }
        public string Name { get; }

        [STAThread]
        public void PrintOutData()
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            string path = null;

            if (fbd.ShowDialog() == DialogResult.OK)

            {

                path = fbd.SelectedPath;

            }

            System.IO.StreamWriter writer = new System.IO.StreamWriter(path+"\\out.txt",true);
            writer.WriteLine("Vartotojo ID: " + ID);
            writer.WriteLine("Vartotojo Vardas: " + Name);
            writer.Flush();
        }


        public DarbuotojasConsole(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
