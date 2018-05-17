using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _18_2_uzduotiss
{

    public interface IDarbuotojas

    {

        string Name { get; }
        int  ID { get; }

        void PrintOutData();


    }


    class DarbuotojasConsole : IDarbuotojas
    {

        public int ID { get; }
        public string Name { get; }

        [STAThread]
        public void PrintOutData()
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            string path = null;

            if (fbd.ShowDialog() == DialogResult.OK)

            {

                path = fbd.SelectedPath;

            }

            System.IO.StreamReader reader = new System.IO.StreamReader("out.txt");


        }

    }
}
