using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public class Problem24
    {
        private readonly IList<int> _digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        /// <summary>
        /// Working solution to the Problem 24: Lexicographic permutations
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public long GetLexiographicPermutationAtIndex(int index)
        {
            StringBuilder sb = new StringBuilder();

            int calcIndex = index;
            IList<int> calcDigits = _digits.Select(i => i).ToList();
            for (int i = 0; i < _digits.Count; i++)
            {
                int possibleOutcomesCount = GetPossibleOutComesCount(calcDigits);
                int blockSize = possibleOutcomesCount / calcDigits.Count;

                int digitAt = 0;
                if (blockSize < calcIndex)
                {
                    digitAt = (calcIndex - 1) / blockSize;
                }

                sb.Append($"{calcDigits[digitAt]}");
                calcDigits.RemoveAt(digitAt);

                calcIndex -= digitAt * blockSize;
            }

            return long.Parse(sb.ToString());
        }

        private int GetPossibleOutComesCount(IList<int> digits)
        {
            int possibleOutcomesNr = 1;
            for (int i = 1; i <= digits.Count; i++)
            {
                possibleOutcomesNr *= i;
            }

            return possibleOutcomesNr;
        }
    }
}