using System;
namespace DevelopCApp_Homework_05
{
	public class HandleInput
	{
		public void Handle(List<string> list, Func<string, int> parser, Action<int> action)
		{
			foreach (var item in list)
			{
				int res = parser(item);
				action(res);
			}
		}
	}
}

