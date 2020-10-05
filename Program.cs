using ProjectEuler.Core;
using ProjectEuler.Problems;
using System;
using System.Diagnostics;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Starting the execution. \n");

            ExecProblem1();
            ExecProblem2();
            ExecProblem3(); //Doesnt work yet.
            ExecProblem4();
            ExecProblem5();
            ExecProblem6();
            ExecProblem7();
            ExecProblem8();
            ExecProblem9();

            ExecProblem13();
            ExecProblem14();

            ExecProblem18();

            ExecProblem20(); //Doesnt work yet.

            ExecProblem24();

            ExecProblem67();

            Console.WriteLine("\nFinished with the execution.");
            Console.ReadKey();
        }

        private static void ExecProblem1()
        {
            Problem01 p1 = new Problem01();
            int upperLimit = 1000;
            Stopwatch s = Stopwatch.StartNew();
            int result = p1.GetSumOf3And5Multipliers(upperLimit);
            Console.WriteLine($"PROBLEM 1: The sum of all the multipliers of 3 and 5 below {upperLimit} is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem2()
        {
            Problem02 p2 = new Problem02();
            int upperLimit = 1000;
            Stopwatch s = Stopwatch.StartNew();
            int result = p2.GetEvenFibonnaciSum(upperLimit);
            Console.WriteLine($"PROBLEM 2: The sum of even Fibonacci numbers below {upperLimit} is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem3()
        {
            //Doesnt work
            //Euler3 e3 = new Euler3();
            //long number = 600851475143;
            ////long number = 756934; //should be 378467
            //s.Start();
            //long problem3Result = e3.GetLargestPrimeFactorTest2(number);
            //s.Stop();
            //Console.WriteLine($"PROBLEM 3: The largest prime factor of number {number} is {problem3Result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
        }

        private static void ExecProblem4()
        {
            Problem04 p4 = new Problem04();
            int digits = 3;
            Stopwatch s = Stopwatch.StartNew();
            int result = p4.GetPalindrom(digits);
            Console.WriteLine($"PROBLEM 4: Largest palindrome from the product of two {digits}-digit numbers is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem5()
        {
            Problem05 p5 = new Problem05();
            int upperLimit = 10;
            Stopwatch s = Stopwatch.StartNew();
            int result = p5.GetSmallestDivisibleNumber(upperLimit);
            Console.WriteLine($"PROBLEM 5: Smallest possible number that is evenly divisible by first {upperLimit} numbers is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem6()
        {
            Problem06 p6 = new Problem06();
            int upperLimit = 100;
            Stopwatch s = Stopwatch.StartNew();
            long result = p6.GetSumSquareDifference(upperLimit);
            Console.WriteLine($"PROBLEM 6: Difference between sum of squares and the square of sum for first {upperLimit} numbers is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem7()
        {
            Problem07 p7 = new Problem07();
            int index = 10001;
            Stopwatch s = Stopwatch.StartNew();
            int result = p7.GetPrimeNumberAt(index);
            Console.WriteLine($"PROBLEM 7: Prime number of index {index} is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem8()
        {
            Problem08 p8 = new Problem08();
            int adjacentDigits = 13;
            Stopwatch s = Stopwatch.StartNew();
            long result = p8.GetMaximumAdjacentDigitsProduct(adjacentDigits);
            Console.WriteLine($"PROBLEM 8: Largest product of {adjacentDigits} adjacent digits is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem9()
        {
            Problem09 p9 = new Problem09();
            Stopwatch s = Stopwatch.StartNew();
            int result = p9.GetProductOfPythagoreanTriplet();
            Console.WriteLine($"PROBLEM 9: Product of Pythagorean triplet is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem13()
        {
            Problem13 p13 = new Problem13();
            Stopwatch s = Stopwatch.StartNew();
            string result = p13.GetFirstTenDigitsOfSum();
            Console.WriteLine($"PROBLEM 13: The first 10 digits of the big sum are {new string(result.Substring(0, 10))}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem14()
        {
            Problem14 p14 = new Problem14();
            int upperLimit = 1000000;
            Stopwatch s = Stopwatch.StartNew();
            int result = p14.GetLongestChainForCollatzSequence(upperLimit);
            Console.WriteLine($"PROBLEM 14: Starting number that produces the longest sequence is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem18()
        {
            Problem18 p18 = new Problem18();
            Stopwatch s = Stopwatch.StartNew();
            int result = p18.GetMaxPathSum(EulerConsts.PROBLEM_18_NUMBERS);
            Console.WriteLine($"PROBLEM 18: Maximum sum of a triangle is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem20()
        {
            //Doesnt work.
            //Problem20 p20 = new Problem20();
            //int upperLimit = 100;
            //Stopwatch s = Stopwatch.StartNew();
            //int result = p20.GetFactorialSum(upperLimit);
            //Console.WriteLine($"PROBLEM 20: Sum of digits in the factorial of {upperLimit} is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            //s.Stop();
        }

        private static void ExecProblem24()
        {
            Problem24 p24 = new Problem24();
            int elementAt = 1000000;
            Stopwatch s = Stopwatch.StartNew();
            long result = p24.GetLexiographicPermutationAtIndex(elementAt);
            Console.WriteLine($"PROBLEM 24: Lexiographic permutation at index {elementAt} is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }

        private static void ExecProblem67()
        {
            Problem67 p67 = new Problem67();
            Stopwatch s = Stopwatch.StartNew();
            int result = p67.GetMaxPathSum();
            Console.WriteLine($"PROBLEM 67: Maximum sum of a triangle is {result}. Took {s.ElapsedTicks} ticks or {s.ElapsedMilliseconds} ms or {s.Elapsed.Seconds} s to execute.");
            s.Stop();
        }
    }
}