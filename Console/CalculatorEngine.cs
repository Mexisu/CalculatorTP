using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class CalculatorEngine
    {
        // coco est la plus douce
        //string coco = "coco est la plus douce";

        /// <summary>
        /// Function to Addition two value
        /// </summary>
        /// <param name="a"> 1st value.</param>
        /// <param name="b"> 2nd value.</param>
        /// <returns>the addition value.</returns>
        public int Addition(int a, int b)
        {
            // new comment from Xav
            // Colette ne contribue pas, comme d'habitude
            return a + b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Substraction(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Multiply(int a, int b)
        {
            return a *b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Division(double  a, double b)
        {
            double res;
            if(b > 0)
            {
                res = a/b;
            }
            else
            {
                res = Convert.ToDouble(System.Int32.MinValue);
            }
            return a/b;
        }

    }
}
