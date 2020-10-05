using ProjectEuler.Core;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem18
    {
        /// <summary>
        /// Working solution to the Problem 18: Maximum path sum I
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int GetMaxPathSum(IList<IList<int>> numbers)
        {
            IList<int> nextRow = new List<int>();
            for (int i = numbers.Count - 1; i > 0; i--)
            {
                IList<int> row = numbers[i];
                nextRow = numbers[i - 1];

                for (int j = 0; j < row.Count - 1; j++)
                {
                    int num;
                    if (row[j] > row[j + 1])
                    {
                        num = row[j];
                    }
                    else
                    {
                        num = row[j + 1];
                    }

                    nextRow[j] += num;
                }
            }

            return nextRow.Single();
        }
    }
}