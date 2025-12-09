using System;
class Numbers
{
    
    int Number1 = 0;
    int Number2 = 5;
    int Count = 0;
    public void Rng()
    {
        Random rng = new Random();
        Number1 = rng.Next(1,11);
        Number2 = rng.Next(1,11);
    }
    public void Run()
    {
        Rng();
        Console.WriteLine("Skriv >,<, eller =");
        Console.WriteLine($"{Number1}_{Number2}");
        var input = Console.ReadLine();
        if (Count >= 9) 
        { 
            Console.Write("Du vant"); 
        }
        else if (input == "<" && Number1 < Number2)
        {
            Count++;
            Console.WriteLine($"Det var riktig. Du har nå {Count} poeng");
            Run();
        }
        else if (input == ">" && Number1 > Number2)
        {
            Count++;
            Console.WriteLine($"Det var riktig. Du har nå {Count} poeng");
            Run();
        }
        else if (input == "=" && Number1 == Number2)
        {
            Count++;
            Console.WriteLine($"Det var riktig. Du har nå {Count} poeng");
            Run();
        }
        else
        {
            Count = 0;
            Console.WriteLine("Det var feil. Prøv igjen");
            Run();
        }
    }

    class Program
    {
        static void Main()
        {
            Numbers yo = new Numbers();
            yo.Run();
        }
    }
}