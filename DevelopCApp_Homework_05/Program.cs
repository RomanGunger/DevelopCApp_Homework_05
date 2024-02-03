using DevelopCApp_Homework_05;

class Programm
{
    static void Main(string[] args)
    {
        var calc = new Calculator();
        calc.ValuesCalculated += Calc_ValuesCalculated;

        Console.WriteLine("Введите x");
        double num1 = 0;
        double.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Введите операцию из (+, -, x, /)");
        string? operation = Console.ReadLine();

        Console.WriteLine("Введите y");
        double num2 = 0;
        double.TryParse(Console.ReadLine(), out num2);

        switch (operation)
        {
            case "+":
                calc.Sum(num1, num2);
                break;
            case "-":
                calc.Sub(num1, num2);
                break;
            case "x":
                calc.Mult(num1, num2);
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка, деление на 0");
                    return;
                }
                else
                    calc.Div(num1, num2);
                break;
            default:
                Console.WriteLine("Вы ввели неверный знак операции");
                break;
        }

        while (true)
        {
            Console.WriteLine($"x = {calc.Result:F2}");
            num1 = calc.Result;

            Console.WriteLine("Введите операцию из (+, -, x, /)");
            operation = Console.ReadLine();

            Console.WriteLine("Введите y");
            num2 = 0;
            double.TryParse(Console.ReadLine(), out num2);

            switch (operation)
            {
                case "+":
                    calc.Sum(num1, num2);
                    break;
                case "-":
                    calc.Sub(num1, num2);
                    break;
                case "x":
                    calc.Mult(num1, num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка, деление на 0");
                        return;
                    }
                    else
                        calc.Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Вы ввели неверный знак операции");
                    break;
            }

            Console.WriteLine("Введите exit если хотите выйти, или нажмите enter");
            string input = Console.ReadLine();
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }

        #region Lesson
        //delegate void myDelegate(string message);
        //var inputHandler = new HandleInput();
        //inputHandler.Handle(list, int.Parse, (x) => Console.WriteLine(x));

        //AgeHandler.IsAdult(new List<string> { "18", "30", "14" }, int.Parse, (x) => x >= 18, (x) => Console.WriteLine($"Совершеннолетний {x}"));
        #endregion
    }

    private static void Calc_ValuesCalculated(object? sender, Calculator.ValuesCalculatedEventArgs e)
    {
        Console.WriteLine($"Result: {e.ResultValue:F3}");
    }


    #region Lesson
    //var list = new List<Action>();

    //list.Add(new Action(() => { Console.WriteLine("dddd"); }));
    //list.Add(new Action(() => { Console.WriteLine("1fdf1"); }));

    //DoAction(list);

    //var list = new List<myDelegate>()
    //{
    //    (message) => Console.WriteLine($"del 1 {message}"),
    //    (message) => Console.WriteLine($"del 1 {message}"),
    //};

    //static void DoAction(List<myDelegate> list)
    //{
    //    foreach (var item in list)
    //        item(" ");
    //}
    #endregion
}

