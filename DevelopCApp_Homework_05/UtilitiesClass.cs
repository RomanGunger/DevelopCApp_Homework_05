using System;
namespace DevelopCApp_Homework_05
{
	static class UtilitiesClass
	{
        public static bool MyTryParse(string num, out double result)
        {
            result = 0;

            try
            {
                result = Convert.ToDouble(num);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public static bool MyTryValidate(double num)
        {
            try
            {
                ValidateNumber(num);
            }
            catch(NegativeNumberExeption e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        static void ValidateNumber(double num)
        {
            if (num < 0)
                throw new NegativeNumberExeption("Введенное число не должно быть отрицательным");
        }
    }
}

