using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace Teleloto
{
    public partial class Form1 : Form
    {

        List<int> kamuoliukai = new List<int>();

        int kamuoliuku_skaicius = 0;

        int uzbraukta = 0;


        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i < 76; i++)
            {
                kamuoliukai.Add(i);

            }


        }

        public void button1_Click(object sender, EventArgs e)
        {

            Generatorius bilietas = new Generatorius();
            dataGridView2.AutoGenerateColumns = true;          
            dataGridView2.DataSource = bilietas.Eilutes;
            Kamuoliukai_box.Text = "";
            kamuoliuku_skaicius = 0;
            Kam_skaicius.Text = "0";
            uzbraukta = 0;
            dataGridView2.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var rnd = new Random();

            var indeksas = rnd.Next(0, kamuoliukai.Count - 1);

            int skaicius = kamuoliukai[indeksas];
            kamuoliukai.RemoveAt(indeksas);


            Kamuoliukai_box.AppendText(" " + skaicius.ToString());
            kamuoliuku_skaicius++;
           Kam_skaicius.Text = kamuoliuku_skaicius.ToString();


            for (int i = 0; i < 5; i++)
            {

                for (int ii = 0; ii < 5; ii++)
                {

                    if (skaicius.ToString() == dataGridView2.Rows[i].Cells[ii].Value.ToString())

                    {

                        dataGridView2.Rows[i].Cells[ii].Style.BackColor = Color.Red;
                        uzbraukta++;

                        if (uzbraukta == 25 )
                        {
                            MessageBox.Show("Sveikiname, Jūs laimėjote melejoną!!!!!");
                        }

                        return;
                    }


                }



            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (uzbraukta < 25)
            {


                button2.PerformClick();
                int milliseconds = 500;
                Thread.Sleep(milliseconds);
                dataGridView2.Refresh();

            }
        }
    }
}