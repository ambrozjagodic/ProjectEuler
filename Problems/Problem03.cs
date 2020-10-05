using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem03
    {
        private readonly List<long> _primes;

        public Problem03()
        {
            _primes = new List<long> { 2, 3, 5 };
        }

        public long GetLargestPrimeFactor(long number)
        {
            long result = 0;

            IList<long> ignore = new List<long>();
            int progress = 0;
            for (int i = 3; i < number / 2; i += 2)
            {
                if (progress % 10000 == 0)
                {
                    Console.WriteLine($"Got through {progress} numbers. Current prime count is {ignore.Count}. Currently at number {i}.");
                }

                if (!ignore.Any(j => i % j == 0))
                {
                    ignore.Add(i);

                    if (number % i == 0)
                    {
                        result = i;
                    }
                }

                progress++;
            }

            return result;
        }

        public long GetLargestPrimeFactorTest(long number)
        {
            long result = 0;
            for (int i = 3; i < number; i += 2)
            {
                if (IsPrime(i))
                {
                    if (number % i == 0)
                    {
                        result = i;
                    }
                }
            }

            return result;
        }

        private bool IsPrime(int input)
        {
            if (!_primes.Any(j => input % j == 0))
            {
                _primes.Add(input);

                return true;
            }

            return false;
        }

        public long GetLargestPrimeFactorTest2(long number)
        {
            long initial;
            if (number % 2 == 0)
            {
                initial = number / 2;
            }
            else
            {
                initial = (number + 1) / 2 - 1;
            }

            for (long i = initial; i > 1; i -= 2)
            {
                if (i % 2 != 0)
                {
                    if (i % 3 != 0)
                    {
                        if (i % 5 != 0)
                        {
                            for (int j = 7; j < i; j += 2)
                            {
                                if (!_primes.Any(i => i % j == 0))
                                {
                                    _primes.Add(j);
                                }

                            }
                        }
                    }
                }
            }

            return -1;
        }
    }
}