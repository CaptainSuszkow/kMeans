using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Kmeans
{
    class KMeans
    {
        public List<Centroid> Centroids = new List<Centroid>();
        private readonly List<Point> Data;
        public List<double> Error = new List<double>();
        private readonly int lCentroid;
        private PictureBox p;
        private Color[] Colors =
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Lime,
            Color.Orange,
            Color.Fuchsia,
            Color.Yellow,
            Color.LightGreen,
            Color.LightBlue,
            Color.Cyan,
        };

        private Color RandomColor(Random rnd)
        {
            return Colors[rnd.Next(0, Colors.Length)];
        }

        public KMeans(int num, List<Point> data, Random rnd, PictureBox pB)
        {
            p = pB;
            lCentroid = num;
            Data = data;
            for (int i = 0; i < num; i++)
            {
                Centroids.Add(new Centroid(rnd,pB.Width, pB.Height));
            }
        }

        public void ClearPoints()
        {
            foreach (Centroid centroid in Centroids)
            {
                centroid.SavePoints();
            }
        }

        public double EDistance(Point a, Centroid c)
        {
            return Math.Sqrt(Math.Pow(a.X - c.X, 2) + Math.Pow(a.Y - c.Y, 2));
        }

        public void UpdatePoints()
        {
            ClearPoints();
            double[] PointDistance;
            foreach (Point p in Data)
            {
                PointDistance = new double[lCentroid];
                for(int i = 0; i < Centroids.Count; i++)
                {
                    PointDistance[i] = EDistance(p, Centroids[i]);
                }

                Centroids[Array.IndexOf(PointDistance, PointDistance.Min())].AddPoint(p);
            }
        }

        public void Draw()
        {
            System.Drawing.Graphics g = p.CreateGraphics(); ;
            p.Refresh();
            
            foreach (Centroid c in Centroids)
            {
                SolidBrush brush = new SolidBrush(c.color);
                Rectangle rect = new Rectangle(new Point(c.X, c.Y), new Size(20, 20));
                g.FillEllipse(brush, rect);
                for (int i = 0; i < c.CentroidPoints.Count(); i++)
                {
                    Rectangle point = new Rectangle(c.CentroidPoints[i], new Size(4, 4));
                    g.FillRectangle(brush, point);
                }
            }
        }

        public double CountError()
        {
            double sum = 0;
            foreach (Centroid c in Centroids)
            {
                sum += c.Error();
            }
            return sum / Centroids.Count;
        }

        public void Train()
        {
            while (true)
            {
                UpdatePoints();
                Draw();
                Thread.Sleep(400);

                foreach (Centroid c in Centroids)
                {
                        c.Move();
                }

                Error.Add(CountError());

                bool hasChanged = false;

                foreach (Centroid c in Centroids)
                {
                    if (c.Moved())
                    {
                        hasChanged = true;
                        break;
                    }
                }
                if (!hasChanged)
                    break;
            }
        }
    }
}
