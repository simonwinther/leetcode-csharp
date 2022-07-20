using System;
namespace leetcode_csharp.problems
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {

            int low = 0, high = nums.Length - 1;

            while (low <= high)
            {
                var middle = low + ((high - low) / 2);

                if (nums[middle] == target)
                    return middle;

                if (nums[middle] < target)
                    low = middle + 1;
                else
                    high = middle - 1;
            }

            return -1;
        }
    }
}

