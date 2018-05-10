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
    public partial class GautiDuomenysForma : Form
    {
        public GautiDuomenysForma(int skaicius)
        {
            InitializeComponent();
            label1.Text = skaicius.ToString();
        }
    }
}
