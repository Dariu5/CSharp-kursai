using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace failai
{
    public partial class Form1 : Form
    {

        public List<Automobilis> Automobiliai { get; set; }

        public Form1()
        {
            InitializeComponent();
            Automobiliai = new List<Automobilis>(); //inicializacija
        }

        private void išeitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog())
            {

                failas.Filter = "csv failas(*.csv)|*.csv";
                            

                if (failas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        var tekstas = File.ReadAllLines(failas.FileName);

                        foreach (var eilute in tekstas)
                        {
                            //MessageBox.Show(eilute);
                            
                            Automobiliai.Add(new Automobilis(eilute));

                        }

                        dataGridView1.DataSource = Automobiliai;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }


            }
        }
    }
}
