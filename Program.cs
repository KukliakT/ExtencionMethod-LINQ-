using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtencionMethod__LINQ_
{
    public static class IntegerExtension
    {
        public static int Product(this IEnumerable<int> num)
        {
            int res = 1;
            foreach (var i in num)
            {
                res *= i;
            }
            return res;
        }


        class Program
        {
            static void Main(string[] args)
            {

                int[] numbers = { 1, 2, 3, 4, 6 };

                int query = numbers.Aggregate((x, y) => x * y);
                int prod = (from i in numbers where i % 2 == 0 && i < 10 select i).Product();

                Console.WriteLine(query);
                Console.WriteLine(prod);
            }
        }
    }
}