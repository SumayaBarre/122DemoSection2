/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
 
using System;

//  1. Vehicles 
class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; }

    public Car(string make, string model, int year, int numberOfDoors) 
        : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override string ToString()
    {
        return base.ToString() + $" with {NumberOfDoors} doors";
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; }

    public Motorcycle(string make, string model, int year, bool hasSidecar) 
        : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }

    public override string ToString()
    {
        return base.ToString() + $" (Has Sidecar: {HasSidecar})";
    }
}

//  2. Employees 
class Employee
{
    public string Name { get; }
    public double Salary { get; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Employee: {Name}, Salary: ${Salary}";
    }
}

class Manager : Employee
{
    public int NumberOfEmployeesManaged { get; }

    public Manager(string name, double salary, int numberOfEmployeesManaged)
        : base(name, salary)
    {
        NumberOfEmployeesManaged = numberOfEmployeesManaged;
    }

    public override string ToString()
    {
        return base.ToString() + $", Manages {NumberOfEmployeesManaged} employees";
    }
}

class Engineer : Employee
{
    public string Specialization { get; }

    public Engineer(string name, double salary, string specialization)
        : base(name, salary)
    {
        Specialization = specialization;
    }

    public override string ToString()
    {
        return base.ToString() + $", Specialization: {Specialization}";
    }
}

// 3. Shapes 
abstract class Shape
{
    public string Color { get; }

    public Shape(string color)
    {
        Color = color;
    }

    public abstract double GetArea();

    public override string ToString()
    {
        return $"{Color} Shape";
    }
}

class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(string color, double width, double height)
        : base(color)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Width: {Width}, Height: {Height}, Area: {GetArea()}";
    }
}

class Circle : Shape
{
    public double Radius { get; }

    public Circle(string color, double radius)
        : base(color)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Radius: {Radius}, Area: {GetArea():F2}";
    }
}

// 4. Animals and Sounds 
class Animal
{
    public string Name { get; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }

    public override string ToString()
    {
        return $"Animal: {Name}, Sound: {MakeSound()}";
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override string MakeSound()
    {
        return "Bark";
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override string MakeSound()
    {
        return "Meow";
    }
}

//  5. Library System
class Book
{
    public string Title { get; }
    public string Author { get; }
    public int YearPublished { get; }

    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    public override string ToString()
    {
        return $"{Title} by {Author} ({YearPublished})";
    }
}

class EBook : Book
{
    public double FileSizeMB { get; }

    public EBook(string title, string author, int yearPublished, double fileSizeMB)
        : base(title, author, yearPublished)
    {
        FileSizeMB = fileSizeMB;
    }

    public override string ToString()
    {
        return base.ToString() + $" [E-Book, {FileSizeMB}MB]";
    }
}

class PrintedBook : Book
{
    public int PageCount { get; }

    public PrintedBook(string title, string author, int yearPublished, int pageCount)
        : base(title, author, yearPublished)
    {
        PageCount = pageCount;
    }

    public override string ToString()
    {
        return base.ToString() + $" [Printed Book, {PageCount} pages]";
    }
}

//  Main program
class Program
{
    static void Main()
    {
        // Vehicles and Cars
        Vehicle myCar = new Car("Toyota", "Camry", 2020, 4);
        Vehicle myMotorcycle = new Motorcycle("Harley", "Sportster", 2019, true);
        Console.WriteLine(myCar);
        Console.WriteLine(myMotorcycle);

        // Employees and Specializations
        Employee manager = new Manager("Alice", 75000, 10);
        Employee engineer = new Engineer("Bob", 90000, "Software Engineering");
        Console.WriteLine(manager);
        Console.WriteLine(engineer);

        // Shapes and Areas
        Shape rectangle = new Rectangle("Red", 5.0, 10.0);
        Shape circle = new Circle("Blue", 7.0);
        Console.WriteLine(rectangle);
        Console.WriteLine(circle);

        // Animals and Sounds
        Animal dog = new Dog("Buddy");
        Animal cat = new Cat("Whiskers");
        Console.WriteLine(dog);
        Console.WriteLine(cat);

        // Library System
        Book ebook = new EBook("C# Mastery", "John Doe", 2023, 5.2);
        Book printedBook = new PrintedBook("The Art of Coding", "Jane Smith", 2021, 350);
        Console.WriteLine(ebook);
        Console.WriteLine(printedBook);
    }
}
