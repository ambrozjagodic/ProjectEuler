namespace ProjectEuler.Problems
{
    public class Problem09
    {
        /// <summary>
        /// Working solution to the Problem 9: Special Pythagorean triplet (Iterating to 1000 not neccessary, but it works fast)
        /// </summary>
        /// <returns></returns>
        public int GetProductOfPythagoreanTriplet()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    int c = 1000 - a - b;

                    if (c < b)
                    {
                        break;
                    }

                    if ((a * a) + (b * b) == (c * c))
                    {
                        return a * b * c;
                    }
                }
            }

            return -1;
        }
    }
}