using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BspDependencyInjection
{
    public class SimpleCalculator : ICalculator
    {

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
