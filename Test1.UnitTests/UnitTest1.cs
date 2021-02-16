using System;
using ASEassignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Moveto_Right_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("moveto 10 10");
            Assert.AreEqual(result[0], "moveto", result[1], "10", result[2], "10");

        }
        [TestMethod]
        public void Test_Moveto_Wrong_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("moveto 10");
            Assert.AreEqual(result[0], "errormoveto");

        }
        [TestMethod]
        public void Test_Drawto_Right_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("drawto 10 10");
            Assert.AreEqual(result[0], "drawto", result[1], "10", result[2], "10");

        }
        [TestMethod]
        public void Test_Drawto_Wrong_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("drawto 10");
            Assert.AreEqual(result[0], "errordrawto");

        }
        [TestMethod]
        public void Test_Rectangle_Right_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("rectangle 10 10");
            Assert.AreEqual(result[0], "rectangle", result[1], "10", result[2], "10");

        }
        [TestMethod]
        public void Test_Rectangle_Wrong_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("rectangle 10 10 50");
            Assert.AreEqual(result[0], "rectangleerror");

        }
        [TestMethod]
        public void Test_Circle_Right_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("circle 10");
            Assert.AreEqual(result[0], "circle", result[1], "10");

        }
        [TestMethod]
        public void Test_Circle_Wrong_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("circle 10 50");
            Assert.AreEqual(result[0], "circleerror");

        }
        [TestMethod]
        public void Test_Triangle_Right_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("triangle 50 50 50");
            Assert.AreEqual(result[0], "triangle", result[1], "50", result[2], "50", result[3], "50");

        }
        [TestMethod]
        public void Test_Triangle_Wrong_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("triangle 10 10");
            Assert.AreEqual(result[0], "triangleerror");

        }
        [TestMethod]
        public void Test_Loop_Wrong_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("loop 10 10");
            Assert.AreEqual(result[0], "looperror");

        }
        [TestMethod]
        public void Test_Loop_right_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("loop 10");
            Assert.AreEqual(result[0], "loop");

        }
        [TestMethod]
        public void Test_if_Wrong_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("if 10 10");
            Assert.AreEqual(result[0], "iferror");

        }
        [TestMethod]
        public void Test_if_right_value_test()
        {
            var v = new Validator();
            string[] result = v.getValidate("if radius = 10");
            Assert.AreEqual(result[0], "ifr");

        }




    }
}
