using CellGen.Core.Impl;
using CellGen.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellGen.Core.Models
{
    public class Game
    {
        public int[][] Field { get; set; } = default!;
        private IRule rule { get; set; } = default!;
        private int rows { get; set; } = default!;
        private int cols { get; set; } = default!;
        public IRule Rule
        {
            get { return rule; }
            set { rule = value; }
        }
        public Game(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            Field = new int[rows][];
            for (int i = 0; i < rows; i++)
                Field[i] = new int[cols];
            Rule = new BSGRule(new MooreNeighbourhood());
        }

        public void Iterate()
        {
            int[][] newfield = new int[rows][];
            for (int i = 0; i < rows; i++)
                newfield[i] = new int[cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    newfield[i][j] = rule.CheckCell(Field, new Cell(i, j));
            Field = newfield;
        }

        public void NewField(int rows, int cols)
        {
            Field = new int[rows][];
            for (int i = 0; i < rows; i++)
                Field[i] = new int[cols];
        }
    }
}
