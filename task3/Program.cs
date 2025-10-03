internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите числитель и знаменатель:");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        //В случае, если знаменатель дроби равен нулю, программа завершается
        if (n == 0) Environment.Exit(1);

        int nod = NOD(m, n);
        m = m / nod;
        n = n / nod;

        if (n < 1)
        {
            //Перемещаем минус влево 
            Console.WriteLine($"{-m}/{-n}");
        }
        else
        {
            Console.WriteLine($"{m}/{n}");
        }
    }

    /// <summary>
    /// Поиск наибольшего общего делителя
    /// </summary>
    /// <param name="m">Числитель дроби</param>
    /// <param name="n">Знаменатель дроби</param>
    /// <returns>Наибольший общий делитель</returns>
    public static int NOD(int m, int n)
    {
        //Для нахождения Наибольшего Общего Делителя используется алгоритм Евклида
        int nod = m;
        while (n % nod != 0)
        {
            nod = n % nod;
            n = m;
        }

        return nod;
    }
}