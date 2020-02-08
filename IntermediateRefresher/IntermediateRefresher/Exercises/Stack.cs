using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher.Exercises
{
    class Stack<T>
    {
        private List<T> _stack = new List<T>();
        public int Length { get { return _stack.Count; } }
        public void Push(T o)
        {
            _stack.Add(o);
        }

        public T Pop()
        {

            if (_stack.Count <= 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
            
            var lastItemIndex = _stack.Count - 1;
            var item = _stack[lastItemIndex];
            _stack.RemoveAt(lastItemIndex);
            return item;
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public void PrintStack()
        {
            if (_stack.Count > 0)
            {
                foreach (var item in _stack)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }


        public static void Run()
        {
            var myStack = new Stack<string>();
            myStack.Push("First");
            myStack.Push("Second");
            var second = myStack.Pop();
            myStack.Push("Third");

            // At this point i should be first and second 
            myStack.PrintStack();

            myStack.Pop();
            myStack.Pop();

            Console.WriteLine($"Stack count {myStack.Length}");

            myStack.Push("Test");
            Console.WriteLine($"Stack count {myStack.Length}");
            myStack.Clear();
            Console.WriteLine($"Stack count {myStack.Length}");
            try
            {
                myStack.Pop();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception message: {ex.Message}");
            }
        }
    }
}
