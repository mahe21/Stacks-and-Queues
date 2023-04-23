/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{

    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    public class Stack
    {
        private Node top;

        public Stack()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);

            if (this.top == null)
            {
                this.top = newNode;
            }
            else
            {
                newNode.next = this.top;
                this.top = newNode;
            }
        }

        public int Pop()
        {
            if (this.top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int poppedData = this.top.data;
            this.top = this.top.next;

            return poppedData;
        }

        public int Peek()
        {
            if (this.top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return this.top.data;
        }

        public bool IsEmpty()
        {
            return this.top == null;
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

            Console.WriteLine("Top element of the stack: " + myStack.Peek());

            Console.WriteLine("Popped element: " + myStack.Pop());
            Console.WriteLine("Popped element: " + myStack.Pop());
            Console.WriteLine("Popped element: " + myStack.Pop());

            Console.WriteLine("Is stack empty? " + myStack.IsEmpty());
        }
    }
}*/
