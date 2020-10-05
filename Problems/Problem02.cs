namespace ProjectEuler.Problems
{
    public class Problem02
    {
        /// <summary>
        /// Working solution to the Problem 2: Even Fibonacci numbers
        /// </summary>
        /// <param name="upperLimit"></param>
        /// <returns></returns>
        public int GetEvenFibonnaciSum(int upperLimit)
        {
            int previous = 1;
            int now = 2;
            int sum = 0;
            bool firstExec = true;
            while (now < upperLimit)
            {
                if (!firstExec)
                {
                    int tmp = now;
                    now = previous + tmp;
                    previous = tmp;
                }

                if (now % 2 == 0)
                {
                    sum += now;
                }

                firstExec = false;
            }

            return sum;
        }
    }
}