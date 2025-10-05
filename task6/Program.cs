internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество бактерий: ");
        int bacterias = int.Parse(Console.ReadLine());
        Console.Write("Введите количество антибиотика: ");
        int antibiotics = int.Parse(Console.ReadLine());

        int antibStrong = 10;
        int hours = 0;

        while(antibStrong > 0 && bacterias > 0)
        {
            bacterias *= 2;
            bacterias -= antibiotics*antibStrong;
            antibStrong--;

            hours++;
            if (bacterias < 0) bacterias = 0;
            Console.WriteLine($"После {hours} часа бактерий осталось {bacterias}");
        }
    }
}