using System;
class Numbers
{
    
    int Number1 = 0;
    int Number2 = 5;
    int Count = 0;
    Random rng = new Random();
    public void Rng()
    {
        Number1 = rng.Next(1,11);
        Number2 = rng.Next(1,11);
    }
    public void Run()
    {
        while (true)
        {

            Rng();
            Console.WriteLine("Skriv >,<, eller =");
            Console.WriteLine($"{Number1} _ {Number2}");

            var input = Console.ReadLine();

            bool correct = input switch
            {
                "<" => Number1 < Number2,
                ">" => Number1 > Number2,
                "=" => Number1 == Number2,
                _ => false
            };
            if (correct)
            {
                Count++;
                Console.WriteLine($"Det var riktig. Du har nå {Count} poeng");
            }
            else
            {
                Count = 0;
                Console.WriteLine("Det var feil. Prøv igjen");
            }
            if (Count >= 10)
            {
                Console.Write("Du vant");
                break;
            }
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