namespace Task19
{}
    //Напишите программу, которая принимает на вход пятизначное число 
    //и проверяет, является ли оно палиндромом.
    //14212 -> нет
    //12821 -> да
    //23432 -> да
    class Program 
    {
        public static void Main(string[] args)
        {
        Console.Clear();
        Console.WriteLine ("Введите пятизначное число, попробуте еще раз");
        string? N = Console.ReadLine();
        int NLen = N.Length;
         if (NLen != 5)     
            {
             Console.WriteLine ("Это не пятизначное число");
            }
        else 
            {if (N[0] == N[4] & N[1] == N[3])
            {
            Console.WriteLine ("Это полиндром!");
            }
            else {
                 Console.WriteLine ("Это НЕ полиндром");
                 }
            }
        }
    }