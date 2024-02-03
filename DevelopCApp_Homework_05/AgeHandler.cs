using System;
namespace DevelopCApp_Homework_05
{
	public static class AgeHandler
	{
		public static void IsAdult(List<string> ages, Func<string, int> parser, Predicate<int> isAdultResult, Action<int> print)
		{
			foreach (var age in ages)
			{
				int res = parser(age);
				if (isAdultResult(res))
					print(res);
			}
		}
	}
}

