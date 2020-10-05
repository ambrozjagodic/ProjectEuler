using ProjectEuler.Core;

namespace ProjectEuler.Problems
{
    public class Problem08
    {
        /// <summary>
        /// Working solution to the Problem 8: Largest product in a series
        /// </summary>
        /// <param name="adjacentNr"></param>
        /// <returns></returns>
        public long GetMaximumAdjacentDigitsProduct(int adjacentNr)
        {
            long max = -1;
            for (int i = 0; i < EulerConsts.PROBLEM_8_NUMBER.Length - adjacentNr + 1; i++)
            {
                char[] digits = EulerConsts.PROBLEM_8_NUMBER.Substring(i, adjacentNr).ToCharArray();

                long current = 1;
                foreach (char digit in digits)
                {
                    current *= (int)char.GetNumericValue(digit);
                }

                if (current > max)
                {
                    max = current;
                }
            }

            return max;
        }
    }
}