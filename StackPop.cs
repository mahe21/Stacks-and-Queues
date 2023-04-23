using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StacksAndQueues
{
    public class Stack
    {
        private LinkedList<int> linkedList = new LinkedList<int>();

        
        public void Push(int data)
        {
            linkedList.AddLast(data);
        }

        
        public int Pop()
        {
            if (linkedList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int poppedData = linkedList.Last.Value;
            linkedList.RemoveLast();

            return poppedData;
        }

        
        public int Peek()
        {
            if (linkedList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return linkedList.Last.Value;
        }

        
        public bool IsEmpty()
        {
            return linkedList.Count == 0;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Stack myStack = new Stack();

            myStack.Push(70);
            myStack.Push(30);
            myStack.Push(56);

            while (!myStack.IsEmpty())
            {
                Console.WriteLine("Peeked element: " + myStack.Peek());
                Console.WriteLine("Popped element: " + myStack.Pop());
            }

            Console.WriteLine("Is stack empty? " + myStack.IsEmpty());
        }
    }
}
