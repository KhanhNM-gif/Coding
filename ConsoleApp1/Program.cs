using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string schar = "";
            foreach (char c in s)
            {
                schar += Convert.ToString(c, 2).PadLeft(8, '0');
                Console.WriteLine(c.ToString().PadRight(8, ' ') + ((int)c).ToString().PadRight(8, ' ') + Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            schar = schar.PadRight(schar.Length + 6 - schar.Length % 6, '0');

            Console.WriteLine("\n Cut 6 bit:");

            for (int i = 0; i < schar.Length - 1; i += 6)
            {
                string m = schar.Substring(i, 6);
                Console.WriteLine(m.ToString().PadRight(10, ' ') + Convert.ToInt64(m, 2));

            }

            Console.WriteLine("Base 64: " + System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(s)));



            Console.ReadKey();
        }
    }
}
