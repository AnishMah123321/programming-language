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

namespace ASEassignment
{
    public partial class Form1 : Form
    {


      

        int pt1 = 0, pt2 = 0;
        int radius = 0, width = 0, height = 0;
        int countmethod=0;
        Graphics g;
        string methodname;
        string[] paramaters = new string[100];
      
        /// <summary>
        /// not used
        /// </summary>
        public object Validator { get; set; }
        /// <summary>
        /// initializing component
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            g = Artboard.CreateGraphics();

        }/// <summary>
        /// Single line command compiler
        /// </summary>
        public void Runboxmethod()
        {
            String fetchtext = Runtextbox.Text;
            Validator v = new Validator();
            String[] result = v.getValidate(fetchtext);
            if (result[0] == "moveto")
            {
                int a = Convert.ToInt32(result[1]);
                int b = Convert.ToInt32(result[2]);
                pt1 = a;
                pt2 = b;
            }
            else if (result[0] == "drawto")
            {
                ShapeChooser s1 = new ShapeChooser();
                Interface1 sh = s1.getShape(result[0]);
                sh.drawShape(result, g, pt1, pt2);
            }

            else if (result[0] == "rectangle")
            {
                ShapeChooser s1 = new ShapeChooser();
                Interface1 sh = s1.getShape(result[0]);
                sh.drawShape(result, g, pt1, pt2);
            }

            else if (result[0] == "circle")
            {
                ShapeChooser s1 = new ShapeChooser();
                Interface1 sh = s1.getShape(result[0]);
                sh.drawShape(result, g, pt1, pt2);

            }
            else if (result[0] == "triangle")
            {
                ShapeChooser s1 = new ShapeChooser();
                Interface1 sh = s1.getShape(result[0]);
                sh.drawShape(result, g, pt1, pt2);
            }

            else if (result[0] == "a")
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid command");

            }
            else
            {
                if (result[0] == "errormoveto")
                {
                    System.Windows.Forms.MessageBox.Show("Format : moveto point point");

                }
                if (result[0] == "errordrawto")
                {
                    System.Windows.Forms.MessageBox.Show("Format : DRAWTO point point");

                }
                if (result[0] == "rectangleerror")
                {
                    System.Windows.Forms.MessageBox.Show("Format : RECTANGLE side side");

                }
                if (result[0] == "circleerror")
                {
                    System.Windows.Forms.MessageBox.Show("Format : CIRCLE radius");

                }
                if (result[0] == "triangleerror")
                {
                    System.Windows.Forms.MessageBox.Show("Format : TRIANGLE side side side");

                }
                if (result[0] == "radiuserror")
                {
                    System.Windows.Forms.MessageBox.Show("Format : RADIUS length\n RADIUS + LENGTH ");

                }
                if (result[0] == "widtherror")
                {
                    System.Windows.Forms.MessageBox.Show("Format : WIDTH length\n WIDTH + LENGTH");

                }
                if (result[0] == "heighterror")
                {
                    System.Windows.Forms.MessageBox.Show("Format : HEIGHT length\n HEIGHT + LENGTH");

                }
            }
        }/// <summary>
        /// Compile command in loop
        /// </summary>
        /// <param no_of_times_to_loop="loopvalue"></param>
        /// <param current_index_in_array="counter"></param>
        /// <returns></returns>
        public int looper(int loopvalue, int counter)
        {

            int countcheck = 0;
            int temp = counter + loopvalue;
            for (int j2 = counter; j2 < temp; j2++)
            {
                int numb3 = 0;
                int temp2 = counter;
                String[] result;
                countcheck = 0;
                do
                {
                    countcheck = countcheck + 1;
                    string fetchtext = string.Format("textbox");
                    fetchtext = Grouptextcmd.Lines[temp2];
                    Validator v = new Validator();
                    result = v.getValidate(fetchtext);

                    if (result[0] == "moveto")
                    {
                        int a = Convert.ToInt32(result[1]);
                        int b = Convert.ToInt32(result[2]);
                        pt1 = a;
                        pt2 = b;
                    }

                    else if (result[0] == "drawto")
                    {
                        ShapeChooser s1 = new ShapeChooser();
                        Interface1 sh = s1.getShape(result[0]);
                        sh.drawShape(result, g, pt1, pt2);
                    }

                    else if (result[0] == "rectangle")
                    {
                        ShapeChooser s1 = new ShapeChooser();
                        Interface1 sh = s1.getShape(result[0]);
                        sh.drawShape(result, g, pt1, pt2);
                    }
                    else if (result[0] == "rectangle3")
                    {
                        ShapeChooser s1 = new ShapeChooser();
                        String width2 = Convert.ToString(width);
                        String height2 = Convert.ToString(height);
                        String[] tempresult = { "rectangle", width2, height2 };


                        Interface1 sh = s1.getShape(tempresult[0]);


                        sh.drawShape(tempresult, g, pt1, pt2);

                    }
                    else if (result[0] == "rectangle4")
                    {
                        ShapeChooser s1 = new ShapeChooser();
                        String width2 = result[1];
                        String height2 = Convert.ToString(height);
                        String[] tempresult = { "rectangle", width2, height2 };


                        Interface1 sh = s1.getShape(tempresult[0]);


                        sh.drawShape(tempresult, g, pt1, pt2);

                    }
                    else if (result[0] == "rectangle2")
                    {
                        ShapeChooser s1 = new ShapeChooser();
                        String width2 = Convert.ToString(width);
                        String height2 = result[1];
                        String[] tempresult = { "rectangle", width2, height2 };


                        Interface1 sh = s1.getShape(tempresult[0]);


                        sh.drawShape(tempresult, g, pt1, pt2);

                    }
                    else if (result[0] == "width")
                    {
                        int a = Convert.ToInt32(result[1]);
                        width = a;

                    }
                    else if (result[0] == "width2")
                    {
                        int a = Convert.ToInt32(result[1]);
                        width = width + a;

                    }
                    else if (result[0] == "height")
                    {
                        int a = Convert.ToInt32(result[1]);
                        height = a;
                    }
                    else if (result[0] == "height2")
                    {
                        int a = Convert.ToInt32(result[1]);
                        height = height + a;

                    }



                    else if (result[0] == "circle")
                    {
                        ShapeChooser s1 = new ShapeChooser();
                        Interface1 sh = s1.getShape(result[0]);
                        sh.drawShape(result, g, pt1, pt2);

                    }
                    else if (result[0] == "circle2")
                    {

                       

                        ShapeChooser s1 = new ShapeChooser();
                        radius = radius + radius;
                        String radius2 = Convert.ToString(radius);
                        radius = radius / 2;
                        String[] tempresult = { "circle", radius2 };
                        Interface1 sh = s1.getShape(tempresult[0]);
                        sh.drawShape(tempresult, g, pt1, pt2);

                    }
                    else if (result[0] == "radius")
                    {
                        int a = Convert.ToInt32(result[1]);
                        radius = a;

                    }
                    else if (result[0] == "radius2")
                    {
                        int a = Convert.ToInt32(result[1]);
                        
                        radius = radius + a;

                    }

                    else if (result[0] == "triangle")
                    {
                        ShapeChooser s1 = new ShapeChooser();
                        Interface1 sh = s1.getShape(result[0]);
                        sh.drawShape(result, g, pt1, pt2);
                    }

                    else if (result[0] == "ifw")
                    {
                        
                        int numb2 = Convert.ToInt32(result[3]);
                        numb3 = ifmethodw(width, result[2], numb2, temp2 + 1);
                        temp2 = numb3;

                        
                    }
                    else if (result[0] == "ifh")
                    {
                        int numb2 = Convert.ToInt32(result[3]);
                        numb3 = ifmethodw(height, result[2], numb2, temp2 + 1);
                        temp2 = numb3;

                    }
                    else if (result[0] == "ifr")
                    {
                        int numb2 = Convert.ToInt32(result[3]);
                        numb3 = ifmethodw(radius, result[2], numb2, temp2 + 1);
                        temp2 = numb3;

                    }


                    else if (result[0] == "a")
                    {
                        System.Windows.Forms.MessageBox.Show("Please enter a valid command");

                    }
                    else
                    {
                        int j = j2 + 1;
                        if (result[0] == "errormoveto")
                        {
                            System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : moveto point point");

                        }
                        if (result[0] == "errordrawto")
                        {
                            System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : DRAWTO point point");

                        }
                        if (result[0] == "rectangleerror")
                        {
                            System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : RECTANGLE side side");

                        }
                        if (result[0] == "circleerror")
                        {
                            System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : CIRCLE radius");

                        }
                        if (result[0] == "triangleerror")
                        {
                            System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : TRIANGLE side side side");

                        }
                        if (result[0] == "radiuserror")
                        {
                            System.Windows.Forms.MessageBox.Show("Format : RADIUS length\n RADIUS + LENGTH ");

                        }
                        if (result[0] == "widtherror")
                        {
                            System.Windows.Forms.MessageBox.Show("Format : WIDTH length\n WIDTH + LENGTH");

                        }
                        if (result[0] == "heighterror")
                        {
                            System.Windows.Forms.MessageBox.Show("Format : HEIGHT length\n HEIGHT + LENGTH");

                        }
                        if (result[0] == "looperror")
                        {
                            if (result.Length > 1)
                            {
                                string[] result2;
                                do
                                {
                                    string fetchtext5 = string.Format("textbox");
                                    fetchtext5 = Grouptextcmd.Lines[temp2];
                                    Validator v2 = new Validator();
                                    result2 = v2.getValidate(fetchtext5);
                                    temp2 = temp2 + 1;
                                } while (result2[0] != "end");
                                temp2 = temp2 - 1;
                            }
                            System.Windows.Forms.MessageBox.Show("Format : LOOP number");


                        }
                        if (result[0] == "iferror")
                        {
                            if (result.Length > 1)
                            {
                                string[] result2;
                                do
                                {
                                    string fetchtext5 = string.Format("textbox");
                                    fetchtext5 = Grouptextcmd.Lines[temp2];
                                    Validator v2 = new Validator();
                                    result2 = v2.getValidate(fetchtext5);
                                    temp2 = temp2 + 1;
                                } while (result2[0] != "endif");
                                temp2 = temp2 - 1;
                            }
                            System.Windows.Forms.MessageBox.Show("Format : IF variable syntax number");


                        }
                        if (result[0] == "methoderror")
                        {
                            if (result.Length > 1)
                            {
                                string[] result2;
                                do
                                {
                                    string fetchtext6 = string.Format("textbox");
                                    fetchtext6 = Grouptextcmd.Lines[temp2];
                                    Validator v2 = new Validator();
                                    result2 = v2.getValidate(fetchtext6);
                                    temp2 = temp2 + 1;
                                } while (result2[0] != "endmethod");
                                temp2 = temp2 - 1;
                            }
                            System.Windows.Forms.MessageBox.Show("Format : Method methodname ( paramater list seperated by ; )");

                        }



                    }
                    temp2 = temp2 + 1;

                } while (result[0] != "end");
               
            }
            return countcheck;
        }/// <summary>
        /// To check if paramater
        /// </summary>
        /// <param variable_to_compare ="variable"></param>
        /// <param symbol="symb"></param>
        /// <param number_to_compare="numb"></param>
        /// <param index_in_array="lineno"></param>
        /// <returns></returns>

        public int ifmethodw(int variable, string symb, int numb, int lineno)
        {
            int counter=lineno;
            if (symb == "=")
            {
                if (variable == numb)
                {
                   counter = ifmethod(lineno);
                    

                }
                else
                {
                    string[] result2;
                    do
                    {
                        string fetchtext = string.Format("textbox");
                        fetchtext = Grouptextcmd.Lines[counter];
                        Validator v = new Validator();
                        result2 = v.getValidate(fetchtext);
                        counter = counter + 1;
                    } while (result2[0] != "endif");
                    counter = counter - 1;

                }
            }
            else if (symb == ">")
            {
                if (variable > numb)
                {
                    counter = ifmethod(lineno);
                    
                }
                else
                {
                    string[] result2;
                    do
                    {
                        string fetchtext = string.Format("textbox");
                        fetchtext = Grouptextcmd.Lines[counter];
                        Validator v = new Validator();
                        result2 = v.getValidate(fetchtext);
                        counter = counter + 1;
                    } while (result2[0] != "endif");
                    counter = counter - 1;


                }
            }
            else if (symb == "<")
            {
                if (variable < numb)
                {
                    counter = ifmethod(lineno);
                    
                }
                else
                {
                    string[] result2;
                    do
                    {
                        string fetchtext = string.Format("textbox");
                        fetchtext = Grouptextcmd.Lines[counter];
                        Validator v = new Validator();
                        result2 = v.getValidate(fetchtext);
                        counter = counter + 1;
                    } while (result2[0] != "endif");
                    counter = counter - 1;


                }
            }
            else
            {
                
                    
               
            }
            return counter;
        }/// <summary>
        /// to run command inside if
        /// </summary>
        /// <param index_in_array="lineno"></param>
        /// <returns></returns>

        public int ifmethod(int lineno)
        {
            String[] result;
            int counterr = lineno;
            do
            {
                string fetchtext = string.Format("textbox");
                fetchtext = Grouptextcmd.Lines[counterr];
                Validator v = new Validator();
                result = v.getValidate(fetchtext);
                if (result[0] == "moveto")
                {
                    int a = Convert.ToInt32(result[1]);
                    int b = Convert.ToInt32(result[2]);
                    pt1 = a;
                    pt2 = b;
                }
                else if (result[0] == "drawto")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);
                }

                else if (result[0] == "rectangle")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);
                }
                else if (result[0] == "rectangle3")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    String width2 = Convert.ToString(width);
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };


                    Interface1 sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "rectangle4")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    String width2 = result[1];
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };


                    Interface1 sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "rectangle2")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    String width2 = Convert.ToString(width);
                    String height2 = result[1];
                    String[] tempresult = { "rectangle", width2, height2 };
                    Interface1 sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "width")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = a;

                }
                else if (result[0] == "width2")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = width + a;

                }
                else if (result[0] == "height")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = a;
                }
                else if (result[0] == "height2")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = height + a;

                }


                else if (result[0] == "circle")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);

                }
                else if (result[0] == "circle2")
                {

                    
                    ShapeChooser s1 = new ShapeChooser();
                    radius = radius + radius;
                    String radius2 = Convert.ToString(radius);
                    String[] tempresult = { "circle", radius2 };
                    radius = radius / 2;
                    Interface1 sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pt1, pt2);
                    

                }
                else if (result[0] == "radius")
                {
                    int a2 = Convert.ToInt32(result[1]);
                    radius = a2;

                }
                else if (result[0] == "radius2")
                {
                    int a2 = Convert.ToInt32(result[1]);
                    radius = radius + a2;

                }
                else if (result[0] == "triangle")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);
                }
                else if (result[0] == "loop")
                {
                    int a = Convert.ToInt32(result[1]);
                    int counter2 = looper(a, counterr + 1);

                    counterr = counterr + counter2;

                }
                
                else if (result[0] == "a")
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a valid command");

                }
                else
                {
                    int j = counterr + 1;
                    if (result[0] == "errormoveto")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : moveto point point");

                    }
                    if (result[0] == "errordrawto")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : DRAWTO point point");

                    }
                    if (result[0] == "rectangleerror")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : RECTANGLE side side");

                    }
                    if (result[0] == "circleerror")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : CIRCLE radius");

                    }
                    if (result[0] == "triangleerror")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : TRIANGLE side side side");

                    }
                    if (result[0] == "radiuserror")
                    {
                        System.Windows.Forms.MessageBox.Show("Format : RADIUS length\n RADIUS + LENGTH ");

                    }
                    if (result[0] == "widtherror")
                    {
                        System.Windows.Forms.MessageBox.Show("Format : WIDTH length\n WIDTH + LENGTH");

                    }
                    if (result[0] == "heighterror")
                    {
                        System.Windows.Forms.MessageBox.Show("Format : HEIGHT length\n HEIGHT + LENGTH");

                    }
                    if (result[0] == "looperror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[counterr];
                                Validator v2 = new Validator();
                                result2 = v2.getValidate(fetchtext5);
                                counterr = counterr + 1;
                            } while (result2[0] != "end");
                            counterr = counterr - 1;
                        }
                        System.Windows.Forms.MessageBox.Show("Format : LOOP number");


                    }
                    if (result[0] == "iferror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[counterr];
                                Validator v2 = new Validator();
                                result2 = v2.getValidate(fetchtext5);
                                counterr = counterr + 1;
                            } while (result2[0] != "endif");
                            counterr = counterr - 1;
                        }
                        System.Windows.Forms.MessageBox.Show("Format : IF variable syntax number");


                    }
                    if (result[0] == "methoderror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext6 = string.Format("textbox");
                                fetchtext6 = Grouptextcmd.Lines[counterr];
                                Validator v2 = new Validator();
                                result2 = v2.getValidate(fetchtext6);
                                counterr = counterr + 1;
                            } while (result2[0] != "endmethod");
                            counterr = counterr - 1;
                        }
                        System.Windows.Forms.MessageBox.Show("Format : Method methodname ( paramater list seperated by ; )");


                    }
                }
                counterr = counterr + 1;
            } while (result[0].ToUpper() != "ENDIF");
            return counterr-1;
        }/// <summary>
        /// method creation
        /// </summary>
        /// <param index_in_array="lineno"></param>
        public void methodmethod(int lineno)
        {
            String[] result;
            int counterr = lineno;
            do
            {
                string fetchtext = string.Format("textbox");
                fetchtext = Grouptextcmd.Lines[counterr];
                Validator v = new Validator();
                result = v.getValidate(fetchtext);
                if (result[0] == "moveto")
                {
                    int a = Convert.ToInt32(result[1]);
                    int b = Convert.ToInt32(result[2]);
                    pt1 = a;
                    pt2 = b;
                }
                else if (result[0] == "drawto")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);
                }

                else if (result[0] == "rectangle")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);
                }
                else if (result[0] == "rectangle3")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    String width2 = Convert.ToString(width);
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };


                    Interface1 sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "rectangle4")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    String width2 = result[1];
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };


                    Interface1 sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "rectangle2")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    String width2 = Convert.ToString(width);
                    String height2 = result[1];
                    String[] tempresult = { "rectangle", width2, height2 };
                    Interface1 sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "width")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = a;

                }
                else if (result[0] == "width2")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = width + a;

                }
                else if (result[0] == "height")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = a;
                }
                else if (result[0] == "height2")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = height + a;

                }


                else if (result[0] == "circle")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);

                }
                else if (result[0] == "circle2")
                {


                    ShapeChooser s1 = new ShapeChooser();
                    radius = radius + radius;
                    String radius2 = Convert.ToString(radius);
                    String[] tempresult = { "circle", radius2 };
                    radius = radius / 2;
                    Interface1 sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pt1, pt2);


                }
                else if (result[0] == "radius")
                {
                    int a2 = Convert.ToInt32(result[1]);
                    radius = a2;

                }
                else if (result[0] == "radius2")
                {
                    int a2 = Convert.ToInt32(result[1]);
                    radius = radius + a2;

                }
                else if (result[0] == "triangle")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);
                }
                else if (result[0] == "loop")
                {
                    int a = Convert.ToInt32(result[1]);
                    int counter2 = looper(a, counterr + 1);

                    counterr = counterr + counter2;

                }
                else if (result[0] == "ifw")
                {

                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(width, result[2], numb2, counterr + 1);
                    counterr = counter2;
                }
                else if (result[0] == "ifh")
                {
                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(height, result[2], numb2, counterr + 1);
                    counterr = counter2;
                }
                else if (result[0] == "ifr")
                {
                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(radius, result[2], numb2, counterr + 1);
                    counterr = counter2;
                }

                else if (result[0] == "a")
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a valid command");

                }
                else
                {
                    int j = counterr + 1;
                    if (result[0] == "errormoveto")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : moveto point point");

                    }
                    if (result[0] == "errordrawto")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : DRAWTO point point");

                    }
                    if (result[0] == "rectangleerror")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : RECTANGLE side side");

                    }
                    if (result[0] == "circleerror")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : CIRCLE radius");

                    }
                    if (result[0] == "triangleerror")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : TRIANGLE side side side");

                    }
                    if (result[0] == "radiuserror")
                    {
                        System.Windows.Forms.MessageBox.Show("Format : RADIUS length\n RADIUS + LENGTH ");

                    }
                    if (result[0] == "widtherror")
                    {
                        System.Windows.Forms.MessageBox.Show("Format : WIDTH length\n WIDTH + LENGTH");

                    }
                    if (result[0] == "heighterror")
                    {
                        System.Windows.Forms.MessageBox.Show("Format : HEIGHT length\n HEIGHT + LENGTH");

                    }
                    if (result[0] == "looperror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[counterr];
                                Validator v2 = new Validator();
                                result2 = v2.getValidate(fetchtext5);
                                counterr = counterr + 1;
                            } while (result2[0] != "end");
                            counterr = counterr - 1;

                        }
                        System.Windows.Forms.MessageBox.Show("Format : LOOP number");

                    }
                    if (result[0] == "iferror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[counterr];
                                Validator v2 = new Validator();
                                result2 = v2.getValidate(fetchtext5);
                                counterr = counterr + 1;
                            } while (result2[0] != "endif");
                            counterr = counterr - 1;
                        }
                        System.Windows.Forms.MessageBox.Show("Format : IF variable syntax number");


                    }
                    if (result[0] == "methoderror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext6 = string.Format("textbox");
                                fetchtext6 = Grouptextcmd.Lines[counterr];
                                Validator v2 = new Validator();
                                result2 = v2.getValidate(fetchtext6);
                                counterr = counterr + 1;
                            } while (result2[0] != "endmethod");
                            counterr = counterr - 1;

                        }
                        System.Windows.Forms.MessageBox.Show("Format : Method methodname ( paramater list seperated by ; )");


                    }

                }
                counterr = counterr + 1;
            } while (result[0].ToUpper() != "ENDMETHOD");
        }
        /// <summary>
        /// compile command in group line box
        /// </summary>

        public void GrouptextboxMethod()
        {
            int counttext = Grouptextcmd.Lines.Length;
            for (int i = 0; i < counttext ; i++)
            {
                string fetchtext = string.Format("textbox");
                fetchtext = Grouptextcmd.Lines[i];




                Validator v = new Validator();
                String[] result = v.getValidate(fetchtext);
                if (result[0] == "moveto")
                {
                    int a = Convert.ToInt32(result[1]);
                    int b = Convert.ToInt32(result[2]);
                    pt1 = a;
                    pt2 = b;
                }
                else if (result[0] == "drawto")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);
                }

                else if (result[0] == "rectangle")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);
                }
                else if (result[0] == "rectangle3")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    String width2 = Convert.ToString(width);
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };


                    Interface1 sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "rectangle4")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    String width2 = result[1];
                    String height2 = Convert.ToString(height);
                    String[] tempresult = { "rectangle", width2, height2 };


                    Interface1 sh = s1.getShape(tempresult[0]);


                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "rectangle2")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    String width2 = Convert.ToString(width);
                    String height2 = result[1];
                    String[] tempresult = { "rectangle", width2, height2 };
                    Interface1 sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "width")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = a;

                }
                else if (result[0] == "width2")
                {
                    int a = Convert.ToInt32(result[1]);
                    width = width + a;

                }
                else if (result[0] == "height")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = a;
                }
                else if (result[0] == "height2")
                {
                    int a = Convert.ToInt32(result[1]);
                    height = height + a;

                }


                else if (result[0] == "circle")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);

                }
                else if (result[0] == "circle2")
                {
                    

                    ShapeChooser s1 = new ShapeChooser();
                    radius = radius + radius;
                    String radius2 = Convert.ToString(radius);
                    String[] tempresult = { "circle", radius2 };
                    radius = radius / 2;
                    Interface1 sh = s1.getShape(tempresult[0]);
                    sh.drawShape(tempresult, g, pt1, pt2);

                }
                else if (result[0] == "radius")
                {
                    int a = Convert.ToInt32(result[1]);
                    radius = a;

                }
                else if (result[0] == "radius2")
                {
                    int a = Convert.ToInt32(result[1]);
                    radius = radius + a;

                }
                else if (result[0] == "triangle")
                {
                    ShapeChooser s1 = new ShapeChooser();
                    Interface1 sh = s1.getShape(result[0]);
                    sh.drawShape(result, g, pt1, pt2);
                }
                else if (result[0] == "loop")
                {
                    int a = Convert.ToInt32(result[1]);
                    int counter2 = looper(a, i + 1);

                    i = i + counter2;

                }
                else if (result[0] == "ifw")
                {

                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(width, result[2], numb2, i + 1);
                    i = counter2;
                }
                else if (result[0] == "ifh")
                {
                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(height, result[2], numb2, i + 1);
                    i = counter2;
                }
                else if (result[0] == "ifr")
                {
                    int numb2 = Convert.ToInt32(result[3]);
                    int counter2 = ifmethodw(radius, result[2], numb2, i + 1);
                    i = counter2;
                }
                else if (result[0] == "method")
                {
                    int lengthres = result.Length;
                    countmethod = i;

                    methodname = result[1];
                    int countpara = 0;

                    //string tempres;
                   

                        for (int lii = 2; lii < lengthres; lii++)
                    {
                        paramaters[countpara] = result[lii];
                        countpara = countpara + 1;

                    }

                    string[] result2;
                    paramaters = paramaters.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                   
                        do
                        {
                            string fetchtext6 = string.Format("textbox");
                            fetchtext6 = Grouptextcmd.Lines[i];
                            Validator v2 = new Validator();
                            result2 = v2.getValidate(fetchtext6);
                            i = i + 1;
                        } while (result2[0] != "endmethod");


                        i = i - 1;
                   


                }
                else if (result[0] == "parameters")
                {
                    
                    if (result[1]==methodname && paramaters.Length == result.Length-2)
                    {
                        int lengthres = result.Length;
                        int countmethod2 = countmethod+1;
                       
                        for (int lii = 2; lii < lengthres; lii++)
                        {
                           
                                if (result[lii].ToUpper() == "RADIUS")
                                { 
                                    result[lii] =Convert.ToString(radius);


                            }
                            else if (result[lii].ToUpper() == "WIDTH")
                                {
                                result[lii] = Convert.ToString(width);
                            }
                                else if (result[lii].ToUpper() == "HEIGHT")
                                {
                                result[lii] = Convert.ToString(height);
                            }
                            else
                            {

                            }
                           
                        }

                        methodmethod(countmethod2);

                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Method doesnot exist");
                        
                    }
                    
                }
                else if (result[0] == "a")
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a valid command");

                }
                else
                {
                    int j = i + 1;
                    if (result[0] == "errormoveto")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : moveto point point");

                    }
                    if (result[0] == "errordrawto")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : DRAWTO point point");

                    }
                    if (result[0] == "rectangleerror")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : RECTANGLE side side");

                    }
                    if (result[0] == "circleerror")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : CIRCLE radius");

                    }
                    if (result[0] == "triangleerror")
                    {
                        System.Windows.Forms.MessageBox.Show("Error in line " + " " + j + " " + "Format : TRIANGLE side side side");

                    }
                    if (result[0] == "radiuserror")
                    {
                        System.Windows.Forms.MessageBox.Show("Format : RADIUS length\n RADIUS + LENGTH ");

                    }
                    if (result[0] == "widtherror")
                    {
                        System.Windows.Forms.MessageBox.Show("Format : WIDTH length\n WIDTH + LENGTH");

                    }
                    if (result[0] == "heighterror")
                    {
                        System.Windows.Forms.MessageBox.Show("Format : HEIGHT length\n HEIGHT + LENGTH");

                    }
                    if (result[0] == "looperror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[i];
                                Validator v2 = new Validator();
                                result2 = v2.getValidate(fetchtext5);
                                i = i + 1;
                            } while (result2[0] != "end");

                            i = i - 1;
                        }
                        System.Windows.Forms.MessageBox.Show("Format : LOOP number");


                    }
                    if (result[0] == "iferror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext5 = string.Format("textbox");
                                fetchtext5 = Grouptextcmd.Lines[i];
                                Validator v2 = new Validator();
                                result2 = v2.getValidate(fetchtext5);
                                i = i + 1;
                            } while (result2[0] != "endif");
                            i = i - 1;
                        }
                        System.Windows.Forms.MessageBox.Show("Format : IF variable syntax number");
                        

                    }
                    if (result[0] == "methoderror")
                    {
                        if (result.Length > 1)
                        {
                            string[] result2;
                            do
                            {
                                string fetchtext6 = string.Format("textbox");
                                fetchtext6 = Grouptextcmd.Lines[i];
                                Validator v2 = new Validator();
                                result2 = v2.getValidate(fetchtext6);
                                i = i + 1;
                            } while (result2[0] != "endmethod");
                            i = i - 1;
                        }
                        System.Windows.Forms.MessageBox.Show("Format : Method methodname ( paramater list seperated by ; )");

                    }



                }
            }
            }
            private void Cleargrouptext_Click(object sender, EventArgs e)
            {
                Artboard.Refresh();

            }

            private void RunButton_Click(object sender, EventArgs e)
            {
                Runboxmethod();
            }

            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
                
                    SaveFileDialog saveDial = new SaveFileDialog();
                    saveDial.Title = "Anish";
                    saveDial.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";

                    if (saveDial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        StreamWriter saveStream = new StreamWriter(File.Create(saveDial.FileName));
                        saveStream.Write(Grouptextcmd.Text);

                        saveStream.Dispose();
                    }
                
            }

            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
                OpenFileDialog openDial = new OpenFileDialog();
                openDial.Title = "Anish";
                openDial.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";

                if (openDial.ShowDialog() == DialogResult.OK)
                {
                    StreamReader openStream = new StreamReader(File.OpenRead(openDial.FileName));
                    Grouptextcmd.Text = openStream.ReadToEnd();
                    openStream.Dispose();
                }
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void Resetbutton_Click(object sender, EventArgs e)
            {
                pt1 = 0;
                pt2 = 0;
            }

        private void Artboard_Paint(object sender, PaintEventArgs e)
        {

        }
       
       


        private void Grouptextcmd_TextChanged(object sender, EventArgs e)
            {

            }

           private void Grouptextrunbutton_Click(object sender, EventArgs e)
            {
                GrouptextboxMethod();
            }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDial = new SaveFileDialog();
            saveDial.Title = "Anish";
            saveDial.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";

            if (saveDial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter saveStream = new StreamWriter(File.Create(saveDial.FileName));
                saveStream.Write(Grouptextcmd.Text);

                saveStream.Dispose();
            }
        }

        private void variableListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("For circle : Radius\nFor rectangle : Width & Height");

        }

        private void variableCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Variable type + number");
        }


        private void Artboard_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDial = new OpenFileDialog();
            openDial.Title = "Anish";
            openDial.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";

            if (openDial.ShowDialog() == DialogResult.OK)
            {
                StreamReader openStream = new StreamReader(File.OpenRead(openDial.FileName));
                Grouptextcmd.Text = openStream.ReadToEnd();
                openStream.Dispose();
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Format : moveto point point\nFormat : DRAWTO point point\nFormat : RECTANGLE side side\nFormat : CIRCLE radius\nFormat : TRIANGLE side side side");

        }

        private void Runtextbox_TextChanged(object sender, EventArgs e)
            {

            }
        
    }
}
