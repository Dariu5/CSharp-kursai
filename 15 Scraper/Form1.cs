using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace _15_Scraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = textBox1.Text;
            textBox1.Text = "";
            GautiHTML(url);
        }

        public static async void GautiHTML(string url)
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var produktuSaras = htmlDocument.DocumentNode.Descendants("ul")
                .Where(x => x.GetAttributeValue("id", "")
                .Contains("s-results-list-atf")).ToList();


            var produktuElementai = produktuSaras[0].Descendants("li")
                .Where(x => x.GetAttributeValue("id", "")
                .Contains("result")).ToList();

            

            List<string> kodai = new List<string>();

            foreach (var elementas in produktuElementai)
            {



                var pav = elementas.SelectSingleNode("//h2").InnerText;                

            }





        }

    }
}
