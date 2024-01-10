using System;
using System.Security.Cryptography.X509Certificates;

class Laba1
{
    static void Main()
    {
        Console.WriteLine("________Task 1________");
        Task1 obj = new Task1();
        Console.WriteLine($"Element a{obj.findNumber() + 1}");

        Console.WriteLine("________Task 2________");
        Task2 obj2 = new Task2();
        Console.WriteLine(obj2.findSentences());
    }
}

class Task1
{

    private int[] a = new int[5];

    public Task1()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"Enter a{i + 1} element: ");
            a[i] = int.Parse( Console.ReadLine() );
        }
    }

    public int findNumber()
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 10 == 7)
                return i;
        }

        return -1;
    }
}

class Task2
{

    private string text;

    public Task2()
    {
        Console.Write($"Enter a string: ");
        text = Console.ReadLine();
    }

    public int findSentences()
    {

        string[] sentences = this.text.Split('.');
        int count = 0;

        foreach (string s in sentences)
        {
            if (!string.IsNullOrWhiteSpace(s))
            count++;
        }

        return count;
    }
}