using AdventOfCode2017CSharp.Entities.DagBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017CSharp.Entities.Dagen
{
    internal class Dag4 : Dag
    {
        public Dag4()
        {
            _filePath = @"./TextFiles/Dag4.txt";
            _lines = File.ReadAllLines(_filePath).ToList();

            _ans1 = 0;
            _ans2 = 0;
        }

        public override void CalcPart1()
        {
            foreach (string row in _lines)
            {
                // Creeër een hashset, een hashset accepteerd alleen unieke objecten. Dus wanneer een nieuw object gelijk is aan een object wat al in de hashset bevindt dan zal deze niet appended
                // worden aan de hashset. Hierdoor kan je dus makkelijk de lengte van de originele lijst vergelijken met de nieuwe hashset versie, wanneer beide lijsten niet gelijk zijn aan elkaar
                // in grootte, dan betekent het dat er dubbele objecten zitten in de lijst.

                string[] passwords = row.Split(" ");
                HashSet<string> set = new();

                foreach (string password in passwords)
                {
                    set.Add(password);
                }
                if (passwords.Length == set.Count) { _ans1 += 1; }
                //Console.WriteLine($"aantal passwords: {passwords.Length}, aantal unieke passwords: {set.Count}");
            }
        }

        public override void CalcPart2()
        {
        }

        public override void RunDag()
        {
            CalcPart1();
            Console.WriteLine(this.ToString());
        }
    }
}