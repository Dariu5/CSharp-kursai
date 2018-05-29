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

namespace _27_2_sensors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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
    }
}
