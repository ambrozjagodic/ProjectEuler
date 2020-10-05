using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem04
    {
        /// <summary>
        /// Working solution to the Problem 4: largest palindrome product
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int GetPalindrom(int digits)
        {
            int max = (int)Math.Pow(10, digits);

            int result = -1;
            for (int i = max - 1; i > max / 10 - 1; i--)
            {
                for (int j = max - 1; j > max / 10 - 1; j--)
                {
                    int num = i * j;
                    if (num > result)
                    {
                        string numStr = num.ToString();

                        int firstSplit;
                        int secondSplit;
                        if (numStr.Length % 2 == 0)
                        {
                            firstSplit = numStr.Length / 2;
                            secondSplit = firstSplit;
                        }
                        else
                        {
                            firstSplit = (numStr.Length - 1) / 2;
                            secondSplit = firstSplit + 1;
                        }

                        string part1 = numStr.Substring(0, firstSplit);
                        string part2 = numStr.Substring(secondSplit);

                        string reversedPart2 = new string(part2.Reverse().ToArray());

                        if (part1.Equals(reversedPart2))
                        {
                            if (num > result)
                            {
                                result = num;
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}