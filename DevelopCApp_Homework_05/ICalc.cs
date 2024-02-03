using System;
using static DevelopCApp_Homework_05.Calculator;

namespace DevelopCApp_Homework_05
{
    public interface ICalc
    {
        double Result { get; set; }
        Stack<double> Results { get; set; }

        void Sum(double x, double y);
        void Sub(double x, double y);
        void Mult(double x, double y);
        void Div(double x, double y);

        void CancelLast();

        event EventHandler<ValuesCalculatedEventArgs> ValuesCalculated;
    }
}

