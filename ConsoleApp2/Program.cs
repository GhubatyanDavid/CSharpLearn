namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type number");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = Counter(number, 0);


            if (number == NumberCheck(number, count))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Sorry False");
            }
        }
        public static int Counter(int number, int count)
        {
            while (number > 0)
            {
                count++;
                number = number / 10;
            }
            return count;
        }
        public static int NumberCheck(int number, int count)
        {
            int result = 0;
            while (number > 0)
            {
                int secondNum = number % 10;
                result += (int)Math.Pow(secondNum, count);
                number = number / 10;
            }
            return result;
        }
    }

}