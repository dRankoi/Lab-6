using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._3
{
    class Bill : IHuman
    { 
        public void SayHello()
        {
            Console.WriteLine("Bill said: Hello");
        }
    }
}
