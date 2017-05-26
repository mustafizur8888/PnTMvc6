using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public  class SumClass
    {

        public static int Sum(params int[] a)
        {
            return a.Aggregate(0, (current, number) => current + number);
        }
    }
}
