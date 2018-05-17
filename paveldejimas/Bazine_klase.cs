using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paveldejimas
{
    class Alkoholis
    {

        private double Laipsniai { get; set; }
        public int Turis { get; }
        public string Spalva { get; }


        public Alkoholis(double Laipsniai, int Turis, string Spalva)
        {
            this.Laipsniai = Laipsniai;
            this.Turis = Turis;
            this.Spalva = Spalva;
        }

        public Paveldinti()
        {

        }

        public double GetLaipsniai()
        {

            return Laipsniai;
        }

        public void SetLaipsniai(double laipsniai)

        {
            this.Laipsniai = Laipsniai;

        }


        /// <summary>
        /// Suskaiciuoja gaminio amziu
        /// </summary>
        /// <param name="gamybosMetus"></param>
        /// <returns></returns>
        public int Amzius(DateTime gamybosMetus)
        {
            return (DateTime.Today.Year - gamybosMetus.Year);
    } }
}
