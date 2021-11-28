using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ведите размер массива:");
            int size = Convert.ToInt16(Console.ReadLine());
            int [] array = new int [size];
            for (int i=0; i < size; i++)
            {
                Console.WriteLine("введите  номер элемента: {0}", i + i);
                array [i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.Clear();
            double aa = 0;
            foreach (int a in array) aa += Convert.ToDouble(a / size);
            Console.WriteLine("Среднее арифмитическое значение: {0} ", aa);
            Console.ReadKey();
        }
    }
}
