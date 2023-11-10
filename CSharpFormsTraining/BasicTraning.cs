using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFormsTraining
{
    internal class BasicTraning
    {
        public double forloop1(double n)
        {
            double J=0;
            for (double i = 1; i <= n; i++)
            {
                J = i + J;

            }
            return J;
        }
    }
}
