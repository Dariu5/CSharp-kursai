using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleloto
{
    public partial class Form1 : Form
    {

        
        


        public Form1()
        {
            InitializeComponent();


        }

        public void button1_Click(object sender, EventArgs e)
        {

            Generatorius bilietas = new Generatorius();
            dataGridView2.AutoGenerateColumns = true;          
            dataGridView2.DataSource = bilietas.Eilutes;
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var rnd = new Random();

            int skaicius = rnd.Next(1, 75);


            for (int i = 0; i < 5; i++)
            {

                for (int ii = 0; ii < 5; ii++)
                {

                    if (skaicius.ToString() == dataGridView2.Rows[i].Cells[ii].Value.ToString())

                    {

                        dataGridView2.Rows[i].Cells[ii].Style.BackColor = Color.Red;
                        return;
                    }


                }



            }


        }



    }
}