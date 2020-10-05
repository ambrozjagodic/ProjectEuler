using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem05
    {
        /// <summary>
        /// Working solution to the Problem 5: Smallest multiple
        /// </summary>
        /// <param name="upperLimit"></param>
        /// <returns></returns>
        public int GetSmallestDivisibleNumber(int upperLimit)
        {
            IEnumerable<int> divisions = Enumerable.Range(1, upperLimit);

            int result = -1;
            int num = upperLimit;

            bool solutionFound = false;
            while (!solutionFound)
            {
                if (divisions.All(i => num % i == 0))
                {
                    result = num;

                    solutionFound = true;
                }

                num++;
            }

            return result;
        }
    }
}