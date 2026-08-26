using System;

public class  pokemonDetails
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Pokemon: ");
        string name = Console.ReadLine();

        //(Fire, Water, Ground, Rock, Grass etc.)
        Console.Write("Pokemon Type: ");
        string Type = Console.ReadLine();

        Console.Write("Combat Power: ");
        int power = int.Parse(Console.ReadLine());

        Console.Write("Health Points: ");
        double health = double.Parse(Console.ReadLine());

        Console.Write("Can This Pokemon Evolve (true/false): ");
        bool evolve = bool.Parse(Console.ReadLine());

        Console.WriteLine("\n___________Pokemon Details____________ ");
        Console.WriteLine("Pokemon Name: " + name);
        Console.WriteLine("Pokemon Type: " + Type);
        Console.WriteLine("Combat Power: " + power);
        Console.WriteLine("Health Points: " + health);
        Console.WriteLine("Can This Pokemon Evolve: " + evolve);
    }
}