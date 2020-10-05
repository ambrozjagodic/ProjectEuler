using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    public class Problem14
    {
        /// <summary>
        /// Working solution to the Problem 14: Longest Collatz sequence
        /// </summary>
        /// <param name="upperLimit"></param>
        /// <returns></returns>
        public int GetLongestChainForCollatzSequence(int upperLimit)
        {
            IDictionary<long, int> knownLengths = new Dictionary<long, int>();

            int resultNum = -1;
            int biggestSeq = -1;
            for (int i = 2; i <= upperLimit; i++)
            {
                int seqCount = 0;

                long sequenceElement = i;
                while (sequenceElement != 1)
                {
                    if (sequenceElement < 1)
                    {
                        Console.WriteLine("ERROR");
                    }

                    if (knownLengths.ContainsKey(sequenceElement))
                    {
                        seqCount += knownLengths[sequenceElement];
                        sequenceElement = 1;
                    }
                    else
                    {
                        seqCount++;

                        if (IsEven(sequenceElement))
                        {
                            sequenceElement /= 2;
                        }
                        else
                        {
                            sequenceElement = 3 * sequenceElement + 1;
                        }
                    }
                }

                knownLengths.Add(i, seqCount);

                if (seqCount > biggestSeq)
                {
                    biggestSeq = seqCount;
                    resultNum = i;
                }
            }

            return resultNum;
        }

        private bool IsEven(long sequenceElement)
        {
            return sequenceElement % 2 == 0;
        }
    }
}