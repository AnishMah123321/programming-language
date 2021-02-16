using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEassignment
{/// <summary>
/// To create line
/// </summary>
    class Drawto : Interface1
    {
        /// <summary>
        /// to deaw a line
        /// </summary>
        /// <param coordinates="res"></param>
        /// <param graphics="g"></param>
        /// <param point_one="k"></param>
        /// <param point_two="l"></param>
        public void drawShape(string[] res, Graphics g, int k, int l)
        {
            int a = Convert.ToInt32(res[1]);
            int b = Convert.ToInt32(res[2]);
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, k, l, a, b);
        }
    }
}
