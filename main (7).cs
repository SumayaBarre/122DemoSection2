/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/

// written by sumaya barre
// 4/3/2025
using System;
using System.Collections.Generic;

class Program
{// main method for all the 5 questions
    static void Main(string[] args)
    {
        Console.WriteLine("1. Two Sum:");
        TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        
        Console.WriteLine("\n2. Find Substring Index:");
        FindSubstringIndex("sadbutsad", "sad");

        Console.WriteLine("\n3. Remove Element:");
        RemoveElement(new int[] { 3, 2, 2, 3 }, 3);

        Console.WriteLine("\n4. Merge Sorted Arrays:");
        MergeSortedArrays(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);

        Console.WriteLine("\n5. Move Even Elements First:");
        MoveEvenFirst(new int[] { 3, 1, 2, 4 });
    }
// two sum to find target
    static void TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    Console.WriteLine($"Indices: [{i}, {j}]");
                    return;
                }
            }
        }
    }
// needle and haystack string
    static void FindSubstringIndex(string haystack, string needle)
    {
        int index = haystack.IndexOf(needle);
        Console.WriteLine($"Index: {index}");
    }
// remove element 
    static void RemoveElement(int[] nums, int val)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        Console.WriteLine($"New length: {k}");
        Console.Write("Array after removal: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
// merge two sorted arrays 
    static void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }

        Console.Write("Merged array: ");
        foreach (int num in nums1)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
// sort by parity
    static void MoveEvenFirst(int[] nums)
    {
        List<int> evens = new List<int>();
        List<int> odds = new List<int>();

        foreach (int num in nums)
        {
            if (num % 2 == 0) evens.Add(num);
            else odds.Add(num);
        }

        evens.AddRange(odds);

        Console.Write("Result: ");
        foreach (int num in evens)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

