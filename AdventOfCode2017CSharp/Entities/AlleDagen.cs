using AdventOfCode2017CSharp.Entities.Dagen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017CSharp.Entities
{
    public class AlleDagen
    {
        private Boolean test;

        private Dag1 _dag1;
        private Dag2 _dag2;
        private Dag4 _dag4;

        public AlleDagen()
        {
            test = true;

            _dag1 = new Dag1();
            _dag2 = new Dag2();
            _dag4 = new();
        }

        public void RunAlleDagen()
        {
            if (test == false)
            {
                _dag1.RunDag();
                _dag2.RunDag();
            }
            else
            {
                _dag4.RunDag();
            }
        }
    }
}