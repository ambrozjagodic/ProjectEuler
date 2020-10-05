using ProjectEuler.Core;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem18
    {
        public int GetMaxPathSum()
        {
            IList<int> nextRow = new List<int>();
            for (int i = EulerConsts.PROBLEM_18_NUMBERS.Count - 1; i > 0; i--)
            {
                IList<int> row = EulerConsts.PROBLEM_18_NUMBERS[i];
                nextRow = EulerConsts.PROBLEM_18_NUMBERS[i - 1];

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