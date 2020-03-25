using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _079UsingGenericType
    {
        class MyStack<T>
        {
            int stackTop = 0;

            T[] items = new T[100];

            public void push(T item)
            {
                if (stackTop == items.Length)
                    throw new Exception("Stack Full");
                items[stackTop] = item;
                stackTop++;
            }

            public T pop()
            {
                if (stackTop == 0)
                    throw new Exception("Stack is empty");
                stackTop--;
                return items[stackTop];
            }
        }

        public static void executeTest()
        {
            MyStack<string> myStack = new MyStack<string>();
            myStack.push("Rob");
            myStack.push("Mary");
            Console.WriteLine(myStack.pop());
            Console.WriteLine(myStack.pop());
            Console.ReadKey();

        }
    }
}
