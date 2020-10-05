using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem20
    {
        public int GetFactorialSum(int upperLimit)
        {
            IList<int> numbers = Enumerable.Range(1, upperLimit).ToList();
            GetSum(numbers, 0);
            for (int i = 0; i < numbers.Count(); i++)
            {
                int num = numbers[i];

                if (upperLimit % num == 0)
                {
                    int num2 = upperLimit / num;

                    if (numbers.Contains(num2))
                    {
                        numbers.Remove(num);
                        numbers.Remove(num2);
                    }
                }
            }
            GetSum(numbers, 1);

            for (int i = 0; i < numbers.Count(); i++)
            {
                int num = numbers[i];

                if (num % 10 == 0)
                {
                    numbers.Remove(num);
                    numbers.Add(num / 10);
                }
            }
            GetSum(numbers, 2);

            IList<int> divisibleByTwo = numbers.Where(i => i % 2 == 0).ToList();
            IList<int> divisibleByFive = numbers.Where(i => i % 5 == 0).ToList();

            if (divisibleByTwo.Intersect(divisibleByFive).Count() != 0)
            {
                Console.WriteLine("ERROR");
            }

            for (int i = 0; i < divisibleByTwo.Count(); i++)
            {
                if (i < divisibleByFive.Count())
                {
                    int num1 = divisibleByTwo[i];
                    numbers.Remove(num1);
                    numbers.Add(num1 / 2);

                    int num2 = divisibleByFive[i];
                    numbers.Remove(num2);
                    numbers.Add(num2 / 5);
                }
            }
            GetSum(numbers, 3);

            long product = 1;
            foreach(int i in numbers)
            {
                product *= i;
                if(product % 10 == 0)
                {
                    Console.ReadKey();
                }
            }

            return -1;
        }

        private void GetSum(IList<int> input, int step)
        {
            int sum = 0;
            foreach (int i in input)
            {
                sum += i;
            }

           //Console.WriteLine($"Sum in step {step} is {sum}. Element count = {input.Count()}");
        }
    }
}