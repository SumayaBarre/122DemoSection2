/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program
{
    static void Main()
    {
        // Part 1: Area of a Triangle
        Console.WriteLine("### Triangle Area Calculation ###");
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = (baseLength * height) / 2;
        Console.WriteLine($"The area of the triangle is: {area}\n");

        // Part 2: Clocktower Tick/Tock
        Console.WriteLine("### Clocktower Tick/Tock ###");
        Console.Write("Enter a number to check if it's Tick or Tock: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Tick");
        }
        else
        {
            Console.WriteLine("Tock");
        }
        Console.WriteLine();

        // Part 3: Watchtower Directions
        Console.WriteLine("### Watchtower Directions ###");
        Console.Write("Enter the x-coordinate of the enemy: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the y-coordinate of the enemy: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
            Console.WriteLine("The enemy is to the northeast!");
        else if (x < 0 && y > 0)
            Console.WriteLine("The enemy is to the northwest!");
        else if (x > 0 && y < 0)
            Console.WriteLine("The enemy is to the southeast!");
        else if (x < 0 && y < 0)
            Console.WriteLine("The enemy is to the southwest!");
        else if (x == 0 && y > 0)
            Console.WriteLine("The enemy is to the north!");
        else if (x == 0 && y < 0)
            Console.WriteLine("The enemy is to the south!");
        else if (x > 0 && y == 0)
            Console.WriteLine("The enemy is to the east!");
        else if (x < 0 && y == 0)
            Console.WriteLine("The enemy is to the west!");
        else
            Console.WriteLine("The enemy is here!\n");

        // Part 4: Outfitter Shop Prices
        Console.WriteLine("### Outfitter Shop Prices ###");
        Console.WriteLine("Available items:");
        Console.WriteLine("1 – Rope");
        Console.WriteLine("2 – Torches");
        Console.WriteLine("3 – Climbing Equipment");
        Console.WriteLine("4 – Clean Water");
        Console.WriteLine("5 – Machete");
        Console.WriteLine("6 – Canoe");
        Console.WriteLine("7 – Food Supplies");

        Console.Write("What number do you want to see the price of? ");
        int itemNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        double price = 0;
        string itemName = "";

        switch (itemNumber)
        {
            case 1: itemName = "Rope"; price = 10; break;
            case 2: itemName = "Torches"; price = 15; break;
            case 3: itemName = "Climbing Equipment"; price = 25; break;
            case 4: itemName = "Clean Water"; price = 1; break;
            case 5: itemName = "Machete"; price = 20; break;
            case 6: itemName = "Canoe"; price = 200; break;
            case 7: itemName = "Food Supplies"; price = 1; break;
            default: Console.WriteLine("Invalid selection."); return;
        }

        if (userName.ToLower() == "yourname") // Replace "yourname" with your actual name for the discount
        {
            price /= 2;  // Apply 50% discount
            Console.WriteLine($"As a special offer, {userName}, you get a 50% discount!");
        }

        Console.WriteLine($"{itemName} costs {price} gold.\n");

        // Part 5: Magic Cannon Crank (Fire, Electric, or both)
        Console.WriteLine("### Magic Cannon Crank ###");
        for (int turn = 1; turn <= 100; turn++)
        {
            if (turn % 3 == 0 && turn % 5 == 0)
                Console.WriteLine($"{turn}: Electric and Fire");
            else if (turn % 3 == 0)
                Console.WriteLine($"{turn}: Fire");
            else if (turn % 5 == 0)
                Console.WriteLine($"{turn}: Electric");
            else
                Console.WriteLine($"{turn}: Normal");
        }
        Console.WriteLine();

        // Part 6: Replicator of D'To (Replicate arrays)
        Console.WriteLine("### Replicator of D'To ###");
        int[] originalArray = new int[5];
        int[] replicatedArray = new int[5];

        Console.WriteLine("Please enter 5 numbers for the original array:");
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            originalArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < originalArray.Length; i++)
        {
            replicatedArray[i] = originalArray[i];
        }

        Console.WriteLine("\nOriginal Array:");
        foreach (var num in originalArray)
            Console.Write(num + " ");
        Console.WriteLine();

        Console.WriteLine("Replicated Array:");
        foreach (var num in replicatedArray)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}

