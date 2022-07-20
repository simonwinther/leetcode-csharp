
using System;
namespace leetcode_csharp.problems
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var withoutSpecial = new string(s.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray());
            int left = 0, right = withoutSpecial.Length - 1;

            if (withoutSpecial == null || withoutSpecial.Length <= 1)
                return true;

            while (left < right)
            {
                if (withoutSpecial[left] != withoutSpecial[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}

