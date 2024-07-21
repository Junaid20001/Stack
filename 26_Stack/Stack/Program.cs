using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample // Renamed namespace to avoid conflict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("Junaid");
            myStack.Push(22);
            myStack.Push(6.4);
            myStack.Push(true);
            myStack.Push("Khalid");
            myStack.Push(null);    //null
            myStack.Push("Khalid");    //repeat
            myStack.Push("Maiz");

            //Console.WriteLine(myStack.Peek());  //show only last element
            //Console.WriteLine(myStack.Contains("Junaid")); //element is present show true

            //Console.WriteLine(myStack.Count);  //total element

            foreach (object item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------");

            myStack.Pop();  //remove last element that add in table
            foreach (object item in myStack)
            {
                Console.WriteLine(item);
            }

            //myStack.Clear();  //remove all elements

            Console.ReadLine();
        }
    }

}
