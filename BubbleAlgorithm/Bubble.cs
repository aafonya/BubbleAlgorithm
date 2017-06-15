using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleAlgorithm
{
    class Bubble
    {

        public static List<int> numbers = new List<int>();

        public static void printList(List<int> list)
        {
            foreach(int inty in list)
            {
                Console.Write(inty);
                Console.WriteLine(" ");
            }
            Console.WriteLine("\n");
        }

        public static void fulfillList()
        {
            numbers.Add(1);
            numbers.Add(6);
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(5);
        }
        public static void BubbleAlgorithm(List<int> list)
        {
            for (int i = 0 ; i < list.Count; i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                   if(numbers[j] > numbers[j + 1])
                    {
                        int k = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = k;
                    }
                }
            }
        }
    }
}
