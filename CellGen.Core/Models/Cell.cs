using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellGen.Core.Models
{
    public class Cell
    {
        public int row { get; set; }
        public int col { get; set; }

        public Cell(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
// 0 - not alive, 1 - alive, 2 ... n - oldness