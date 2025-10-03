internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Выберете количество воды в мл: ");
        int water = int.Parse(Console.ReadLine());
        Console.Write("Выберете количество молока в мл: ");
        int milk = int.Parse(Console.ReadLine());

        int latteCount = 0;
        int americCount = 0;

        while (true)
        {
            Console.Write("Какой напиток желаете заказать?(1 - латте, 2 - американо): ");
            int userMove = int.Parse(Console.ReadLine());

            // Расчёт затрат на латте
            if(userMove == 1)
            {
                if(water >= 270 && milk >= 30)
                {
                    Console.WriteLine("Ваш напиток готов!");
                    latteCount++;
                    water -= 270;
                    milk -= 30;
                }
                else
                {
                    if (water < 270)
                    {
                        Console.WriteLine("Закончилась вода.");
                    }
                    if (milk < 30)
                    {
                        Console.WriteLine("Закончилось молоко.");
                    }
                }
                
            }
            // Расчёт затрат на американо
            else if (userMove == 2)
            {
                if (water >= 300)
                {
                    Console.WriteLine("Ваш напиток готов!");
                    americCount++;
                    water -= 300;
                }
                else
                {
                    if (water < 300)
                    {
                        Console.WriteLine("Закончилась вода.");
                    }
                }

            }

            if(water < 270)
            {
                Console.WriteLine($"\t*Отчёт*\n\tИнгредиентов осталось:\n\t\tВода: {water} мл\n\t\tМолоко: {milk} мл\n\tКружек американо приготовлено: {americCount}" +
                    $"\n\tКружек латте приготовлено: {latteCount}\nИтого: {americCount*150+latteCount*170} рублей.");

                // Завершение работы программы в случае если воды не хватает ни на один напиток
                Environment.Exit(0);
            }
        }
    }
}