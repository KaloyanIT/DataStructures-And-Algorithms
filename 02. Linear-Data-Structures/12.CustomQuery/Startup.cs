using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CustomQuery
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var queue = new LinkedQueue<int>();

            queue.Put(5);
            queue.Put(10);

            Console.WriteLine(queue.Get());
            Console.WriteLine(queue.Get());

        }
    }
}
