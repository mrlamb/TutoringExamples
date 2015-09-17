using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        /// <summary>
        /// This program will randomly generate a set of numbers placing them into both a List and Stack as well
        /// as illustrating adding to and removing from both Stacks and Queues
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            List<int> intList = new List<int>();
            Stack<int> intStack = new Stack<int>();
            Queue<int> intQueue = new Queue<int>();

            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int num = rnd.Next(100);
                intArray[i] = num;
                intList.Add(num);
                intStack.Push(num);
                intQueue.Enqueue(num);
            }

            //Now will show four methods for getting items back
            Console.WriteLine("First the Array:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray[i].ToString());
            }
            Console.WriteLine("Then, the List:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intList[i].ToString());
            }
            Console.WriteLine("Then, the Stack:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intStack.Pop().ToString());
            }
            Console.WriteLine("Then, the Queue:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intQueue.Dequeue().ToString());
            }
            Console.WriteLine("Finally, we'll take one random number from each of our Array and List to illustrate random access.");
            Console.WriteLine(intArray[rnd.Next(4)].ToString());
            Console.WriteLine(intList[rnd.Next(4)].ToString());
            Console.ReadLine();
        }
    }
}
