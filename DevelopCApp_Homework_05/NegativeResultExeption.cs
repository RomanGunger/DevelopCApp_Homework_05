using System;
namespace DevelopCApp_Homework_05
{
	public class NegativeResultExeption: Exception
	{
        public NegativeResultExeption()
        {
        }

        public NegativeResultExeption(string error) : base(error)
        {
		}
	}
}

