using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public interface IQuadraticEquationService
    {
         double GetEquadraticEquationAdd(double A, double B, double C);
         double GetEquadraticEquationSubtract(double A, double B, double C);
    }
}
