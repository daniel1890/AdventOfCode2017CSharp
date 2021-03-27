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

        public AlleDagen()
        {
            test = false;

            _dag1 = new Dag1();
            _dag2 = new Dag2();
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
                _dag2.RunDag();
            }
        }
    }
}