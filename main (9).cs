/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/using System;
using System.Collections.Generic;

public class Solution
{
    // 1. Valid Parentheses
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                    return false;
            }
        }
        return stack.Count == 0;
    }

    // 2. Baseball Game Scoring
    public int CalPoints(string[] ops)
    {
        Stack<int> stack = new Stack<int>();
        foreach (var op in ops)
        {
            if (int.TryParse(op, out int num))
                stack.Push(num);
            else if (op == "+")
            {
                int top = stack.Pop();
                int second = stack.Peek();
                int sum = top + second;
                stack.Push(top);
                stack.Push(sum);
            }
            else if (op == "D")
                stack.Push(2 * stack.Peek());
            else if (op == "C")
                stack.Pop();
        }
        int total = 0;
        foreach (int score in stack)
            total += score;
        return total;
    }

    // 3. Pivot Index
    public int PivotIndex(int[] nums)
    {
        int total = 0, leftSum = 0;
        foreach (int num in nums)
            total += num;

        for (int i = 0; i < nums.Length; i++)
        {
            if (2 * leftSum + nums[i] == total)
                return i;
            leftSum += nums[i];
        }
        return -1;
    }

    // 4. RecentCounter class
    public class RecentCounter
    {
        private Queue<int> queue;
        public RecentCounter() => queue = new Queue<int>();
        public int Ping(int t)
        {
            queue.Enqueue(t);
            while (queue.Peek() < t - 3000)
                queue.Dequeue();
            return queue.Count;
        }
    }

    // 5. Sandwich Problem
    public int CountStudents(int[] students, int[] sandwiches)
    {
        Queue<int> queue = new Queue<int>(students);
        int index = 0;
        int count = 0;

        while (queue.Count > 0 && count < queue.Count)
        {
            if (queue.Peek() == sandwiches[index])
            {
                queue.Dequeue();
                index++;
                count = 0;
            }
            else
            {
                queue.Enqueue(queue.Dequeue());
                count++;
            }
        }
        return queue.Count;
    }
}

class Program
{
    static void Main()
    {
        var sol = new Solution();

        // 1. Valid Parentheses
        string parentheses = "()";
        Console.WriteLine("1. Valid Parentheses:");
        Console.WriteLine($"Input: \"{parentheses}\" => Output: {sol.IsValid(parentheses)}\n");

        // 2. Baseball Scoring
        string[] ops = { "5", "2", "C", "D", "+" };
        Console.WriteLine("2. Baseball Game Scoring:");
        Console.WriteLine($"Input: [\"5\", \"2\", \"C\", \"D\", \"+\"] => Output: {sol.CalPoints(ops)}\n");

        // 3. Pivot Index
        int[] nums = { 1, 7, 3, 6, 5, 6 };
        Console.WriteLine("3. Pivot Index:");
        Console.WriteLine($"Input: [1, 7, 3, 6, 5, 6] => Output: {sol.PivotIndex(nums)}\n");

        // 4. Recent Counter
        Console.WriteLine("4. Recent Counter:");
        var counter = new Solution.RecentCounter();
        Console.WriteLine($"Ping(1) => {counter.Ping(1)}");
        Console.WriteLine($"Ping(100) => {counter.Ping(100)}");
        Console.WriteLine($"Ping(3001) => {counter.Ping(3001)}");
        Console.WriteLine($"Ping(3002) => {counter.Ping(3002)}\n");

        // 5. Cafeteria Sandwiches
        int[] students = { 1, 1, 0, 0 };
        int[] sandwiches = { 0, 1, 0, 1 };
        Console.WriteLine("5. Cafeteria Sandwiches:");
        Console.WriteLine($"Input: students = [1,1,0,0], sandwiches = [0,1,0,1] => Output: {sol.CountStudents(students, sandwiches)}");
    }
}
