using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            // élements d'entrés
            int a = 1;
            int b = 2;
            int expected = 3;

            int mulexpected = 2;

            // instanciation de CalculatorEngine où se trouve les fonctions à tester
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Addition(a, b);


            //test sur la valeur de sortie
            Assert.AreEqual(expected, actual);


            //testons ce qui se passe
            var ffffff = 0;

        }

        [TestMethod]
        public void TestMethodSub()
        {
            // élements d'entrés
            int a = 1;
            int b = 2;
            int subexpected = -1;

            // instanciation de CalculatorEngine où se trouve les fonctions à tester
            CalculatorEngine engine = new CalculatorEngine();
            int actual2 = engine.Substraction(a, b);
            //test sur la valeur de sortie 
            Assert.AreEqual(subexpected, actual2);
            //

        }
        [TestMethod]
        public void TestMethodMul()
        {
            // élements d'entrés
            int a = 1;
            int b = 2;
            int mulexpected = 2;

            // instanciation de CalculatorEngine où se trouve les fonctions à tester
            CalculatorEngine engine = new CalculatorEngine();
            int actual3 = engine.Multiply(a, b);
            // test sur la valeur de sortie Multiplication
            Assert.AreEqual(mulexpected, actual3);


        }

        [TestMethod]
        public void TestMethodDiv()
        {
            // élements d'entrés
            double a = 1.0;
            double b = 2.0;
            double  divexpected = 0.5;

            // instanciation de CalculatorEngine où se trouve les fonctions à tester
            CalculatorEngine engine = new CalculatorEngine();
            double actual4 = engine.Division(a, b);
            // test sur la valeur de sortie Multiplication
            Assert.AreEqual(divexpected, actual4);


        }

        //[TestMethod]
        public void TestMethodDivByZero()
        {
            // élements d'entrés
            double a = 1.0;
            double b = 0.0;
            double divexpected2 =Convert.ToDouble(Int32.MinValue);

            // instanciation de CalculatorEngine où se trouve les fonctions à tester
            CalculatorEngine engine = new CalculatorEngine();
            double actual4 = engine.Division(a, b);
            // test sur la valeur de sortie Multiplication
            Assert.AreEqual(divexpected2, actual4);


        }
    }
}
