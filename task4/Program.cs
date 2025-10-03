internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Загадайте число от 1 до 63 включительно: ");
        int n = int.Parse(Console.ReadLine());

        int tryCount = 0;

        //Пороги генерации новый чисел
        int a = 1;
        int b = 64;

        //Список использованных программой чисел для избежания повторов
        List<int> usedNums = new List<int>();

        while (tryCount < 7)
        {
            //Генерация нового числа от a до b не включительно
            int rnd = new Random().Next(a, b);

            //Проверка на то использовалось ли это числа ранее
            while(usedNums.Contains(rnd))
            {
                rnd = new Random().Next(a, b);
            }

            //Проверка поражения игрока
            if(rnd == n)
            {
                Console.WriteLine($"Ваше число {rnd}! Вы проиграли!");
                Environment.Exit(0);
            }

            Console.WriteLine($"Ваше число больше {rnd}?(1 - да, 2 - нет)");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1) a = rnd;
            else b = rnd;

            tryCount++;
            usedNums.Add(rnd);
        }

        Console.WriteLine("Вы победили!");
    }
}