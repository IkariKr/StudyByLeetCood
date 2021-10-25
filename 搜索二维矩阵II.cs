using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyByLeetCood
{
    public class Solution
    {
        #region 搜索二维矩阵
        //    作者：LeetCode-Solution
        //    链接：https://leetcode-cn.com/problems/search-a-2d-matrix-ii/solution/sou-suo-er-wei-ju-zhen-ii-by-leetcode-so-9hcx/
        //来源：力扣（LeetCode）
        //著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
        /// <summary>
        /// 二分查找O(mlogn),o(1)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix1(int[][] matrix, int target)
        {
            foreach (int[] row in matrix)
            {
                int index = Search(row, target);
                if (index >= 0)
                {
                    return true;
                }
            }
            return false;
        }
        public int Search(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (high - low) / 2 + low;
                int num = nums[mid];
                if (num == target)
                {
                    return mid;
                }
                else if (num > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// Z 字形查找O(m+n),O(1)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix2(int[][] matrix, int target)
        {
            int m = matrix.Length, n = matrix[0].Length;
            int x = 0, y = n - 1;
            while (x < m && y >= 0)
            {
                if (matrix[x][y] == target)
                {
                    return true;
                }
                if (matrix[x][y] > target)
                {
                    --y;
                }
                else
                {
                    ++x;
                }
            }
            return false;
        }


    }



    #endregion //


}
