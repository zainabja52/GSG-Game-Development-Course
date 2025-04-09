namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var n in numbers)
                sum += n;
            return sum;
        }

        public static string RepeatString(this string input, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
                result += input;
            return result;
        }
    }
}
