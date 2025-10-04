internal class Program
{
    private static void Main(string[] args)
    {
        //Первоначальный ввод данных
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

        // d - ширина защитного поля, maxD - максимальное подходящее значение d, canPlace - проверка на возможность размещения модулей с заданным значением d
        int d = 0;
        int maxD = -1;
        bool canPlace;

        while (true)
        {
            canPlace = false;

            //Перебор вариантов размещения модулей(обычный и повёрнутый)
            for (int variant = 0; variant < 2; variant++)
            {
                int varA = a;
                int varB = b;
                if (variant == 1)
                {
                    varA = b;
                    varB = a;
                }
                //Перебор количества модулей для размещения в ширину 
                for (int nInWidth = (int)n; nInWidth > 0; nInWidth--)
                {
                    int nInHeight = (int)Math.Ceiling(n / nInWidth);
                    int sumW = (varA + 2 * d) * nInWidth;
                    int sumH = (varB + 2 * d) * nInHeight;
                    //Если условие выполняется это значит что модули расставлены верно и не выходят за границы поля
                    if (sumW <= w && sumH <= h)
                    {
                        maxD = d;
                        canPlace = true;
                        Console.WriteLine($"{nInWidth}x{nInHeight} при d = {d} и варианте {variant}");
                    }
                }
            }

            //Проверка на возможность размещения защитного поля в целом
            if (canPlace == false && maxD == -1)
            {
                Console.WriteLine("Размещение модулей невозможно даже без защитного поля.");
                Environment.Exit(0);
            }
            else if(canPlace == false && maxD != -1)
            {
                Console.WriteLine($"Максимально возможная ширина защитного поля d = {maxD}.");
                Environment.Exit(0);
            }

            d++;
        }
    }
}