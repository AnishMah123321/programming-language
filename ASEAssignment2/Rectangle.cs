using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEassignment
{
    /// <summary>
    /// to create rectangle
    /// </summary>
    class Rectangle : Interface1
    {
      
        /// <summary>
        /// It is used to draw rectangle
        /// </summary>
        /// <param length_and_height="res"></param>
        /// <param graphuics="g"></param>
        /// <param point_one="k"></param>
        /// <param poinnt_two ="l"></param>
        public void drawShape(string[] res, Graphics g, int k, int l)
        {
            int a = Convert.ToInt32(res[1]);
            int b = Convert.ToInt32(res[2]);
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, k, l, a, b);
        }
    }
}
