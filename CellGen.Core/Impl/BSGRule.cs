using CellGen.Core.Interfaces;
using CellGen.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellGen.Core.Impl
{
    public class BSGRule : IRule
    {
        private int[] b { get; set; } = new int[] { 3 };
        private int[] s { get; set; } = new int[]{  2, 3 };
        private int g { get; set; } = 2;
        private INeighbourhood neighbourhood { get; set; }
        public BSGRule(INeighbourhood neighbourhood) 
        {
            this.neighbourhood = neighbourhood;
        }

        public int CheckCell(int[][] field, Cell cell)
        {
            int n = neighbourhood.CountNeighbours(field, cell);
            int state = field[cell.row][cell.col];
            if (state == g)
                state = 0;
            if ((s.Contains(n) && state == 1) || (b.Contains(n) && state == 0))
                return 1;
            if (state == 0)
                return 0;
            return state+1;
        }

        public void SetRule(int[] b, int[] s, int g)
        {
            this.b = b;
            this.s = s;
            this.g = g;
        }
    }
}
