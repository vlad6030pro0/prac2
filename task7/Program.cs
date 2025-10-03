internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите w: ");
        int w = int.Parse(Console.ReadLine());
        Console.Write("Введите h: ");
        int h = int.Parse(Console.ReadLine());

        int d = 0;
        int sumH;
        int sumW;
        int nInWidth = (int)n;
        int nInHeight = (int)Math.Ceiling(n/nInWidth);
        do
        {
            d++;

            sumH = nInHeight * (b + 2 * d);
            sumW = nInWidth * (a + 2 * d);

            int p = 0;

            while (w < sumW)
            {
                nInWidth--;
                sumW = nInWidth * (a + 2 * d);
                sumH = nInHeight * (b + 2 * d);
            }

            Console.WriteLine($"d = {d}. Суммарная ширина равна {sumW}, а суммарная высота равна {sumH}. " +
                $"Получилось поле размером {nInWidth}x{nInHeight} модулей (суммарно {nInWidth + nInHeight} модулей)");
            //if(((nInHeight * (b + 2 * (d+1)) * (nInWidth * (a + 2 * (d+1))))) > (w * h))
            //{
            //    Console.WriteLine("При следующей итерации сумма площадей модулей будет большей площади площадки.");
            //    Environment.Exit(0);
            //}

            int q = 0;
        }
        while ((w * h) > (sumW * sumH));
    }
}