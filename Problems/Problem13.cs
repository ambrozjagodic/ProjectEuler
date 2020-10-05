using ProjectEuler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public class Problem13
    {
        /// <summary>
        /// Working solution to the Problem 13: Large sum
        /// </summary>
        /// <returns></returns>
        public string GetFirstTenDigitsOfSum()
        {
            IList<int> resultDigits = new List<int>();

            IList<string> reversedNumbers = ReverseNumbers();

            int numLength = reversedNumbers.First().Length;
            int transfer = 0;

            bool lastExec = false;
            for (int i = 0; i < numLength; i++)
            {
                lastExec = i == numLength - 1;

                IList<string> digits = reversedNumbers.Select(x => x.Substring(i, 1)).ToList();

                int sum = 0;
                foreach (string digit in digits)
                {
                    sum += int.Parse(digit);
                }

                sum += transfer;

                int digitToPush = sum % 10;
                resultDigits.Add(digitToPush);

                transfer = sum / 10;
                if (lastExec)
                {
                    while (transfer % 10 != 0)
                    {
                        digitToPush = transfer % 10;
                        resultDigits.Add(digitToPush);

                        transfer /= 10;
                    }
                }
            }

            return Stringify(resultDigits);
        }

        private string Stringify(IList<int> resultDigits)
        {
            StringBuilder sb = new StringBuilder();

            IList<int> reversedDigits = resultDigits.Reverse().ToList();
            foreach (int digit in reversedDigits)
            {
                sb.Append($"{digit}");
            }

            return sb.ToString();
        }

        private IList<string> ReverseNumbers()
        {
            return EulerConsts.PROBLEM_13_NUMBERS.Select(i => new string(i.Reverse().ToArray())).ToList();
        }
    }
}