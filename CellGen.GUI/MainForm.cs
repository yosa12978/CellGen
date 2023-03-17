using CellGen.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellGen.GUI
{
    public partial class MainForm : Form
    {
        private Game game;
        private int rows;
        private Graphics g;
        private int cols;
        private int res;
        private int generation = 0;

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }
        public void InitializeGame()
        {
            generation = 0;
            GenText.Text = generation.ToString();
            FieldBitmap.Image = new Bitmap(FieldBitmap.Width, FieldBitmap.Height);
            g = Graphics.FromImage(FieldBitmap.Image);
            res = (int)resol.Value;
            rows = FieldBitmap.Width / res;
            cols = FieldBitmap.Height / res;
            game = new Game(rows, cols);
        }
        private void Draw()
        {
            g.Clear(Color.FromArgb(45, 39, 39));
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    int alpha = 255;
                    int red = 143;
                    if (game.Field[i][j] == 0)
                    {
                        alpha = 0;
                        red = 0;
                    }
                    else
                    {
                        alpha /= game.Field[i][j];
                        red /= game.Field[i][j];
                    }
                    var sb = new SolidBrush(Color.FromArgb(alpha, red, 67, 238));
                    g.FillRectangle(sb, i * res, j * res, res, res);
                }
            FieldBitmap.Refresh();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            int[] b = Binput.Text.Trim().ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();
            int[] s = Sinput.Text.Trim().ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();
            int g = Convert.ToInt32(Ginput.Text);
            game.Rule.SetRule(b, s, g);
            Timer.Enabled = true;
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            generation++;
            GenText.Text = generation.ToString();
            game.Iterate();
            Draw();
        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            generation = 0;
            GenText.Text = generation.ToString();
            Random random = new Random();
            for (int i = 0; i < game.Field.Length; i++)
            {
                game.Field[i] = new int[game.Field[0].Length];
                for (int j = 0; j < game.Field[0].Length; j++)
                    game.Field[i][j] = random.Next() % 3 == 0 ? 1 : 0;
            }
            Draw();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            InitializeGame();
            Timer.Enabled = false;
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
        }

        private void MouseDraw(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = e.Location.X / res;
                    int y = e.Location.Y / res;
                    game.Field[x][y] = 1;
                    Draw();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    int x = e.Location.X / res;
                    int y = e.Location.Y / res;
                    game.Field[x][y] = 0;
                    Draw();
                }

            }
            catch { }
        }

        private void interval_ValueChanged(object sender, EventArgs e)
        {
            this.Timer.Interval = interval.Value;
        }

        private void resol_ValueChanged(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}
