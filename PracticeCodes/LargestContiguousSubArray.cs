namespace PracticeCodes
{
    public class LargestContiguousSubArray
    {
        public int[] InputNumbers { get; set; }

        public LargestContiguousSubArray(int[] inputNumbers)
        {
            InputNumbers = inputNumbers;
        }

        public int GetLargestContiguousSum()
        {
            int finalSum = 0, intermediateSum = 0;

            foreach (var num in InputNumbers)
            {
                intermediateSum += num;

                if (intermediateSum < 0)
                    intermediateSum = 0;
                else if (finalSum < intermediateSum)
                    finalSum = intermediateSum;
            }

            return finalSum;
        }
    }
}
