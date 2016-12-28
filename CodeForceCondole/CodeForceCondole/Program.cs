using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeForceCondole
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = Convert.ToUInt64(Console.ReadLine()); //стоимость секретов n - марок
            while (n % 3 == 0)
                n /= 3;
            Console.WriteLine(n / 3 + 1);
            Main(null);
        }
    }
}
