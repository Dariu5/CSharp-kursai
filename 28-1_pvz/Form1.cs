using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_1_pvz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            await DoStuff();
        }


        private async void Tarpinis()

        {



        }


        private async Task DoStuff()

        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                ;
            }


            MessageBox.Show("Laikas praejo");
            return null;

        }
    }
}
