using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEassignment
{/// <summary>
/// class validator for validation
/// </summary>
    public class Validator
    {
        /// <summary>
        /// To Validate and check syntax of commands
        /// </summary>
        /// <param commands="a"></param>
        /// <returns></returns>
        public string[] getValidate(string a)
        {
            string[] meth = new string[100];

            string[] txt = {};
           
            string[] send = a.Split(',',' ');

            if (send[0].ToUpper() == "MOVETO")
            {
                if (send.Length == 3)
                {
                    int x = Convert.ToInt32(send[1]);
                    int y = Convert.ToInt32(send[2]);
                    string a1 = Convert.ToString(x);
                    string b1 = Convert.ToString(y);
                    string[] k = { "moveto", a1, b1 };
                    txt = k;
                }
                else
                {

                    string[] k = { "errormoveto" };
                    txt = k;
                }
            }
            else if (send[0].ToUpper() == "DRAWTO")
            {
                if (send.Length == 3)
                {
                    int x = Convert.ToInt32(send[1]);
                    int y = Convert.ToInt32(send[2]);
                    string a1 = Convert.ToString(x);
                    string b1 = Convert.ToString(y);
                    string[] k = { "drawto", a1, b1 };
                    txt = k;
                }
                else
                {
                    string[] k = { "errordrawto" };
                    txt = k;
                }
            }
            else if (send[0].ToUpper() == "RECTANGLE")
            {
                if (send.Length == 3)
                {
                    if (send[1].ToUpper() == "WIDTH" || send[1].ToUpper() == "HEIGHT")
                    {

                        if (send[2].ToUpper() == "WIDTH" || send[2].ToUpper() == "HEIGHT")
                        {
                            string[] side = { "rectangle3" };
                            txt = side;
                        }
                        else
                        {
                            int y = Convert.ToInt32(send[2]);
                            string b1 = Convert.ToString(y);
                            string[] side = { "rectangle2", b1 };
                            txt = side;
                        }
                    }
                    else if (send[2].ToUpper() == "WIDTH" || send[2].ToUpper() == "HEIGHT")
                    {

                        if (send[1].ToUpper() == "WIDTH" || send[1].ToUpper() == "HEIGHT")
                        {
                            string[] side = { "rectangle3" };
                            txt = side;
                        }
                        else
                        {
                            int x = Convert.ToInt32(send[1]);
                            string a1 = Convert.ToString(x);
                            string[] side = { "rectangle4", a1 };
                            txt = side;
                        }
                    }

                    else
                    {
                        int x = Convert.ToInt32(send[1]);
                        int y = Convert.ToInt32(send[2]);
                        string a1 = Convert.ToString(x);
                        string b1 = Convert.ToString(y);
                        string[] k = { "rectangle", a1, b1 };
                        txt = k;
                    }

                }

                else
                {
                    string[] k = { "rectangleerror" };
                    txt = k;
                }
            }

            else if (send[0].ToUpper() == "WIDTH")
            {
                if (send.Length == 2)
                {

                    int x = Convert.ToInt32(send[1]);


                    string a1 = Convert.ToString(x);

                    string[] k = { "width", a1 };
                    txt = k;

                }
                else if (send.Length == 3)
                {
                    if (send[1] == "+")
                    {
                        int x = Convert.ToInt32(send[2]);


                        string a1 = Convert.ToString(x);

                        string[] k = { "width2", a1 };
                        txt = k;
                    }
                    else
                    {
                        string[] k = { "widtherror" };
                        txt = k;
                    }

                }
                else
                {
                    string[] k = { "widtherror" };
                    txt = k;
                }
            }

            else if (send[0].ToUpper() == "HEIGHT")
            {
                if (send.Length == 2)
                {

                    int x = Convert.ToInt32(send[1]);


                    string a1 = Convert.ToString(x);

                    string[] k = { "height", a1 };
                    txt = k;

                }
                else if (send.Length == 3)
                {
                    if (send[1] == "+")
                    {
                        int x = Convert.ToInt32(send[2]);


                        string a1 = Convert.ToString(x);

                        string[] k = { "height2", a1 };
                        txt = k;
                    }
                    else
                    {
                        string[] k = { "heighterror" };
                        txt = k;
                    }

                }
                else
                {
                    string[] k = { "heighterror" };
                    txt = k;
                }
            }



            else if (send[0].ToUpper() == "CIRCLE")
            {
                if (send.Length == 2)
                {
                    if (send[1].ToUpper() == "RADIUS")
                    {
                        string[] radius2 = { "circle2" };
                        txt = radius2;
                    }
                    else
                    {
                        try
                        {
                            int x = Convert.ToInt32(send[1]);
                            string a1 = Convert.ToString(x + x);
                            string[] radius2 = { "circle", a1 };
                            txt = radius2;
                        }
                        catch(Exception e)
                        {
                            string[] k = { "circleerror" };
                            txt = k;

                        }
                    }

                }
                else
                {
                    string[] k = { "circleerror" };
                    txt = k;
                }
            }
            else if (send[0].ToUpper() == "RADIUS")
            {
                if (send.Length == 2)
                {

                    int x = Convert.ToInt32(send[1]);


                    string a1 = Convert.ToString(x);

                    string[] k = { "radius", a1 };
                    txt = k;
                    

                }
                else if (send.Length == 3)
                {
                    if (send[1] == "+")
                    {
                        int x = Convert.ToInt32(send[2]);


                        string a1 = Convert.ToString(x);

                        string[] k = { "radius2", a1 };
                        txt = k;
                        
                    }
                    else
                    {
                        string[] k = { "radiuserror" };
                        txt = k;
                    }

                }

                else
                {
                    string[] k = { "radiuserror" };
                    txt = k;
                }
            }
            else if (send[0].ToUpper() == "TRIANGLE")
            {
                if (send.Length == 4)
                {

                    int x = Convert.ToInt32(send[1]);
                    int y = Convert.ToInt32(send[2]);
                    int z = Convert.ToInt32(send[3]);

                    string a1 = Convert.ToString(x);
                    string b1 = Convert.ToString(y);
                    string c1 = Convert.ToString(z);
                    string[] k = { "triangle", a1, b1, c1 };
                    txt = k;

                }
                else
                {
                    string[] k = { "triangleerror" };
                    txt = k;
                }
            }

            else if (send[0].ToUpper() == "LOOP")
            {
                if (send.Length == 2)
                {

                    int x = Convert.ToInt32(send[1]);


                    string a1 = Convert.ToString(x);

                    string[] k = { "loop", a1 };
                    txt = k;

                }
                else
                {
                    string[] k = { "looperror" };
                    txt = k;
                }
            }
            else if (send[0].ToUpper() == "END")
            {

                string[] k = { "end" };
                txt = k;


            }
            else if (send[0].ToUpper() == "ENDIF")
            {

                string[] k = { "endif" };
                txt = k;
            }
            else if (send[0].ToUpper() == "ENDMETHOD")
            {

                string[] k = { "endmethod" };
                txt = k;
            }
            else if (send[0].ToUpper() == "IF")
            {
                if (send.Length == 4)
                {

                    if (send[2] == "=" || send[2] == "<" || send[2] == ">")
                    {
                        int x = Convert.ToInt32(send[3]);
                        string a1 = send[1];
                        string a2 = send[2];
                        string a3 = Convert.ToString(x);
                        if (a1.ToUpper() == "WIDTH")
                        {
                            string[] k = { "ifw", a1, a2, a3 };
                            txt = k;
                        }
                        else if (a1.ToUpper() == "HEIGHT")
                        {
                            string[] k = { "ifh", a1, a2, a3 };
                            txt = k;
                        }
                        else if (a1.ToUpper() == "RADIUS")
                        {
                            string[] k = { "ifr", a1, a2, a3 };
                            txt = k;
                        }
                        else
                        {
                            string[] k = { "iferror" };
                            txt = k;
                        }
                    }
                    else
                    {
                        string[] k = { "iferror" };
                        txt = k;
                    }
                }
                else
                {
                    string[] k = { "iferror" };
                    txt = k;
                }
            }
 

            else if (send[0].ToUpper() == "METHOD" && send.Length >= 3)
                
            {
                string aa = "a"; 
                int length = send.Length;
                length = length - 1;
                int countmeth = 1;
                aa = send[1];
                meth[0] = "method";
                meth[countmeth] = aa;
                if (send.Length == 3 || send.Length == 4) {
                    if (send.Length == 3 && send[2] == "()")
                    {
                        txt = meth;
                    }
                    else if (send.Length == 4 && send[2] == "(" && send[3] == ")")
                    {
                        txt = meth;
                    }
                    else
                    {
                        string[] k = { "methoderror" };
                        txt = k;
                    }
                }
                else if (send[2] == "(" && send[length] == ")" && send.Length>4)
                {
                    for (int li = 3; li < length; li++)
                    {
                        if (li % 2 == 0 && send[li] == ";")
                        {

                        }
                        else if (li % 2 == 0 && send[li] != ";")
                        {
                            string[] k = { "methoderror" };
                            txt = k;
                        }
                        else
                        {
                            countmeth = countmeth + 1;
                            meth[countmeth] = send[li];
                            txt = meth;

                        }
                    }
                }
                 

                else
                {
                    string[] k = { "methoderror" };
                    txt = k;
                }
               
               
                
                

                   
                
            }


            else
            {

                 int length = send.Length;
                length = length - 1;
                int countmeth = 1;
                string aa = send[0];
                meth[0] = "parameters";
                meth[countmeth] = aa;
                if (send.Length >= 2)
                {
                    if (send.Length == 2|| send.Length == 3)
                    {
                        if (send.Length == 2 && send[1] == "()")
                        {
                            txt = meth;
                        }
                        else if (send.Length == 3 && send[1] == "(" && send[2] == ")")
                        {
                            txt = meth;
                        }
                        else
                        {
                            string[] k = { "methoderror" };
                            txt = k;
                        }
                    }
                    else if (send[1] == "(" && send[length] == ")")
                    {
                        for (int li = 2; li < length; li++)
                        {
                            if (li % 2 == 1 && send[li] == ";")
                            {

                            }
                            else if (li % 2 == 1 && send[li] != ";")
                            {
                                string[] k = { "paramerror" };
                                txt = k;
                            }
                            else
                            {
                                countmeth = countmeth + 1;
                                meth[countmeth] = send[li];
                                txt = meth;

                            }
                        }
                    }


                    else
                    {
                        string[] k = { "a" };
                        txt = k;
                    }
                }
                else
                {
                    
                        string[] k = { "a" };
                        txt = k;
                    
                }



               
            }

            txt = txt.Where(x => !string.IsNullOrEmpty(x)).ToArray();



            return txt;
        }

        internal string[] getValidate(TextBox runtextbox)
        {
            throw new NotImplementedException();
        }
    }
}
