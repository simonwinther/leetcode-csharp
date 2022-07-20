using System;
using leetcode_csharp.problems;

namespace leetcode_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "A man, a plan, a canal: Panama";
            s = "aa";

            var vp = new ValidPalindrome();
            Console.WriteLine(vp.IsPalindrome(s));
        }
    }
}