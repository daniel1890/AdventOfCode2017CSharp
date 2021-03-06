using AdventOfCode2017CSharp.Entities.DagBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017CSharp.Entities.Dagen
{
    internal class Dag2 : Dag
    {
        public Dag2()
        {
            _filePath = @"./TextFiles/Dag2.txt";
            _lines = File.ReadAllLines(_filePath).ToList();
        }

        public override void CalcPart1()
        {
            // Creeër 2 lege arrays met allebei de grote van hoeveel rows in de txt file zitten
            int[] min = new int[_lines.Count];
            int[] max = new int[_lines.Count];

            foreach (string row in _lines)
            {
                min[_lines.IndexOf(row)] = 999999999;
                max[_lines.IndexOf(row)] = 0;

                string[] split = row.Split("	");

                foreach (string getalString in split)
                {
                    int huidigGetal = Int32.Parse(getalString);

                    if (huidigGetal < min[_lines.IndexOf(row)])
                    {
                        min[_lines.IndexOf(row)] = huidigGetal;
                    }
                    if (huidigGetal > max[_lines.IndexOf(row)])
                    {
                        max[_lines.IndexOf(row)] = huidigGetal;
                    }
                }
                _ans1 += (max[_lines.IndexOf(row)] - min[_lines.IndexOf(row)]);
            }
        }

        public override void CalcPart2()
        {
            foreach (string row in _lines)
            {
                string[] split = row.Split("	");

                foreach (string getalString in split)
                {
                    int huidigGetal = Int32.Parse(getalString);

                    foreach (string getalString2 in split)
                    {
                        double getalDouble = (double)huidigGetal / (double)Int32.Parse(getalString2);
                        double getalFloored = Math.Floor((double)huidigGetal / (double)Int32.Parse(getalString2));

                        double som = getalDouble - getalFloored;

                        if (som == 0)
                        {
                            if (getalDouble != 1 && getalFloored != 1)
                            {
                                int uitkomst = huidigGetal / Int32.Parse(getalString2);
                                _ans2 += uitkomst;
                            }
                            //Console.WriteLine($"{getalDouble} en{getalFloored}");
                        }
                        //Console.WriteLine((double)huidigGetal / (double)Int32.Parse(getalString2));
                        //Console.WriteLine(Math.Floor((double)huidigGetal / (double)Int32.Parse(getalString2)));
                    }
                }
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