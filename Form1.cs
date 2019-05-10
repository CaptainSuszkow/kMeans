using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Kmeans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //init variables 
        Random rnd = new Random();
        public int initalX;
        public int initalY;
        public int finalX;
        public int finalY;
        public List<Point> Data = new List<Point>();
        public List<double> Error = new List<double>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pB_MouseDown(object sender, MouseEventArgs e)
        {
            initalX = e.X;
            initalY = e.Y;
        }

        private void pB_MouseUp(object sender, MouseEventArgs e)
        {
            finalX = e.X;
            finalY = e.Y;
            if(finalX < initalX)
            {
                initalX = initalX + finalX;
                finalX = initalX - finalX;
                initalX = initalX - finalX;
            }
            if(finalY < initalY)
            {
                initalY = initalY + finalY;
                finalY = initalY - finalY;
                initalY = initalY - finalY;
            }
            DrawRectangle(initalX, initalY, finalX, finalY);
        }

        private void DrawRectangle(int initalX, int initalY, int finalX, int finalY)
        {
            System.Drawing.Graphics g;
            //pB.Refresh();
            g = pB.CreateGraphics();
            Pen mypen = new System.Drawing.Pen(Brushes.Black);
            SolidBrush brush = new SolidBrush(Color.LimeGreen);
            g.DrawRectangle(mypen, initalX, initalY, Math.Abs(initalX-finalX), Math.Abs(initalY - finalY));

            Random rng = new Random();
            List<Point> temp = new List<Point>();
            int pointer = Data.Count();
            for(int i = 0; i < PtD.Value; i++)
            {
                Point p = new Point(rng.Next(initalX, finalX), rng.Next(initalY, finalY));
                Data.Add(p);
                Rectangle rect = new Rectangle(Data[pointer + i], new Size(2, 2));
                g.FillRectangle(brush, rect);
            }
        }

        public void InitDraw()
        {
            System.Drawing.Graphics g = pB.CreateGraphics(); ;
            pB.Refresh();
            SolidBrush brush = new SolidBrush(Color.LimeGreen);
            for(int i = 0; i < Data.Count(); i++)
            {
                Rectangle rect = new Rectangle(Data[i], new Size(2, 2));
                g.FillRectangle(brush, rect);
            }
        }

        //Need to add more dynamic scale of points
        private void BLoadFormFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                FileName = "data", 
                DefaultExt = ".txt", 
                Filter = "Text documents (.txt)|*.txt" 
            };

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = dlg.FileName;

                var fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var num1 = (Convert.ToDouble(line.Split(' ')[0]) * 25 + pB.Width / 2);
                        var num2 = (Convert.ToDouble(line.Split(' ')[1]) * 25 + pB.Height / 2);
                        Data.Add(new Point((int)num1, (int)num2));
                    }
                }
                InitDraw();
            }
        }

        private void BTrain_Click(object sender, EventArgs e)
        {
            if (Data.Count != 0)
            {
                KMeans k = new KMeans((int) NiDCentroidsAmount.Value, Data, rnd, pB);
                k.Train();
                Error = k.Error;
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            Data.Clear();
            pB.Refresh();
        }

        private void BShowGraph_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Error);
            form2.Show();
            
        }

        private void BCredits_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Created by Michał Suszek", "Credits",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }
    }
}
