using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEassignment
{/// <summary>
/// to create triangle
/// </summary>
    class Triangle : Interface1
    {/// <summary>
    /// To draw a triangle
    /// </summary>
    /// <param sides="res"></param>
    /// <param graphics="g"></param>
    /// <param point_one="k"></param>
    /// <param point_two="l"></param>
        public void drawShape(string[] res, Graphics g, int k, int l)
        {
            int point2 = 0;
            int temps = 0;
            int a = Convert.ToInt32(res[1]);
            int b = Convert.ToInt32(res[2]);
            int c = Convert.ToInt32(res[3]);
            if (a + b > c && a + c > b && b + c > a)
            {


                if (b > a)
                {
                    if (c > b)
                    {
                        temps = c;
                        c = a;
                        a = temps;

                    }
                    else
                    {
                        temps = b;
                        b = a;
                        a = temps;
                    }
                }
                if (c > a)
                {
                    temps = c;
                    c = a;
                    a = temps;

                }
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                double h = 2 * area / a;
                double point = (h * h) - (b * b);
                int h2 = Convert.ToInt32(h);
                if (point < 0)
                {
                    point *= (-1);
                    double temp = Math.Sqrt(point);

                    point2 = Convert.ToInt32(temp);

                }
                else
                {
                    double temp = Math.Sqrt(point);

                    point2 = Convert.ToInt32(temp);
                }




                Point[] points = new Point[3];
                points[0] = new Point(k, l);
                points[1] = new Point(k, a+l);
                points[2] = new Point(h2+k, point2+l);

                Pen p = new Pen(Color.Black, 2);
                g.DrawLine(p, points[0], points[1]);
                g.DrawLine(p, points[1], points[2]);
                g.DrawLine(p, points[0], points[2]);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not a valid triangle");

            }
        }

    }

}

