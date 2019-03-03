using System;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Generate a list of 100 random integers between 0 and 1000 and ouput the maximum value.

            int randomInt = new Random(100).Next(0, 1001);
            
            int maxValue = randomInt++;

            if (randomInt >= 0 && randomInt <= 1000)
            {
               Console.WriteLine(maxValue);
            }
            

            Console.ReadLine();
        }
    }
}
