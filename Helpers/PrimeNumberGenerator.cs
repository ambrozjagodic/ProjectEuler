using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Helpers
{
    public class PrimeNumberGenerator
    {
        public IList<int> GetPrimeNumbers(int limit)
        {
            IList<int> knownPrimes = new List<int> { 2 };

            for (int i = 2; i < limit; i++)
            {
                if (!knownPrimes.Any(j => i % j == 0))
                {
                    bool isPrime = true;

                    for (int k = knownPrimes.Last(); k < i / 2; k++)
                    {
                        if (i % k == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        knownPrimes.Add(i);
                    }
                }
            }

            return knownPrimes;
        }

        public IList<int> GetThisManyPrimeNumbers(int nrOfPrimeNumbers)
        {
            IList<int> knownPrimes = new List<int> { 2 };

            int i = 2;
            while (knownPrimes.Count != nrOfPrimeNumbers)
            {
                if (!knownPrimes.Any(j => i % j == 0))
                {
                    bool isPrime = true;

                    for (int k = knownPrimes.Last(); k < i / 2; k++)
                    {
                        if (i % k == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        knownPrimes.Add(i);
                    }
                }

                i++;
            }

            return knownPrimes;
        }
    }
}