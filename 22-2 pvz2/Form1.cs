using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_2_pvz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += MetaMessageBox;
        }

        private void MetaMessageBox(object sender, EventArgs e)

        {

            MessageBox.Show("Issoko langas");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Labas";
        }
    }
}
