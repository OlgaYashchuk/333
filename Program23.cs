internal class Program
{
    private static void Main(string[] args)
    {
        //Напишите программу, которая принимает на вход число (N) 
        //и выдаёт таблицу кубов чисел от 1 до N.
        //3 -> 1, 8, 27
        //5 -> 1, 8, 27, 64, 125
          

         double Res()
            {    
            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());
            int i=1;
            double S= 1;
            
             while ( i <= N)
             {
                S=Math.Pow(i, 3);
                Console.Write(S + ", ");
                i++;
            }
            return S;

           }   
        try
        {
            Res();
        }
        catch
        {
            Console.Write("введите число"); 
        }
    }   
} 
    