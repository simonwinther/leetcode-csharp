using System;
namespace leetcode_csharp.problems
{
    public class TwoSum
    {
        public int[] Solve(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> seenValues = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (seenValues.ContainsKey(target - nums[i]))
                    return new int[] { seenValues[target - nums[i]], i };

                seenValues[nums[i]] = i;
            }

            return new int[2];
        }
    }
}
