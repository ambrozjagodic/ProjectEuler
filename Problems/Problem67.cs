using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem67
    {
        private readonly Problem18 _p18 = new Problem18();

        /// <summary>
        /// Working solution to the Problem 67: Maximum path sum II (NOTE: mind the path!)
        /// </summary>
        /// <returns></returns>
        public int GetMaxPathSum()
        {
            IList<IList<int>> numbers = LoadNumbersFromFile();

            return _p18.GetMaxPathSum(numbers);
        }

        private static IList<IList<int>> LoadNumbersFromFile()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string fullPath = projectDirectory + "\\res\\p067_triangle.txt";

            IList<string> numbersStr = File.ReadAllLines(fullPath).ToList();

            IList<IList<int>> numbers = new List<IList<int>>();
            foreach (string rowStr in numbersStr)
            {
                IList<string> rowStrList = rowStr.Split(" ").ToList();

                IList<int> row = rowStrList.Select(i => int.Parse(i)).ToList();

                numbers.Add(row);
            }

            return numbers;
        }
    }
}