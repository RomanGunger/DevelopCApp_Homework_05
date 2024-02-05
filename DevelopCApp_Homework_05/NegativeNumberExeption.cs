using System;
namespace DevelopCApp_Homework_05
{
	public class NegativeNumberExeption: CalculatorExeption
	{
		public NegativeNumberExeption()
		{
		}

        public NegativeNumberExeption(string error) : base(error)
        {

        }
    }
}

