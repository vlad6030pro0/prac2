internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите номер билета: ");
        int num = int.Parse(Console.ReadLine());

        //Получаем первые 3 цифры
        int firstPart = num / 1000;
        //Получаем последние 3 цифры
        int secondPart = num % 1000;

        //При вводе условия в Console.WriteLine() будет выведено либо true, либо false
        Console.WriteLine((firstPart / 100 + firstPart / 10 % 10 + firstPart % 10) == (secondPart / 100 + secondPart / 10 % 10 + secondPart % 10));
    }
}