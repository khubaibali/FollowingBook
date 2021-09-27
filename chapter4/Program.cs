using System;

namespace chapter4
{   class TryCatchException
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            TryCatchException.dividebyzero(2,0);
        }
    }
}
