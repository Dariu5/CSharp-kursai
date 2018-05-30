using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _27_2_sensors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\darius.vainilavicius\Documents\Visual Studio 2015\Projects\CS_kursai\27-2 sensors\sensors.mdf; Integrated Security = True");

            Table<Sensor> sensor = db.GetTable<Sensor>();

            foreach (var item in sensor)
            {

                comboBoxSN.Items.Add(item.Id);

            }

            var measurements = db.GetTable<Measurement>().Where(x => x.SN.ToString() == comboBoxSN.SelectedItem.ToString());

            chart1.Series.Add("Min");
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series.Add("Max");
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            List <decimal?> xValues = new List<decimal?>();
            List<decimal?> yVout = new List<decimal?>();
            List<decimal?> yMin = new List<decimal?>();
            List<decimal?> yMax = new List<decimal?>();


            foreach (var item in measurements)
            {
                dataGridView1.Rows.Add(null, item.Vout, item.Min, item.Max);

                xValues.Add(item.Vout);
                yVout.Add(item.Vout);
                yMin.Add(item.Min);
                yMax.Add(item.Max);

                chart1.Series[0].Points.DataBindXY(xValues, yMin);
                
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sensorsDataSet.Measurements' table. You can move, or remove it, as needed.
            this.measurementsTableAdapter.Fill(this.sensorsDataSet.Measurements);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FromFileToSql fftsq = new FromFileToSql();
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            string path = null;

            
             if (fbd.ShowDialog() == DialogResult.OK)

             {

                 path = fbd.SelectedPath;
             }

             foreach (var fil in Directory.GetDirectories(path))
             {
                 foreach (var file in Directory.EnumerateFiles(fil))
                 {
                     fftsq.Converter(file);
                 }
             }
             
        }

        private void comboBoxSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\darius.vainilavicius\Documents\Visual Studio 2015\Projects\CS_kursai\27-2 sensors\sensors.mdf; Integrated Security = True");
            var measurements = db.GetTable<Measurement>().Where(x => x.SN.ToString() == comboBoxSN.SelectedItem.ToString());

            foreach (var item in measurements)
            {
                dataGridView1.Rows.Add(null, item.Vout, item.Min, item.Max);
            }

        }
    }
}
