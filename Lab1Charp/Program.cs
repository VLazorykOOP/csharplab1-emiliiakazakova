using System;

public class Program
{
    public static void Main()
    {
        // Uncomment the task you want to run
        
        // Task 1: Triangle Area Calculation
        // Task1();

        // Task 2: Sum of Digits Check
        // Task2();

        // Task 3: Point in Square Check
        // Task3();

        // Task 4: Doctor's Schedule
        // Task4();

        // Task 5: Square of Quotient
        // Task5();

        // Task 6: Expression Calculation
        // Task6();
    }

    // Task 1: Triangle Area Calculation
    static void Task1()
    {
        Console.WriteLine("Введіть координати вершин трикутника (x1, y1, x2, y2, x3, y3):");
        
        Console.Write("x1: ");
        float x1 = float.Parse(Console.ReadLine());
        Console.Write("y1: ");
        float y1 = float.Parse(Console.ReadLine());
        Console.Write("x2: ");
        float x2 = float.Parse(Console.ReadLine());
        Console.Write("y2: ");
        float y2 = float.Parse(Console.ReadLine());
        Console.Write("x3: ");
        float x3 = float.Parse(Console.ReadLine());
        Console.Write("y3: ");
        float y3 = float.Parse(Console.ReadLine());

        float area = CalculateTriangleArea(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Площа трикутника:" + area);
    }

    static float CalculateTriangleArea(float x1, float y1, float x2, float y2, float x3, float y3)
    {
        float side1 = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        float side2 = (float)Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        float side3 = (float)Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
        
        float semiperimeter = (side1 + side2 + side3) / 2;
        float area = (float)Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        
        return area;
    }

    // Task 2: Sum of Digits Check
    static void Task2()
    {
        Console.Write("Введіть двозначне число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Введіть число A: ");
        int A = int.Parse(Console.ReadLine());

        if (number < 10 || number > 99)
        {
            Console.WriteLine("Введене число не є двозначним.");
            return;
        }

        int sumOfDigits = (number / 10) + (number % 10);

        if (sumOfDigits % A == 0)
        {
            Console.WriteLine("Сума цифр числа " + number + " кратна числу " + A + ".");
        }
        else
        {
            Console.WriteLine("Сума цифр числа " + number + " не кратна числу " + A + ".");
        }
    }

    // Task 3: Point in Square Check
    static void Task3()
    {
        Console.WriteLine("Введіть координати точки (x, y):");
        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());

        bool insideSquare = (x >= -40 && x <= 40) && (y >= -40 && y <= 40);
        bool onBoundary = (x == -40 || x == 40 || y == -40 || y == 40);

        if (insideSquare)
        {
            if (onBoundary)
            {
                Console.WriteLine("На межі");
            }
            else
            {
                Console.WriteLine("Ні");
            }
        }
        else
        {
            Console.WriteLine("Так");
        }
    }

    // Task 4: Doctor's Schedule
    static void Task4()
    {
        Dictionary<string, List<string>> schedule = new Dictionary<string, List<string>>();

        schedule.Add("Понеділок", new List<string> { "10:00", "13:00", "16:00" });
        schedule.Add("Вівторок", new List<string> { "11:00", "14:00", "17:00" });
        schedule.Add("Середа", new List<string> { "12:00", "15:00", "18:00" });
        schedule.Add("Четвер", new List<string> { "9:00", "12:30", "15:30" });
        schedule.Add("П'ятниця", new List<string> { "8:30", "11:30", "14:30" });

        Console.WriteLine("Введіть день тижня (Понеділок, Вівторок, ...):");
        string day = Console.ReadLine();

        if (schedule.ContainsKey(day))
        {
            Console.WriteLine("Приймальні години лікаря у " + day);
            foreach (string hour in schedule[day])
            {
                Console.WriteLine(hour);
            }
        }
        else
        {
            Console.WriteLine("Немає інформації про приймальні години у введеному дні.");
        }
    }

    // Task 5: Square of Quotient
    static void Task5()
    {
        Console.WriteLine("Введіть ділене:");
        int dividend = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть дільник:");
        int divisor = int.Parse(Console.ReadLine());

        try
        {
            int result = SquareOfQuotient(dividend, divisor);
            Console.WriteLine("Квадрат частки " + dividend + " на " + divisor + " дорівнює " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static int SquareOfQuotient(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("Ділення на нуль неможливе.");
        }

        int quotient = dividend / divisor;
        int square = quotient * quotient;

        return square;
    }

    // Task 6: Expression Calculation
    static void Task6()
    {
        Console.WriteLine("Введіть значення m:");
        float m = float.Parse(Console.ReadLine());

        Console.WriteLine("Введіть значення n:");
        float n = float.Parse(Console.ReadLine());

        float result = (m - n) * ((n + 1) / (n + m + 1)) - n * n + 5;
        Console.WriteLine("Результат виразу: " + result);
    }
}
