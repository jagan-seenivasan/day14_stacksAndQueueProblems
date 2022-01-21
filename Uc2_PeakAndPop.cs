using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueProblems
{
    class Uc2_PeakAndPop
    {
        //Creating node a top
        public Node top;
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} is added ", newNode.data);
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Console.WriteLine("The peek element after peeking is : " + this.top.data);
        }
        //Pop Method to remove top most element
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Peek();
            this.top = this.top.next;
        }

        //ceking is empty of statck
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("there is no values added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in te stack is " + temp.data);
                temp = temp.next;
            }
        }
    }
}
