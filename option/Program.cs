using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace option
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            double x = 0;
            foreach (var i in a)
            {
                x += Convert.ToInt32(i);
            }
            double sr = x / a.Length;
            Console.WriteLine(sr);
        }
    }
}
