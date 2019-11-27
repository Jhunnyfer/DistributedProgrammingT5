using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public class QuadraticEquationService:IQuadraticEquationService
    {
        public double GetEquadraticEquationAdd(double A, double B, double C)
        {
            return (-B+Math.Sqrt(Math.Pow(B,2) - (4*A*C)))/2*A ;
        }

        public double GetEquadraticEquationSubtract(double A, double B, double C)
        {
            return (-B - Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / 2 * A;
        }
    }
}
