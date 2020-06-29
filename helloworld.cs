using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
#if NET50
            Console.WriteLine("Hello .NET 5.0 World!");
#else
            Console.WriteLine("Hello old world!");
#endif

        }
    }
}
