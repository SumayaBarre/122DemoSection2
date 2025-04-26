/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Move Zeroes
        int[] nums1 = { 0, 1, 0, 3, 12 };
        MoveZeroes(nums1);
        Console.WriteLine("After moving zeroes: " + string.Join(",", nums1));

        // 2. Length of Last Word
        string s = "Hello World";
        int lastWordLength = LengthOfLastWord(s);
        Console.WriteLine("Length of last word: " + lastWordLength);

        // 3. Reverse String
        char[] s2 = { 'h', 'e', 'l', 'l', 'o' };
        ReverseString(s2);
        Console.WriteLine("Reversed string: " + new string(s2));

        // 4. Majority Element
        int[] nums2 = { 3, 2, 3 };
        int majority = MajorityElement(nums2);
        Console.WriteLine("Majority element: " + majority);

        // 5. Happy Number
        int n = 19;
        bool isHappy = IsHappy(n);
        Console.WriteLine("Is 19 a happy number? " + isHappy);
    }

    // 1. Move Zeroes
    public static void MoveZeroes(int[] nums)
    {
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j++;
            }
        }
    }

    // 2. Length of Last Word
    public static int LengthOfLastWord(string s)
    {
        int length = 0;
        int i = s.Length - 1;

        while (i >= 0 && s[i] == ' ')
        {
            i--;
        }

        while (i >= 0 && s[i] != ' ')
        {
            length++;
            i--;
        }

        return length;
    }

    // 3. Reverse String
    public static void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }

    // 4. Majority Element
    public static int MajorityElement(int[] nums)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            if (num == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return candidate;
    }

    // 5. Happy Number
    public static bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = GetSumOfSquares(n);
        }

        return n == 1;
    }

    private static int GetSumOfSquares(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }
}
