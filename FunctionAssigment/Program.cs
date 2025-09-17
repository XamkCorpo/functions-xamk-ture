using System;

class Program
{
    static void Main(string[] args)
    {
        // Selkeä, luettava "orkestrointi":
        string name = KysyNimi();
        int age = KysyIka();

        TulostaNimiJaIka(name, age);
        TarkistaTaysiIkainen(age);
        VertaaNimea(name, "Matti");
    }

    // 1) Nimen kysyminen + validointi
    static string KysyNimi()
    {
        while (true)
        {
            Console.Write("Enter your name: ");
            string? input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
                return input.Trim();

            Console.WriteLine("Name cannot be empty.");
        }
    }

    // 2) Iän kysyminen + validointi
    static int KysyIka()
    {
        while (true)
        {
            Console.Write("Enter your age: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int age) && age > 0)
                return age;

            Console.WriteLine("Please enter a positive integer.");
        }
    }

    // 3) Tulostus erillisenä vastuuna
    static void TulostaNimiJaIka(string name, int age)
    {
        Console.WriteLine($"Your name is {name} and your age is {age}.");
    }

    // 4) Täysi-ikäisyyden tarkistus
    static bool TarkistaTaysiIkainen(int age)
    {
        //Here we retun the result of comparison directly
        return age >= 18;
    }

    // 5) Nimen vertailu toiseen merkkijonoon
    static void VertaaNimea(string name, string compareTo)
    {
        // Case-insensitive (suositeltu: Equals + StringComparison)
        if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Your name matches '{compareTo}' (case-insensitive).");
        }

        // Case-sensitive tarkka vertailu
        if (name.Equals(compareTo))
        {
            Console.WriteLine($"Your name is exactly '{compareTo}' (case-sensitive).");
        }
    }
}
