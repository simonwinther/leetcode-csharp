using System;
namespace leetcode_csharp.problems
{
    public class ContainsDuplicate
    {
        public bool Solve(int[] nums)
        {

            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
                if (seen.Contains(num))
                    return true;
                seen.Add(num);
            }

            return false;
        }
    }
}

