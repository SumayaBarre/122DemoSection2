/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/ 
  
using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    // 1. First Non-Repeating Character in a String
    public int FirstUniqChar(string s) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        foreach (char c in s) {
            if (count.ContainsKey(c))
                count[c]++;
            else
                count[c] = 1;
        }

        for (int i = 0; i < s.Length; i++) {
            if (count[s[i]] == 1)
                return i;
        }

        return -1;
    }

    // 2. Merge Two Strings Alternately
    public string MergeAlternately(string word1, string word2) {
        int i = 0, j = 0;
        int n = word1.Length, m = word2.Length;
        var result = new StringBuilder();

        while (i < n || j < m) {
            if (i < n) result.Append(word1[i++]);
            if (j < m) result.Append(word2[j++]);
        }

        return result.ToString();
    }

    // 3. Judge if Robot Returns to Origin
    public bool JudgeCircle(string moves) {
        int x = 0, y = 0;

        foreach (char move in moves) {
            switch (move) {
                case 'U': y++; break;
                case 'D': y--; break;
                case 'L': x--; break;
                case 'R': x++; break;
            }
        }

        return x == 0 && y == 0;
    }

    // 4. Find the Extra Letter in a Shuffled String
    public char FindTheDifference(string s, string t) {
        char result = '\0';
        foreach (char c in s) {
            result ^= c;
        }
        foreach (char c in t) {
            result ^= c;
        }
        return result;
    }

    // 5. Count the Number of Segments in a String
    public int CountSegments(string s) {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        string[] segments = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return segments.Length;
    }

    // 6. Max Number of Instances of the Word "balloon"
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        foreach (char c in text) {
            if (count.ContainsKey(c)) count[c]++;
            else count[c] = 1;
        }

        return Math.Min(
            count.ContainsKey('b') ? count['b'] : 0,
            Math.Min(count.ContainsKey('a') ? count['a'] : 0,
            Math.Min(count.ContainsKey('l') ? count['l'] / 2 : 0,
            Math.Min(count.ContainsKey('o') ? count['o'] / 2 : 0,
            count.ContainsKey('n') ? count['n'] : 0))));
    }
}
//main method 
public class Program {
    public static void Main(string[] args) {
        var solution = new Solution();

        // 1. First Non-Repeating Character
        Console.WriteLine(solution.FirstUniqChar("leetcode")); // Output: 0

        // 2. Merge Strings Alternately
        Console.WriteLine(solution.MergeAlternately("abc", "pqr")); // Output: "apbqcr"

        // 3. Judge if Robot Returns to Origin
        Console.WriteLine(solution.JudgeCircle("UD")); // Output: true

        // 4. Find the Extra Letter in Shuffled String
        Console.WriteLine(solution.FindTheDifference("abcd", "abcde")); // Output: 'e'

        // 5. Count Number of Segments
        Console.WriteLine(solution.CountSegments("Hello, my name is John")); // Output: 5

        // 6. Max Number of Instances of "balloon"
        Console.WriteLine(solution.MaxNumberOfBalloons("nlaebolko")); // Output: 1
    }
}

