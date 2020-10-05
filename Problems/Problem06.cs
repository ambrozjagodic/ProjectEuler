namespace ProjectEuler.Problems
{
    public class Problem06
    {
        /// <summary>
        /// Working solution to the Problem 6: Sum square difference
        /// </summary>
        /// <param name="upperLimit"></param>
        /// <returns></returns>
        public long GetSumSquareDifference(int upperLimit)
        {
            long sumSquare = 0;
            long sum = 0;

            for (int i = 1; i <= upperLimit; i++)
            {
                sumSquare += i * i;
                sum += i;
            }

            return sum * sum - sumSquare;
        }
    }
}