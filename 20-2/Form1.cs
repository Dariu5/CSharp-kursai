using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_2
{
    public partial class Form1 : Form
    {

        List<Darbuotojas> Darbuotojai = new List<Darbuotojas>();


        public Form1()
        {
            InitializeComponent();


            System.IO.StreamReader reader = new System.IO.StreamReader("C://Users//darius.vainilavicius//Documents//id.txt");

            string line;

            while ((line = reader.ReadLine()) != null)
            {

                comboBox1.Items.Add(line);

            }
                       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            string path = null;

            if (fbd.ShowDialog() == DialogResult.OK)

            {

                path = fbd.SelectedPath;

            }

            System.IO.StreamReader reader = new System.IO.StreamReader(path + "//ddata.txt");

            string line;

            while ((line = reader.ReadLine()) != null)
            {

                string[] line_data = line.Split(' ');


                try
                {

                    DateTime data = new DateTime(Int16.Parse(line_data[3].Substring(0, 4)), Int16.Parse(line_data[3].Substring(4, 2)), Int16.Parse(line_data[3].Substring(6, 2)));
                    Darbuotojai.Add(new Darbuotojas(line_data[0], line_data[1], line_data[2], data, Double.Parse(line_data[4]), Int32.Parse(line_data[5])));
                }


                catch(Exception ex)

                {
                    MessageBox.Show("Tikrinti įrašą: " + line_data[0]);

                }
               

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var Darbuotojas in Darbuotojai)
            {

                if (Darbuotojas.ID == comboBox1.SelectedItem.ToString())
                {

                    VardasBox.Text = Darbuotojas.Vardas;
                    PavardeBox.Text = Darbuotojas.Pavarde;
                    GimimoDataBox.Text = Darbuotojas.Giminodata.ToString();
                    GaunamaDataBox.Text = Darbuotojas.Alga.ToString();
                    DirbaImonejeBox.Text = Darbuotojas.Dirbalaiko.ToString();

                }

            }
        }
    }
}
