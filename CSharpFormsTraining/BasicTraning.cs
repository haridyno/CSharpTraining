using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFormsTraining
{
    internal static class BasicTraning
    {
        public static double ForLoop1(double n)
        {
            double J=0;
            for (int i = 1; i <= n; i++)
            {
                J = i + J;

            }
            return J;
        }
        public static double DoWhile1(double n)
        { 
            double J=0;
            int i = 1;
            do 
            {
                J = J + i;
                i++;
            }
            while( i <= n);
            return J;
        }
        public static double While1(double n)
        {
            double J = 0;
            int i = 1;
            while(i <= n)
            {
                J = J + i;
                i++;
            }      
            return J;
        }
    }
}
