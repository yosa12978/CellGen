using CellGen.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellGen.Core.Interfaces
{
    public interface IRule
    {
        int CheckCell(int[][] field, Cell cell);
        void SetRule(int[] b, int[] s, int g);
    }
}
