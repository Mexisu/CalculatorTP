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
        /// Function to premieroperandeddition two value
        /// </summary>
        /// <param name="premieroperande"> 1st value.</param>
        /// <param name="bella"> 2nd value.</param>
        /// <returns>the premieroperandeddition value.</returns>
        public int Addition(int premieroperande, int bella)
        {
            // new comment from Xav
            // Colette ne contribue pas, comme d'habitude
            return premieroperande + bella;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="premieroperande"></param>
        /// <param name="bella"></param>
        /// <returns></returns>
        public int Substraction(int premieroperande, int bella)
        {
            return premieroperande - bella;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="premieroperande"></param>
        /// <param name="bella"></param>
        /// <returns></returns>
        public int Multiply(int premieroperande, int bella)
        {
            return premieroperande * bella;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="bella"></param>
        /// <returns></returns>
        public  double Division(double  premieroperande, double bella)
        {
            double res;
            if(bella > 0)
            {
                res = premieroperande/ bella;
            }
            else
            {
                res = Convert.ToDouble(System.Int32.MinValue);
            }
            return premieroperande/ bella;
        }

    }
}
