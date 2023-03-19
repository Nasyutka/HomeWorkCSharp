using System;
namespace HomeWork2
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            try
            {
                int.Parse(Console.ReadLine());
            }

            catch (FormatException) 
            {
             Console.WriteLine("Wrong! The size of the array is determined by a number.");
            }

            int sizeOftheArray = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter integer numbers:");
            int largest = 0;
            int second = 0;
            int[] integerNumber = new int[sizeOftheArray];
            for (int i = 0; i < sizeOftheArray; i++) 
            {
                int IntegerNumbers = int.Parse(Console.ReadLine());

                 IntegerNumbers = integerNumber[i];

                if (IntegerNumbers > largest)
                {
                    second = largest;
                    largest = IntegerNumbers;
                }
                else if (IntegerNumbers > second && IntegerNumbers < largest) ;
                second = IntegerNumbers;
            }

            Console.WriteLine($"The second largest number is:{second}");

        }

    }
}
