using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 999, 2, 1, 5 };

            for(int i = 0; i < myArray.Length; i++)
            {
                for(int j=i+1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        int temp = 0;
                        temp = myArray[j];
                        myArray[j] = myArray[i];
                        myArray[i] = temp;
                    }
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
