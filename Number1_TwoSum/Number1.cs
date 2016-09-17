using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode
{
    class Number1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            //    for (int i = 0; i < nums.Length - 1; i++)
            //    {
            //        for (int j = i + 1; j < nums.Length; j++)
            //        {
            //            if (nums[i] + nums[j] == target)
            //                return new int[] { i,j};
            //        }
            //    }
            //    return new int[0];
            //
            int j;

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int com = target - nums[i];
                if (dic.TryGetValue(com, out j))
                {
                    int[] result = new int[] { j, i };
                    return result;
                }
                dic[com] = i;
            }
            return new int[0];
        }
    }
        
}
