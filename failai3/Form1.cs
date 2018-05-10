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

namespace failai3
{
    public partial class Form1 : Form
    {

        List<Zmogus> Zmogai;// = new List<Zmogus>();


        public Form1()
        {
            InitializeComponent();

            Zmogai = new List<Zmogus>();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog() )

            {

                if (failas.ShowDialog() == DialogResult.OK)
                {                    
                    var eilutes = File.ReadLines(failas.FileName);

                    foreach (var eilute in eilutes)
                    {

                        Zmogai.Add(new Zmogus(eilute));

                    }
                }

                dataGridView1.DataSource = Zmogai;

                
            }
        }
    }
}
