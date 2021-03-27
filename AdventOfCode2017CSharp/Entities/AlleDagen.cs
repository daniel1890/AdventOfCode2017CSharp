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
        private Dag1 _dag1;

        public AlleDagen()
        {
            _dag1 = new Dag1();
        }

        public void RunAlleDagen()
        {
            _dag1.RunDag();
        }
    }
}