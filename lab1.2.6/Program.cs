using System;

public class Palindromy
{
    public static void Main(string[] args)
    {
        // Перебираємо всі числа від 1 до 100
        for (int i = 1; i <= 100; i++)
        {
            // Перевіряємо, чи є число паліндромом
            string s = i.ToString();
            if (s.Substring(0, s.Length / 2) == s.Substring(s.Length / 2, s.Length / 2))
            {
                // Якщо так, то виводимо його в консоль
                Console.WriteLine(i);
            }
        }
    }
}
