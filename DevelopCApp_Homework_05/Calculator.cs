using System;

namespace DevelopCApp_Homework_05
{
    public class Calculator : ICalc
    {
        public double Result { get; set; } = 0;
        public Stack<double> Results { get; set; } = new Stack<double>();

        public event EventHandler<ValuesCalculatedEventArgs>? ValuesCalculated;

        public class ValuesCalculatedEventArgs : EventArgs
        {
            public double ResultValue { get; set; }
        }

        public void Div(double x, double y)
        {
            ValuesCalculatedEventArgs eventArgs = new ValuesCalculatedEventArgs();

            if (y != 0)
                eventArgs.ResultValue = Result = x / y;
            else
                throw new CalculatorExeption("Ошибка деления на 0");

            Results.Push(Result);

            OnValuesCalculated(eventArgs);
        }

        public void Mult(double x, double y)
        {
            ValuesCalculatedEventArgs eventArgs = new ValuesCalculatedEventArgs();
            eventArgs.ResultValue = Result = x * y;
            Results.Push(Result);

            OnValuesCalculated(eventArgs);
        }

        public void Sub(double x, double y)
        {
            ValuesCalculatedEventArgs eventArgs = new ValuesCalculatedEventArgs();

            double res = x - y;

            if (res < 0)
                throw new NegativeResultExeption("Результат не может быть отрицательным числом");

            eventArgs.ResultValue = Result = res;

            Results.Push(Result);

            OnValuesCalculated(eventArgs);
        }

        public void Sum(double x, double y)
        {
            ValuesCalculatedEventArgs eventArgs = new ValuesCalculatedEventArgs();
            eventArgs.ResultValue = Result = x + y;
            Results.Push(Result);

            OnValuesCalculated(eventArgs);
        }

        public void CancelLast()
        {
            if (Results.TryPop(out double result))
            {
                if (Results.TryPeek(out double Result))
                {
                    Console.WriteLine($"Действие отменено, Result: {Result:F3}");
                }
                else
                {
                    Result = 0;
                    Console.WriteLine($"Действие отменено, Result: {Result}");
                }
            }
            else
                Console.WriteLine($"Невозможно отменить действие, Result: {Result}");
        }

        void OnValuesCalculated(ValuesCalculatedEventArgs eventArgs)
        {
            EventHandler<ValuesCalculatedEventArgs>? handler = ValuesCalculated;

            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }
    }
}

