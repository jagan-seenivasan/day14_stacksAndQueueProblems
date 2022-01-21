using System;

namespace StackAndQueueProblems
{
    class Program
    {
        static void Main(string[] args)
       
            Console.WriteLine("----------------Stack & Queue problem-------------------");
            Console.WriteLine("***************************************************************************");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                int num = Convert.ToInt32(Console.ReadLine())
                switch (num)
                {
                    case 1:
                        Uc1_Create_Stack stack = new Uc1_Create_Stack();
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        Console.WriteLine("***********");
                        stack.Display();
                        break;
                    case 2:
                        Uc2_PeakAndPop pAp = new Uc2_PeakAndPop();
                        pAp.Push(70);
                        pAp.Push(30);
                        pAp.Push(56);
                        pAp.Pop();
                        pAp.Display();
                        break;
                    case 3:
                        uc3_create_queue queue = new uc3_create_queue();
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        Console.WriteLine("*************");
                        queue.Display();
                        break;

                    case 4:
                        uc4_dequeue dequeue = new uc4_dequeue();
                        dequeue.Enqueue(56);
                        dequeue.Enqueue(30);
                        dequeue.Enqueue(70);
                        Console.WriteLine("deque");
                        dequeue.Dequeue();
                        Console.WriteLine("***********);
                        dequeue.Display();
                        break;

                    default:
                        Console.WriteLine("Enter a valid option");
                        break;

                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                flag = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
