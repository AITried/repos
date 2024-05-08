namespace Proval
{
    public class MaxSumRange
    {
        public int start, end, maxSum;
        public MaxSumRange(int start, int end, int maxSum)
        {
            this.start = start;
            this.end = end;
            this.maxSum = maxSum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, -3, 4, 5, -14, 12, 1, -5 };
            static MaxSumRange Solut(int[] arr)
            {
                int currsum = 0;
                int startIndex = 0;
                MaxSumRange maxSumRange = null;
                for (int endIndex = 0; endIndex < arr.Length; endIndex++) {
                    currsum += arr[endIndex];
                    if (maxSumRange == null || currsum>maxSumRange.maxSum)
                    {
                        maxSumRange = new MaxSumRange(startIndex, endIndex, currsum);

                    }
                    if (currsum<0)
                    {
                        currsum = 0;
                        startIndex = endIndex+1;
                    }
                }
                return maxSumRange;
            }
            MaxSumRange maxSum = Solut(arr);

            Console.WriteLine( maxSum.maxSum );
        }
    }
}