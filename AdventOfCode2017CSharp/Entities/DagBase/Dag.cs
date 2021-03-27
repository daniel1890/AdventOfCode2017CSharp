using AdventOfCode2017CSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017CSharp.Entities.DagBase
{
    public abstract class Dag : IDag
    {
        protected string _filePath;
        protected List<string> _lines;

        protected int _ans1, _ans2;

        public abstract void CalcPart1();

        public abstract void CalcPart2();

        public abstract void RunDag();

        public override string ToString()
        {
            string typeOf = this.GetType().Name;
            return $"{typeOf}: \nAntwoord deel 1: {_ans1} \nAntwoord deel 2: {_ans2} \n~~~~~~~~~~~~~~~~~~~~";
        }
    }
}