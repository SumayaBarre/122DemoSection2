/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System;

public class Program
{
    // 1. Enums and classes for the Manticore battle game
    public enum ArrowheadType { Steel = 10, Wood = 3, Obsidian = 5 }
    public enum FletchingType { Plastic = 10, TurkeyFeathers = 5, GooseFeathers = 3 }
    public enum SoupType { Soup, Stew, Gumbo }
    public enum IngredientType { Mushrooms, Chicken, Carrots, Potatoes }
    public enum SeasoningType { Spicy, Salty, Sweet }

    // 2. Arrow class
    public class Arrow
    {
        public ArrowheadType Arrowhead { get; set; }
        public FletchingType Fletching { get; set; }
        public double Length { get; set; } // in cm

        public Arrow(ArrowheadType arrowhead, FletchingType fletching, double length)
        {
            Arrowhead = arrowhead;
            Fletching = fletching;
            Length = length;
        }

        public double GetCost()
        {
            double shaftCost = 0.05 * Length;
            return (double)Arrowhead + (double)Fletching + shaftCost;
        }
    }

    // 3. Main method 
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Let's play the Manticore Battle Game!");
        int manticoreDistance = 32; // predefined, can be dynamic
        int cityHealth = 15;
        int manticoreHealth = 10;
        int round = 1;

        while (cityHealth > 0 && manticoreHealth > 0)
        {
            Console.Clear();
            Console.WriteLine($"STATUS: Round {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
            Console.WriteLine($"The cannon is expected to deal {(round % 3 == 0 && round % 5 == 0 ? 10 : (round % 3 == 0 || round % 5 == 0 ? 3 : 1))} damage this round.");
            Console.Write("Enter desired cannon range: ");
            int targetRange = int.Parse(Console.ReadLine());

            if (targetRange > manticoreDistance)
            {
                Console.WriteLine("That round OVERSHOT the target.");
            }
            else if (targetRange < manticoreDistance)
            {
                Console.WriteLine("That round FELL SHORT of the target.");
            }
            else
            {
                int damage = round % 3 == 0 && round % 5 == 0 ? 10 : (round % 3 == 0 || round % 5 == 0 ? 3 : 1);
                manticoreHealth -= damage;
                Console.WriteLine($"That round was a DIRECT HIT! The Manticore takes {damage} damage.");
            }

            if (manticoreHealth > 0) cityHealth -= 1; // city takes damage if Manticore survives
            round++;
        }

        if (manticoreHealth <= 0)
        {
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        }
        else
        {
            Console.WriteLine("The city of Consolas has been destroyed!");
        }

        // --- Simula’s Test: Chest Locking Mechanism ---
        Console.WriteLine("\nSimula's Chest Test:");
        Chest chest = new Chest();
        chest.Unlock();
        chest.Open();
        chest.Close();

        // --- Simula’s Soup ---
        Console.WriteLine("\nSimula's Soup:");
        Console.WriteLine("Pick a type of soup: 1. Soup 2. Stew 3. Gumbo");
        SoupType soupChoice = (SoupType)Enum.Parse(typeof(SoupType), Console.ReadLine());
        Console.WriteLine("Pick an ingredient: 1. Mushrooms 2. Chicken 3. Carrots 4. Potatoes");
        IngredientType ingredientChoice = (IngredientType)Enum.Parse(typeof(IngredientType), Console.ReadLine());
        Console.WriteLine("Pick a seasoning: 1. Spicy 2. Salty 3. Sweet");
        SeasoningType seasoningChoice = (SeasoningType)Enum.Parse(typeof(SeasoningType), Console.ReadLine());

        Console.WriteLine($"You made {seasoningChoice} {ingredientChoice} {soupChoice}!");

        // --- Vin Fletcher’s Arrows ---
        Console.WriteLine("\nVin Fletcher's Arrow Creation:");
        Console.WriteLine("Choose Arrowhead: 1. Steel 2. Wood 3. Obsidian");
        ArrowheadType arrowhead = (ArrowheadType)Enum.Parse(typeof(ArrowheadType), Console.ReadLine());
        Console.WriteLine("Choose Fletching: 1. Plastic 2. TurkeyFeathers 3. GooseFeathers");
        FletchingType fletching = (FletchingType)Enum.Parse(typeof(FletchingType), Console.ReadLine());
        Console.Write("Enter Shaft Length (60-100 cm): ");
        double shaftLength = double.Parse(Console.ReadLine());

        Arrow arrow = new Arrow(arrowhead, fletching, shaftLength);
        Console.WriteLine($"The cost of the arrow is {arrow.GetCost()} gold.");

        // --- Vin's Trouble: Private Fields and Getter Methods ---
        Console.WriteLine("\nVin's Trouble - Private Fields Example:");
        Arrow arrowWithPrivateFields = new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 75);
        Console.WriteLine($"Arrow - Head: {arrowWithPrivateFields.Arrowhead}, Fletching: {arrowWithPrivateFields.Fletching}, Length: {arrowWithPrivateFields.Length}cm");

        // --- The Properties of Arrows ---
        Console.WriteLine("\nThe Properties of Arrows:");
        arrowWithPrivateFields = new Arrow(ArrowheadType.Wood, FletchingType.TurkeyFeathers, 80);
        Console.WriteLine($"New Arrow - Head: {arrowWithPrivateFields.Arrowhead}, Fletching: {arrowWithPrivateFields.Fletching}, Length: {arrowWithPrivateFields.Length}cm");
    }
}

// Simula's Chest Mechanism
public class Chest
{
    private enum ChestState { Locked, Unlocked, Open }
    private ChestState _state = ChestState.Locked;

    public void Unlock()
    {
        if (_state == ChestState.Locked)
        {
            _state = ChestState.Unlocked;
            Console.WriteLine("The chest is now unlocked.");
        }
        else
        {
            Console.WriteLine("The chest is already unlocked or open.");
        }
    }

    public void Open()
    {
        if (_state == ChestState.Unlocked)
        {
            _state = ChestState.Open;
            Console.WriteLine("The chest is now open.");
        }
        else
        {
            Console.WriteLine("You cannot open the chest; it is either locked or already open.");
        }
    }

    public void Close()
    {
        if (_state == ChestState.Open)
        {
            _state = ChestState.Unlocked;
            Console.WriteLine("The chest is now closed.");
        }
        else
        {
            Console.WriteLine("The chest is already closed or locked.");
        }
    }
}

