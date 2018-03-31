using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i > 0; i-=7)
            {
                Directory.CreateDirectory("try"+i); 
            }
        }
    }
}
