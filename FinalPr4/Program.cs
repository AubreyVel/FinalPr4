using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = InputArray();
            DisplayArray(Array); //printarray, just accidently name soemthin else
            FindMaximum(Array);


            Console.ReadLine();
        }

        static int[] InputArray()
        {
            int count = 0;
            int[] inputArray = new int[10];

            for (int i = 0; i < inputArray.Length; i++)
            {

                Console.Write("Enter a integer for number " + count + " ");
                count++;
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
                //inputArray[i];
            }
            return inputArray;
        }


        static void DisplayArray(int[] inputArray)
        {
            for (int i = 0;i< inputArray.Length ; i++)
            {
                Console.Write(inputArray[i] +" ");
            }
            Console.ReadLine();
        }

        static void FindMaximum(int[] inputArray)
        {
            int max = 0;
            for (int i = 0; i<inputArray.Length; i++)
            {
                if (inputArray[i] > max)
                {
                    max = inputArray[i];
                }
            }
            Console.WriteLine(max);
        }




    }
}
