using CellGen.Core.Interfaces;
using CellGen.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellGen.Core.Impl
{
    public class MooreNeighbourhood : INeighbourhood
    {
        public int CountNeighbours(int[][] field, Cell cell)
        {
            int count = 0;
            int[] dr = new int[] { 0, 0, 1, 1, 1, -1, -1, -1 };
            int[] dc = new int[] { 1, -1, 0, 1, -1, 0, 1, -1 };
            for (int i = 0; i < 8; i++)
            {
                int row = ((cell.row + dr[i]) % field.Length + field.Length) % field.Length;
                int col = ((cell.col + dc[i]) % field[0].Length + field[0].Length) % field[0].Length;
                if (field[row][col] == 1)
                    count++;
            }
            return count;
        }
    }
}
