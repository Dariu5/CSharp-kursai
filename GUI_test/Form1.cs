using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            //mbox
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(tekstolaukelis.Text);
            var skaicius = Convert.ToInt32(tekstolaukelis.Text);
            MessageBox.Show(skaicius.ToString());
            tekstolaukelis.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var skaicius = Convert.ToInt32(perkelti.Text);
            var forma = new GautiDuomenysForma(skaicius);
            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var forma = new IvestiForma())
            {
                forma.ShowDialog();
                if (forma.DialogResult == DialogResult.OK)
                {
                    label1.Text = forma.Tekstas;                    
                }
            }
        }
    }
}
