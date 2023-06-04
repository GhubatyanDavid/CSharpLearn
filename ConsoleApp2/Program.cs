namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int secondNum = 0;
            int numCopy = number;
            int secCopy = number;
            int result = 0;
            int count = 0;
            while(number > 0)
            {
                count++;
                number = number / 10;
            }
            while (numCopy > 0)
            {
                secondNum = numCopy % 10;
                result += (int)Math.Pow(secondNum, count);
                numCopy = numCopy / 10;
            }
            if(secCopy == result)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Sorry False");
            }


        }
    }
}