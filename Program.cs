using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the first string: ");
        string s1 = Convert.ToString(Console.ReadLine());
        Console.Write("Enter the second string: ");
        string s2 = Convert.ToString(Console.ReadLine());
        int num1 = 0;
        int num2 = 0;
        
        if (check(s) = false) { Console.WriteLine("the string are not equal "); }
        if (num1 != num2) Console.WriteLine("the string are not equal ");
        else Console.WriteLine("the strings are equal");
    }

    static void ex1()
    {
        string s = Convert.ToString(Console.ReadLine());
        Console.WriteLine(s);
    }
    static void ex2()
    {
        Console.Write("Enter a string: ");
        string s = Convert.ToString(Console.ReadLine());
        int num = 0;
        for (int i = 0; i < s.Length; i++)
            num++;
        Console.WriteLine($"The length of string is {num}");
    }
    static void ex31()
    {
        Console.Write("Enter a string: ");
        string s = Convert.ToString(Console.ReadLine());
        Console.Write($"The string after separate: ");
        foreach (char c in s)
        {
            Console.Write(c + " ");
        } 
    }
    static void ex32()
    {
        Console.Write("Enter a string: ");
        string s = Convert.ToString(Console.ReadLine());
        Console.Write($"The string after separate in reserve order: ");
        for (int i = 0; i < s.Length; i++)
        {
            Console.Write(s[i] + " ");
        }
    }
    static void ex4()
    {
        Console.Write("Enter a string: ");
        string s = Convert.ToString(Console.ReadLine());
        Console.Write($"The string after separate in reserve order: ");
        for (int i = s.Length -1; i >= 0; i--)
        {
            Console.Write(s[i] + " ");
        }
    }
    static void ex5()
    {
        Console.Write("Enter a string: ");
        string s = Convert.ToString(Console.ReadLine());
        s = s.Trim();
        int num = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ' && s[i + 1] != ' ') num = num + 1;
            if (s[i] == ' ' && s[i + 1] == ' ') num = num + 0;
            else num = num +0;
        }
        Console.Write($"The total number of words in a string: {num} ");
    }
    static bool check(string s )
    {
        return true;
    }


}
