using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class teste
    {
        protected void Falar()
        {
            Console.WriteLine($"5000");
        }
        protected void Falar(int dado)
        {
            Console.WriteLine($"{dado}");
        }
    }
}