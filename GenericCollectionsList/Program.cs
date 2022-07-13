using System;

namespace GenericCollectionsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //singleList test cases
            LinkedList<string> strings = new LinkedList<string>();
            strings.Add("A");
            strings.Add("C");
            strings.Add("B");
            strings.Add("C");
            strings.Add("D");
            strings.Add("C");
            strings.Add("E");
            strings.Add("F");
            Console.WriteLine($"returns true if prensent and false if not present: {strings.Check("F")}");
            Console.WriteLine($"The item removed from the linkedlist is firstOccurance: {strings.Remove("C")}");
            Console.WriteLine($"the index of D is : { strings.Index("D")}");


            foreach (var item in strings)
            {
                Console.WriteLine($"The items present in the singlelinkedlist is: {item}");
            }
            Console.WriteLine("************************************************");
            Console.WriteLine("*************");


            //Stack TestCase

            Stack<string> stack = new Stack<string>();
            stack.Push("Dozie");
            stack.Push("Tobi");
            stack.Push("Bimbola");
            stack.Push("Louis");
            stack.Push("Best");
            stack.Push("Otuka");
            stack.Push("Pelumi");
            stack.Push("Dorcas");
            Console.WriteLine($"the size of the stack before popping : {stack.Size()}");

            Console.WriteLine($"The item popped from the stack is :{stack.Pop()}");
            Console.WriteLine($"the size of the stack after poping : {stack.Size()}");
            Console.WriteLine($"return true if is not IsEmpty and false if it IsEmpty: {stack.IsEmpty()}");
            foreach (var item in stack)
            {
                Console.WriteLine($"The items of the stack is : {item}");
            }

            Console.WriteLine("*********");
            Console.WriteLine("*******************************");


            //Queue Test Cases
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Grace");
            queue.Enqueue("Joy");
            queue.Enqueue("Peace");
            queue.Enqueue("Love");
            queue.Enqueue("Endurance");
            queue.Enqueue("favour");
            Console.WriteLine($"The item removed : from the queue is: {queue.Dequeue()}");

            Console.WriteLine($"The size of the queue is: {queue.Size()}");
            Console.WriteLine($"Returns True if the queue is not empty and false if it is empty: {queue.QueueIsEmpty()}");
            foreach (var item in queue)
            {
                Console.WriteLine($"The items in the queue is : {item}");
            }
            Console.ReadLine();
        }
    }
}
