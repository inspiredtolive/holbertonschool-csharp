using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Represents math operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Gets the highest integer in a list.
        /// </summary>
        /// <param name="nums">A list of ints.</param>
        /// <returns>The max int.</returns>
        public static int Max(List<int> nums)
        {
            int maxNum = int.MinValue;

            if (nums.Count == 0)
            {
                return 0;
            }
            foreach (int num in nums)
            {
                if (maxNum < num)
                {
                    maxNum = num;
                }
            }
            return maxNum;
        }
    }
}
