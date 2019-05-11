using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP;
using OxyPlot;
using System.Collections.Generic;
using OxyPlot.Series;

namespace CPPUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            Form1 form = new Form1();
            string test = "-(*(/(c(*(r(-5.7),x)),s(l(+(n(27),*(3,^(p,8)))))),!(4)),e(-2))";
            Formula formula = new Formula(test);
            int i = 1;
            Assert.AreEqual(formula.RootFunction.ToString(), "(((cos((-5,7*x))/sin(ln((27+(3*(\u03C0^8))))))*4!)-e(-2))");
            Assert.IsNotNull(formula.RootFunction.CreateGraph(ref i));
            Assert.AreEqual(Math.Round(formula.CalculateRiemannIntegral(1, 2),2),20,62);
            Assert.IsInstanceOfType(formula.GetFunctionSeries(),typeof(FunctionSeries));
            Assert.IsInstanceOfType(formula.GetMacLaurinSeries(3), typeof(FunctionSeries));
            Assert.IsInstanceOfType(formula.NewtonSeries(new Formula(formula.RootFunction.Derivatives())), typeof(FunctionSeries));
            Formula derivativeformula = new Formula(formula.RootFunction.Derivatives());
            Assert.AreEqual(derivativeformula.RootFunction.ToString(), "((((5,7*sin((-5,7*x)))*sin(ln((27+(3*(\u03C0^8))))))/(sin(ln((27+(3*(\u03C0^8)))))*sin(ln((27+(3*(\u03C0^8)))))))*4!)");
        }
        [TestMethod]
        public void TestPoly()
        {
            DataPoint p1 = new DataPoint(2, 1);
            DataPoint p2 = new DataPoint(3, 2);
            DataPoint p3 = new DataPoint(4, -3);
            Matrix matrix = new Matrix();
            matrix.AddPoint(p1);
            matrix.AddPoint(p2);
            matrix.AddPoint(p3);
            Assert.IsInstanceOfType(matrix.GetPolynomialSeries(),typeof(FunctionSeries));
            Assert.AreEqual(matrix.NrofPoint(), 3);
            Assert.AreEqual(matrix.GetFunction(),"-3*x^2 + 16*x + -19");
            matrix.EmptyDataPoints();
            Assert.AreEqual(matrix.NrofPoint(), 0);
        }
        [TestMethod]
        public void TestSimplify()
        {
            string test = "/(+(-(n(10),^(x,2)),*(+(l(^(x,l(^(e(1),2)))),/(l(l(/(e(3),e(2)))),/(p,1))),*(c(-(x,0)),!(5)))),*(s(-(p,^(r(1.5),^(^(x,2),^(2,3))))), *(3,/(*(*(1,e(2)),*(e(2),1)),/(e(0),e(-(+(l(2),l(2)),l(3))))))";
            Formula formula = new Formula(test);
            Assert.AreEqual(formula.RootFunction.ToString(), "(((10-(x^2))+((2*ln(x))*(cos(x)*5!)))/(sin((\u03C0-(1,5^(x^16))))*(e(4)*4)))");
        }
        [TestMethod]
        public void TestSubstractSimplify()
        {
            string test1 = "-(-(x,2),3)";
            Formula formula1 = new Formula(test1);
            Assert.AreEqual(formula1.RootFunction.ToString(), "(x-5)");
            string test2 = "-(-(5,x),3)";
            Formula formula2 = new Formula(test2);
            Assert.AreEqual(formula2.RootFunction.ToString(), "(2-x)");
            string test3 = "-(5,-(x,2))";
            Formula formula3 = new Formula(test3);
            Assert.AreEqual(formula3.RootFunction.ToString(), "(7-x)");
            string test4 = "-(5,-(2,x))";
            Formula formula4 = new Formula(test4);
            Assert.AreEqual(formula4.RootFunction.ToString(), "(3+x)");
            string test5 = "-(+(x,2),3)";
            Formula formula5 = new Formula(test5);
            Assert.AreEqual(formula5.RootFunction.ToString(), "(x+-1)");
            string test6 = "-(+(2,x),3)";
            Formula formula6 = new Formula(test6);
            Assert.AreEqual(formula6.RootFunction.ToString(), "(-1+x)");
            string test7 = "-(3,+(x,2))";
            Formula formula7 = new Formula(test7);
            Assert.AreEqual(formula7.RootFunction.ToString(), "(1-x)");
            string test8 = "-(3,+(2,x))";
            Formula formula8 = new Formula(test8);
            Assert.AreEqual(formula8.RootFunction.ToString(), "(1-x)");
        }
        [TestMethod]
        public void TestPlusSimplify()
        {
            string test1 = "+(+(x,2),3)";
            Formula formula1 = new Formula(test1);
            Assert.AreEqual(formula1.RootFunction.ToString(), "(x+5)");
            string test2 = "+(+(5,x),3)";
            Formula formula2 = new Formula(test2);
            Assert.AreEqual(formula2.RootFunction.ToString(), "(x+8)");
            string test3 = "+(5,+(x,2))";
            Formula formula3 = new Formula(test3);
            Assert.AreEqual(formula3.RootFunction.ToString(), "(x+7)");
            string test4 = "+(5,+(2,x))";
            Formula formula4 = new Formula(test4);
            Assert.AreEqual(formula4.RootFunction.ToString(), "(x+7)");
            string test5 = "+(-(x,2),3)";
            Formula formula5 = new Formula(test5);
            Assert.AreEqual(formula5.RootFunction.ToString(), "(x+1)");
            string test6 = "+(-(2,x),3)";
            Formula formula6 = new Formula(test6);
            Assert.AreEqual(formula6.RootFunction.ToString(), "(5-x)");
            string test7 = "+(3,-(x,2))";
            Formula formula7 = new Formula(test7);
            Assert.AreEqual(formula7.RootFunction.ToString(), "(x+1)");
            string test8 = "+(3,-(2,x))";
            Formula formula8 = new Formula(test8);
            Assert.AreEqual(formula8.RootFunction.ToString(), "(5-x)");
        }
        [TestMethod]
        public void TestMultiplySimplify()
        {
            string test1 = "*(*(x,2),3)";
            Formula formula1 = new Formula(test1);
            Assert.AreEqual(formula1.RootFunction.ToString(), "(6*x)");
            string test2 = "*(3,*(5,x))";
            Formula formula2 = new Formula(test2);
            Assert.AreEqual(formula2.RootFunction.ToString(), "(15*x)");
            string test3 = "*(5,*(x,2))";
            Formula formula3 = new Formula(test3);
            Assert.AreEqual(formula3.RootFunction.ToString(), "(10*x)");
            string test4 = "*(4,/(2,x))";
            Formula formula4 = new Formula(test4);
            Assert.AreEqual(formula4.RootFunction.ToString(), "(8/x)");
            string test5 = "*(/(x,2),4)";
            Formula formula5 = new Formula(test5);
            Assert.AreEqual(formula5.RootFunction.ToString(), "(x*2)");
            string test6 = "*(/(4,x),2)";
            Formula formula6 = new Formula(test6);
            Assert.AreEqual(formula6.RootFunction.ToString(), "(8/x)");
        }
        [TestMethod]
        public void TestDivideSimplify()
        {
            string test1 = "/(/(x,2),3)";
            Formula formula1 = new Formula(test1);
            Assert.AreEqual(formula1.RootFunction.ToString(), "(x/6)");
            string test2 = "/(/(6,x),3)";
            Formula formula2 = new Formula(test2);
            Assert.AreEqual(formula2.RootFunction.ToString(), "(2/x)");
            string test3 = "/(5,/(x,2))";
            Formula formula3 = new Formula(test3);
            Assert.AreEqual(formula3.RootFunction.ToString(), "(10/x)");
            string test4 = "/(4,/(2,x))";
            Formula formula4 = new Formula(test4);
            Assert.AreEqual(formula4.RootFunction.ToString(), "(2*x)");
            string test5 = "/(*(x,4),2)";
            Formula formula5 = new Formula(test5);
            Assert.AreEqual(formula5.RootFunction.ToString(), "(2*x)");
            string test6 = "/(*(6,x),2)";
            Formula formula6 = new Formula(test6);
            Assert.AreEqual(formula6.RootFunction.ToString(), "(3*x)");
            string test7 = "/(4,*(x,2))";
            Formula formula7 = new Formula(test7);
            Assert.AreEqual(formula7.RootFunction.ToString(), "(2/x)");
            string test8 = "/(4,*(2,x))";
            Formula formula8 = new Formula(test8);
            Assert.AreEqual(formula8.RootFunction.ToString(), "(2/x)");
        }
    }
}
