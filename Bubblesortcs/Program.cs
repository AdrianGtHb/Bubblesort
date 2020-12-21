using System;

namespace Bubblesortcs
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] n = { 'b', 'n', 'r', 'a', 'o', 't' };



            for (int i = n.Length; i > 0; i--)
            {
                for (int k = 0; k < n.Length - 1; k++)
                {
                    if (n[k] > n[k+1])
                    {
                        char temp;
                        temp = n[k + 1];
                        n[k + 1] = n[k];
                        n[k] = temp;
                    }
                }
            }
            Console.WriteLine(n);
        }
    }
}
