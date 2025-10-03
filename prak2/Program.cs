internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите номер n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите точность e (e < 0.01):");
        double e = double.Parse(Console.ReadLine());

        if (e >= 0.01)
        {
            Console.WriteLine("Точность не соответствует условию!");
            Environment.Exit(0);
        }

        //Вычисление суммы ряда
        double res = GetMaclorenSum(x, e);
        //Вычисление указанного члена ряда
        double maclorenNum = GetMaclorenNum(x, n);

        Console.WriteLine($"Значение ряда Маклорена для функции ch(x) при точности {e} и значении х {x} равно {res}");
        Console.WriteLine($"Значение члена ряда Маклорена для функции ch(x) при x {x} под номером {n} равно {maclorenNum}");
    }

    /// <summary>
    /// Вычисление факториала числа
    /// </summary>
    /// <param name="n">Введённое целое число</param>
    /// <returns>Факториал числа n</returns>
    public static double Factorial(int n)
    {
        if(n == 0)
        {
            return 1;
        }
        else
        {
            double res = 1;
            for(int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
    }

    /// <summary>
    /// Вычисление числа Маклорена для функции ch(x)
    /// </summary>
    /// <param name="x">Введённое число</param>
    /// <param name="n">Номер числа из ряда Маклорена</param>
    /// <returns>Число Маклорена с номером n</returns>
    public static double GetMaclorenNum(double x, int n)
    {
        return Math.Pow(x, 2*n) / Factorial(2 * n);
    }

    /// <summary>
    /// Вычисление суммы ряда Маклорена 
    /// </summary>
    /// <param name="x">Введённое число</param>
    /// <param name="e">Точность вычислений</param>
    /// <returns>Сумма ряда Маклорена</returns>
    public static double GetMaclorenSum(double x, double e)
    {
        double res = 1;
        int n = 1;
        double currentNum;

        do
        {
            currentNum = GetMaclorenNum(x, n);
            res += currentNum;
            n++;
        }
        while (Math.Abs(currentNum) > e);
        

        return res;
    }
}