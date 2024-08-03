/*
 * @author: St Cyr Lee J. Vandersar
 * Devoir 3 output maze.png
*/

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Devoir3
{
    public partial class MazeForm : Form
    {
        private const int NumColumns = 7;
        private const int NumRows = 6;
        private const int SquareSize = 100;
        private readonly Color[,] squareColors = new Color[NumColumns, NumRows];

        public MazeForm()
        {
            InitializeComponent();
            InitializeSquareColors();
        }

        private void InitializeSquareColors()
        {
            for (int col = 0; col < NumColumns; col++)
            {
                for (int row = 0; row < NumRows; row++)
                {
                    squareColors[col, row] = Color.DarkGray;
                }
            }

            squareColors[0, 5] = Color.Red;
            for (int col = 0; col <= 4; col++)
            {
                squareColors[col, 4] = Color.Yellow;
            }
            for (int col = 4; col <= 5; col++)
            {
                squareColors[col, 3] = Color.Yellow;
            }
            for (int row = 1; row <= 2; row++)
            {
                squareColors[5, row] = Color.Yellow;
            }
            squareColors[5, 0] = Color.Green;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int col = 0; col < NumColumns; col++)
            {
                for (int row = 0; row < NumRows; row++)
                {
                    using (SolidBrush brush = new SolidBrush(squareColors[col, row]))
                    {
                        e.Graphics.FillRectangle(brush, col * SquareSize, row * SquareSize, SquareSize, SquareSize);
                    }
                }
            }

            using (Pen pen = new Pen(Color.Black, 2))
            {
                for (int col = 0; col <= NumColumns; col++)
                {
                    e.Graphics.DrawLine(pen, col * SquareSize, 0, col * SquareSize, NumRows * SquareSize);
                }

                for (int row = 0; row <= NumRows; row++)
                {
                    e.Graphics.DrawLine(pen, 0, row * SquareSize, NumColumns * SquareSize, row * SquareSize);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void SaveImage()
        {
            using (Bitmap bmp = new Bitmap(NumColumns * SquareSize, NumRows * SquareSize))
            {
                string imagePath = "maze.png";
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    for (int col = 0; col < NumColumns; col++)
                    {
                        for (int row = 0; row < NumRows; row++)
                        {
                            using (SolidBrush brush = new SolidBrush(squareColors[col, row]))
                            {
                                g.FillRectangle(brush, col * SquareSize, row * SquareSize, SquareSize, SquareSize);
                            }
                        }
                    }

                    using (Pen pen = new Pen(Color.Black, 2))
                    {
                        for (int col = 0; col <= NumColumns; col++)
                        {
                            g.DrawLine(pen, col * SquareSize, 0, col * SquareSize, NumRows * SquareSize);
                        }

                        for (int row = 0; row <= NumRows; row++)
                        {
                            g.DrawLine(pen, 0, row * SquareSize, NumColumns * SquareSize, row * SquareSize);
                        }
                    }
                }

                bmp.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);

            }

        }

    }

}
