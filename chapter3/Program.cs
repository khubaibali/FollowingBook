using System;
using System.Collections.Generic;

namespace chapter3
{
    public class Stack<T>
    {
        int position;
        T[] data = new T[100];
        public void Push(T obj);
        public T Pop(T obj);
    }
    class Program
    {
        static void writecubes()
        {   //defining function inside function
            Console.WriteLine(cube(3));
            Console.WriteLine(cube(2));

            int cube(int x) => x * x *x;
        }
        static void Main(string[] args)
        {
            //Program.writecubes();
            string name = "this is Syed Khubaib Ali";
            string[] arr= name.Split();
            var c = arr[..2];
            Console.WriteLine(c);
        }
    }
}
