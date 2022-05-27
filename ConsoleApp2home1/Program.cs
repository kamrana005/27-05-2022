using System;

namespace ConsoleApp2home1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] listOfNumbers = { 23, 34, 43 };
            int number = 15;
            newNumber(listOfNumbers, 15);
    
        }

        static void newNumber(int[] listOfNumbers, int number)
        {
            int[] newd = new int[listOfNumbers.Length + 1];
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                newd [i]= listOfNumbers[i];
            }
            newd [new.Length - 1] = number;
        }


    }
    

}
