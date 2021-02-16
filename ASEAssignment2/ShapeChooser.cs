using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEassignment
{
    class ShapeChooser
    {/// <summary>
    ///To choose shape
    /// </summary>
    /// <param shape_identifier="text"></param>
    /// <returns></returns>
        public Interface1 getShape(string text)
        {

            if (text == "drawto")
            {
                return new Drawto();
            }
            else if (text == "rectangle")
            {
                return new Rectangle();
            }
           else if (text == "circle")
            {
                return new Circle();
            }
           else if (text == "triangle")
            {
                return new Triangle();
            }
                



            return null;




        }
    }
}
