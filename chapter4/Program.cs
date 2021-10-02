using System;
using System.Collections.Generic;
using System.IO;

namespace chapter4
{
    class TuplePrac
    {
        public static  (string name, double age)  Foo(string name,double age)
        {
            return (name, age);
        }
    }
    class TryCatchException
    {
        public static void dividebyzero(int x,int y)
        {
            try
            {
                int result = x / y;
                Console.WriteLine(result);
            }
            catch (Exception ex)   // can also write DivideByZeroException
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Code is still alive");
            }
        }

        public static void ThrowingException(string str)
        {
            if(str == null)
            {
                throw new ArgumentNullException ("null passed");
            }
        }
    }

    class Program
    {
        public static IEnumerable<string> Foo()
        {
            yield return "Crazy";
            yield return "Brown";
            yield return "Fox";
        }
        static void Main(string[] args)
        {
            ////TryCatchException.dividebyzero(2,0);
            //StreamReader reader = null;
            //if (File.Exists("file.txt"))
            //{
            //    reader = File.OpenText("file.txt");
            //    Console.WriteLine(reader.ReadToEnd());
            //}
            //else
            //{
            //    Console.WriteLine("File does not found");
            //}

            //try
            //{
            //    TryCatchException.ThrowingException(null);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //foreach (string s in Program.Foo())
            //    Console.Write(s);

            var boo = ("khubaib", "Ali", "Quadri");
            Console.WriteLine(boo);


            (string name, double age) person = TuplePrac.Foo("Khubaib", 25.5);

            Console.Write(person);
            
            
        }
    }
}
