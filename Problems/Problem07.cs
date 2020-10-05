using ProjectEuler.Helpers;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    public class Problem07
    {
        private readonly PrimeNumberGenerator _primeGenerator = new PrimeNumberGenerator();

        /// <summary>
        /// Working solution to the Problem 7: 10001st prime
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetPrimeNumberAt(int index)
        {
            IList<int> primeNumbers = _primeGenerator.GetThisManyPrimeNumbers(index);

            return primeNumbers[index - 1];
        }
    }
}