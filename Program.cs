/*
 Develop a program to manage a call queue of customers in C#
Create a queue of callers and demonstrate the functionality
of enqueing elements in to the queue and iterating over the elements
and dequeing - using linked lists
*/

//make queue
//callers in and out, like linkedlist? 
// add q
//remove q
//call q

namespace Assignment_6._3
{
    public class CallQueue
    {
        //using linkedlists
        private LinkedList<string> queue; 
        //don't really want to type q queue quqe

        public CallQueue()
        {
            queue = new LinkedList<string>();
        }

        //add to queue
        public void AddCall(string caller)
        {
            queue.AddLast(caller); //yes this is Bob
            Console.WriteLine($"Caller '{caller}' has been added to the queue.");
        }

        //remove from queue
        public string RemoveCall()
        {

            if (queue.Count > 0)
            {
                string caller = queue.First.Value; //not quite sure I understand this one
                //Console.WriteLine($"'{caller}' is next in the queue.");
                queue.RemoveFirst();
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine($"Caller '{caller}' is now on the line.");
                return caller;
            }
            else
            {
                Console.WriteLine("No one is in line to be on the line.");
                return null;
            }
        }

        //.peek

        //isempty?

        //show calls
        public void DisplayCalls()
        {
            if (queue.Count > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("The order of callers as follows:");
                foreach (string caller in queue)
                {
                    //Console.WriteLine("");
                    Console.WriteLine(caller);
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("There are currently no callers on the line.");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Create a call queue
            CallQueue callQueue = new CallQueue();

            Console.WriteLine("Welcome to the Console App Switchboard.");
            Console.WriteLine("");

            //it's teh simulation
            callQueue.AddCall("Jimmy Johns");
            callQueue.AddCall("Burger King");
            callQueue.AddCall("Pizza Hut");
            callQueue.AddCall("GameStop");

            callQueue.DisplayCalls();

            //adding and removing seems arbitrary, there should be some sort of reasoning behind it
            callQueue.RemoveCall();
            callQueue.RemoveCall();
        }
    }
}
