//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите пятизначное число   ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 100000 / 10000 == x % 10 / 1 && x % 10000 / 1000 == x % 100 / 10)
            {
                Console.Write("да");
            }

            else
            {
                Console.WriteLine("нет");
            }
        }
        catch
        {
            Console.WriteLine("введите пятизнаячное число");
        }
    }
}