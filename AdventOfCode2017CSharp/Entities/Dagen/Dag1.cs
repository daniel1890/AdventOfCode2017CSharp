using AdventOfCode2017CSharp.Entities.DagBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017CSharp.Entities.Dagen
{
    public class Dag1 : Dag
    {
        public Dag1()
        {
            /* initialiseer de filepath en append elke lijn text aan de _lines list.
             * door bij de txt file eigenschappen te gaan en build action "embedded resource" te maken,
             * en door bij copy to output directory "copy if newer" te selecteren
             * wordt de txt file beschikbaar gemaakt aan het programma tijdens de build.
             */

            _filePath = @"TextFiles/Dag1.txt";
            _lines = File.ReadAllLines(_filePath).ToList();

            _ans1 = 0;
            _ans2 = 0;

            // Creeër een string uit de List want de List heeft maar 1 element doordat het 1 lange string is, hierdoor is het makkelijker om mee te werken.
            getallen = _lines.ElementAt(0);

            // Deel 1 variabelen
            _indexerPart1 = 0;

            // Deel 2 variabelen
            _indexerPart2 = 0;
            _stappen = getallen.Length / 2;
        }

        private string getallen;
        private int _indexerPart1;
        private int _indexerPart2;
        private int _stappen;

        public override void CalcPart1()
        {
            foreach (char getal in getallen)
            {
                // Vergelijk de waarde van de getallen op index 0 met het getal wat op getallen index 0 + 1 komt,
                // Wanneer de getallen gelijk zijn aan elkaar tel het getal op index 0 op bij het antwoord.
                // Door Modulo te gebruiken
                if (getal == getallen.ElementAt((_indexerPart1 + 1) % (getallen.Length)))
                {
                    _ans1 += Int32.Parse(getal.ToString());
                }
                //Console.WriteLine("BaseGetal: " + getal);
                //Console.WriteLine("VergelijkGetal: " + getallen.ElementAt((_indexerPart1 + 1) % (getallen.Length)));
                //Console.WriteLine("Ans: " + _ans1);

                _indexerPart1 += 1;
            }
            //Console.WriteLine(getallen.Length);
            //Console.WriteLine(getallen.ElementAt(getallen.Length - 1));
        }

        public override void CalcPart2()
        {
            foreach (char getal in getallen)
            {
                if (getal == getallen.ElementAt((_indexerPart2 + _stappen) % (getallen.Length)))
                {
                    _ans2 += Int32.Parse(getal.ToString());
                }
                _indexerPart2 += 1;
                //Console.WriteLine("BaseGetal: " + getal);
                //Console.WriteLine("VergelijkGetal: " + getallen.ElementAt((_indexerPart2 + _stappen) % (getallen.Length)));
                //Console.WriteLine("Ans: " + _ans2);
            }
        }

        public override void RunDag()
        {
            CalcPart1();
            CalcPart2();
            Console.WriteLine(this.ToString());
        }
    }
}