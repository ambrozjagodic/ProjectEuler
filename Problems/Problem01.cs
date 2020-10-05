namespace ProjectEuler.Problems
{
    public class Problem01
    {
        /// <summary>
        /// Working solution to the Problem 1: Multiples of 3 and 5
        /// </summary>
        /// <param name="upperLimit"></param>
        /// <returns></returns>
        public int GetSumOf3And5Multipliers(int upperLimit)
        {
            int sum = 0;
            for (int i = 1; i < upperLimit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}