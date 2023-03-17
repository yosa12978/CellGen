using CellGen.Core.Impl;
using CellGen.Core.Interfaces;
using CellGen.Core.Models;

int[][] field = new int[3][];
for (int i = 0; i < 3; i++)
{
    field[i] = new int[3];
    for (int j = 0; j < 3; j++)
        field[i][j] = 0;
}
INeighbourhood nhood = new MooreNeighbourhood();
IRule rule = new BSGRule(nhood);
rule.SetRule(new int[] { 3 }, new int[] { 2, 3 }, 2);
field[0][0] = 1;
field[0][1] = 1;
field[0][2] = 1;
Game game = new Game(3, 3);
Console.WriteLine(rule.CheckCell(field, new Cell(1, 1)));