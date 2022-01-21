using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueProblems
{
    class Uc1_Create_Stack
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
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("there no values added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in te stack is " + temp.data);
                temp = temp.next;
            }
        }

        internal void Pop()
        {
            throw new NotImplementedException();
        }
    }
}
