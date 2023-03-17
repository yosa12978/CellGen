using CellGen.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CellGen.Core.Interfaces
{
    public interface INeighbourhood
    {
        int CountNeighbours(int[][] field, Cell cell);
    }
}
