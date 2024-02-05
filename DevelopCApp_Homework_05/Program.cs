using DevelopCApp_Homework_05;

class Programm
{
    static void Main(string[] args)
    {
        var calc = new Calculator();
        calc.ValuesCalculated += Calc_ValuesCalculated;

        double num1 = 0;
        bool parsedNum1 = false;
        do
        {
            Console.WriteLine("Введите x");
            parsedNum1 = UtilitiesClass.MyTryParse(Console.ReadLine(), out num1);

            if (parsedNum1)
            {
                parsedNum1 = UtilitiesClass.MyTryValidate(num1);
            }
        }
        while (!parsedNum1);


        Console.WriteLine("Введите операцию из (+, -, x, /)");
        string? operation = Console.ReadLine();

        double num2 = 0;
        bool parsedNum2 = false;
        do
        {
            Console.WriteLine("Введите y");
            parsedNum2 = UtilitiesClass.MyTryParse(Console.ReadLine(), out num2);

            if (parsedNum2)
            {
                parsedNum2 = UtilitiesClass.MyTryValidate(num2);
            }
        }
        while (!parsedNum2);

        switch (operation)
        {
            case "+":
                calc.Sum(num1, num2);
                break;
            case "-":
                try
                {
                    calc.Sub(num1, num2);
                }
                catch (NegativeResultExeption e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                break;
            case "x":
                calc.Mult(num1, num2);
                break;
            case "/":
                try
                {
                    calc.Div(num1, num2);
                }
                catch (CalculatorExeption e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
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

            num2 = 0;
            parsedNum2 = false;
            do
            {
                Console.WriteLine("Введите y");
                parsedNum2 = UtilitiesClass.MyTryParse(Console.ReadLine(), out num2);

                if (parsedNum2)
                {
                    parsedNum2 = UtilitiesClass.MyTryValidate(num2);
                }
            }
            while (!parsedNum2);

            switch (operation)
            {
                case "+":
                    calc.Sum(num1, num2);
                    break;
                case "-":
                    try
                    {
                        calc.Sub(num1, num2);
                    }
                    catch (NegativeResultExeption e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                    break;
                case "x":
                    calc.Mult(num1, num2);
                    break;
                case "/":
                    try
                    {
                        calc.Div(num1, num2);
                    }
                    catch (CalculatorExeption e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
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

