using System;
using System.Collections.Generic;
using System.Text;

namespace кр
{
    class Point
    {
        private int x { get; set; }
        private int y { get; set; }
        private int N { get; set; }
        public Point(int newX, int newY)
        {
            this.x = newX;
            this.y = newY;
        }
        public Point SegmentX(int _y)
        {
            this.x = 0;
            this.y = _y;
            return new Point(this.x, this.y);
        }
        public Point SegmentY(int _x)
        {
            this.x = _x;
            this.y = 0;
            return new Point(this.x, this.y);
        }
        public bool Intersection(Point p1, Point p2, Point p3, Point p4)
        {
            if (p2.x < p3.x)
            {
                return true;
            }
            if ((p1.x - p2.x == 0) && (p3.x - p4.x == 0))
            {
                if (p1.x == p3.x)
                {
                    if (!((Math.Max(p1.y, p2.y) < Math.Min(p3.y, p4.y)) || Math.Min(p1.y, p2.y) > Math.Max(p3.y, p4.y)))
                    {
                        return true;
                    }
                }
                return false;
            }
            if (p1.x - p2.x == 0)
            {
                double Xa = p1.x;
                double A2 = (p3.y - p4.y) / (p3.x - p4.x);
                double b2 = p3.y - A2 * p3.x;
                double Ya = A2 * Xa + b2;
                if (p3.x <= Xa && p4.x >= Xa && Math.Min(p1.y, p2.y) <= Ya && Math.Max(p1.y, p2.y) >= Ya)
                {
                    return true;
                }
                return false;
            }
            if (p3.x - p4.x == 0)
            {
                double Xa = p3.x;
                double A1 = (p1.y - p2.y) / (p1.x - p2.x);
                double b1 = p1.y - A1 * p1.x;
                double Ya = A1 * Xa + b1;
                if (p1.x <= Xa && p2.x >= Xa && Math.Min(p3.y, p4.y) <= Ya && Math.Max(p3.y, p4.y) >= Ya)
                {

                    return true;
                }
                return false;
            }
            double a1 = (p1.y - p2.y) / (p1.x - p2.x);
            double a2 = (p3.y - p4.y) / (p3.x - p4.x);
            double B1 = p1.y - a1 * p1.x;
            double B2 = p3.y - a2 * p3.x;
            if(a1==a2)
            {
                return false;
            }
            double xa = (B2 - B1) / (a1 - a2);
            if ((xa < Math.Max(p1.x, p3.x)) || (xa > Math.Min(p2.x, p4.x)))
            {
                return false; 
            }
            else
            {
                return true;
            }
        }
    }
}
