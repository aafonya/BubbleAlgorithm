using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Bubble.fulfillList();
            Bubble.printList(Bubble.numbers);
            Bubble.BubbleAlgorithm(Bubble.numbers);
            Bubble.printList(Bubble.numbers);
        }
    }
}
