using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyByLeetCood
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            //搜索二维矩阵
            int[][] matrix = new int[5][]
            {
                new int[5]{ 1, 4, 7, 11, 15 } ,
                new int[5]{ 2, 5, 8, 12, 19 } ,
                new int[5]{ 3, 6, 9, 16, 22 } ,
                new int[5]{ 10, 13, 14, 17, 24 } ,
                new int[5]{ 18, 21, 23, 26, 30 }
            };

            int target = 26;
            solution.SearchMatrix2(matrix, target);
        }
    }
}
