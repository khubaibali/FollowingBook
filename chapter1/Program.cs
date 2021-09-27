using System;

namespace chapter1
{
    class Program
    {
        static bool UseUmbrella(bool rainy, bool sunny, bool windy)
        {
            return !windy && (rainy || sunny);
        }
        static void Main(string[] args)
        {
            //string msg = "C sharp great explaination";
            //string uppermsg = msg.ToUpper();
            //Console.WriteLine(uppermsg);

            //int x = 2021;
            //msg = msg + x.ToString();
            //Console.WriteLine(msg);

            //int x = 2021;
            //Console.WriteLine(x);

            //long y = x;
            //Console.WriteLine(y);

            //short z = (short)x;
            //Console.WriteLine(z);

            //Console.WriteLine(Program.UseUmbrella(true, false, true));
            //char[] chaArr = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //Console.WriteLine(chaArr);

            //string str = null;
            //str ??= "some default value";
            //Console.WriteLine(str);

        }
    }
}
