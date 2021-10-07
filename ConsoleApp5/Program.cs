using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Include main string:");
            string mstring = Console.ReadLine();
            Console.WriteLine("Include a text which is u are looking for:");
            string lstring = Console.ReadLine();
            Console.WriteLine(mstring.MyContains(lstring));          
        }
    }
    static class Extension
    {
        public static bool MyContains(this string mainstr,string part)
        {
            int temp = 0;
            for (int i = 0; i < mainstr.Length;i++ )
            {
                if (mainstr[i] == part[0])
                {
                    for(int k = i + 1, j = 1; j < part.Length; j++, k++)
                    {
                        if (mainstr[k] == part[j])
                        {
                            temp++;
                        }
                    }
                }
            }
            if (temp == part.Length - 1)
            {
                return true;
            }
            return false;
        }
    }
}
