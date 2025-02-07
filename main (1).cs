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
            // Triangle Area Calculation
            Console.WriteLine("=== Triangle Area Calculator ===");

            Console.Write("Enter the base of the triangle: ");

            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");

            double height = Convert.ToDouble(Console.ReadLine());

            double area = (baseLength * height) / 2;

            Console.WriteLine($"The area of the triangle is: {area}\n");

            // Chocolate Egg Division
            Console.WriteLine("=== Chocolate Egg Division ===");
            Console.Write("Enter the number of chocolate eggs collected today: ");
            int totalEggs = int.Parse(Console.ReadLine());
            int sisters = 4;
            int eggsPerSister = totalEggs / sisters;
            int leftoverEggs = totalEggs % sisters;
            Console.WriteLine($"Each sister gets {eggsPerSister} eggs.");
            Console.WriteLine($"The duckbear gets {leftoverEggs} eggs.\n");

            // Kingdom Points Calculator
            Console.WriteLine("=== Kingdom Points Calculator ===");
            Console.WriteLine("King Melik, enter the number of provinces, duchies, and estates you have:");
            Console.Write("Provinces: ");
            int melikProvinces = int.Parse(Console.ReadLine());
            Console.Write("Duchies: ");
            int melikDuchies = int.Parse(Console.ReadLine());
            Console.Write("Estates: ");
            int melikEstates = int.Parse(Console.ReadLine());

            Console.WriteLine("\nKing Casik, enter the number of provinces, duchies, and estates you have:");
            Console.Write("Provinces: ");
            int casikProvinces = int.Parse(Console.ReadLine());
            Console.Write("Duchies: ");
            int casikDuchies = int.Parse(Console.ReadLine());
            Console.Write("Estates: ");
            int casikEstates = int.Parse(Console.ReadLine());

            Console.WriteLine("\nKing Balik, enter the number of provinces, duchies, and estates you have:");
            Console.Write("Provinces: ");
            int balikProvinces = int.Parse(Console.ReadLine());
            Console.Write("Duchies: ");
            int balikDuchies = int.Parse(Console.ReadLine());
            Console.Write("Estates: ");
            int balikEstates = int.Parse(Console.ReadLine());

            // Calculate total points for each king
            int melikPoints = (melikProvinces * 6) + (melikDuchies * 3) + (melikEstates * 1);
            int casikPoints = (casikProvinces * 6) + (casikDuchies * 3) + (casikEstates * 1);
            int balikPoints = (balikProvinces * 6) + (balikDuchies * 3) + (balikEstates * 1);

            // Display total points
            Console.WriteLine($"\nKing Melik's total points: {melikPoints}");
            Console.WriteLine($"King Casik's total points: {casikPoints}");
            Console.WriteLine($"King Balik's total points: {balikPoints}");

            if (melikPoints > casikPoints && melikPoints > balikPoints)
            {
                Console.WriteLine("\nKing Melik has the greatest kingdom!");
            }
            else if (casikPoints > melikPoints && casikPoints > balikPoints)
            {
                Console.WriteLine("\nKing Casik has the greatest kingdom!");
            }
            else if (balikPoints > melikPoints && balikPoints > casikPoints)
            {
                Console.WriteLine("\nKing Balik has the greatest kingdom!");
            }
            else
            {
                Console.WriteLine("\nIt's a tie! Two or more kings have equal points.");
            }
            Console.WriteLine();

            // Defense of Consolas
            Console.Title = "Defense of Consolas";
            Console.WriteLine("=== Defense of Consolas ===");
            Console.Write("Target Row? ");
            int targetRow = int.Parse(Console.ReadLine());
            Console.Write("Target Column? ");
            int targetColumn = int.Parse(Console.ReadLine());

            // Calculate deployment locations
            int topRow = targetRow - 1;
            int bottomRow = targetRow + 1;
            int leftColumn = targetColumn - 1;
            int rightColumn = targetColumn + 1;

            // Set text color for deployment instructions
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Display deployment instructions
            Console.WriteLine("\nDeploy to:");
            Console.WriteLine($"({topRow}, {targetColumn})");  // Above
            Console.WriteLine($"({targetRow}, {leftColumn})");  // Left
            Console.WriteLine($"({targetRow}, {rightColumn})"); // Right
            Console.WriteLine($"({bottomRow}, {targetColumn})"); // Below

            // Play a sound
            Console.Beep();

            // Reset text color back to default
            Console.ResetColor();
            Console.WriteLine();

            // Clocktower Pendulum
            Console.WriteLine("=== Clocktower Pendulum ===");
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The pendulum ticks to the left.");
            }
            else
            {
                Console.WriteLine("The pendulum tocks to the right.");
            }
        }
    }

