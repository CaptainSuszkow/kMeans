using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Kmeans
{
    class Centroid
    {
        public Color color =new Color();
        public int X;
        public int Y;
        public List<Point> CentroidPoints;
        public List<Point> OldCentroidPoints;
        private int oldX;
        private int oldY;
        private  readonly Random rng;
        private readonly int W;
        private readonly int H;

        public void AddPoint(Point point)
        {
            CentroidPoints.Add(point);
        }

        public Centroid(Random rnd, int maxW, int maxH)
        {
            W = maxW;
            H = maxH;
            rng = rnd;
            color = Color.FromArgb(255, rnd.Next(256), rnd.Next(256), rnd.Next(256));
            X = rnd.Next(0, maxW);
            Y = rnd.Next(0, maxH);
            CentroidPoints = new List<Point>();
            OldCentroidPoints = new List<Point>();
        }

        //Function which move Centroid position to the new position computed by average centroid points position
        public void Move()
        {
            double sumX = 0;
            double sumY = 0;

            if (CentroidPoints.Count == 0)
            {
                oldX = X;
                oldY = Y;
                return;
            }

            for (int i = 0; i < CentroidPoints.Count; i++)
            {
                sumX += CentroidPoints[i].X;
                sumY += CentroidPoints[i].Y;
            }
            sumX /= CentroidPoints.Count;
            sumY /= CentroidPoints.Count;
            oldX = X;
            oldY = Y;
            X = (int) sumX;
            Y = (int) sumY;
        }

        public double Error()
        {
            double result = 0;
            if (CentroidPoints.Count != 0)
            {

                foreach (Point p in CentroidPoints)
                {
                    result += Math.Sqrt(Math.Pow((p.X - X), 2) + Math.Pow((p.Y - Y), 2));
                }
                return result / CentroidPoints.Count;
            }
            else
                return 0;
        }

        public bool Moved()
        {

            if (oldX == X && oldY == Y)
                return false;
            else
                return true;
        }

        public void SavePoints()
        {
            OldCentroidPoints.Clear();
            OldCentroidPoints = CentroidPoints;
            CentroidPoints.Clear();
        }
    }
}
