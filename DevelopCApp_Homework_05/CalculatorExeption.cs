using System;
namespace DevelopCApp_Homework_05
{
	public class CalculatorExeption: Exception
	{
		public CalculatorExeption()
		{
		}

        public CalculatorExeption(string error) : base(error)
        {
        }
    }
}

