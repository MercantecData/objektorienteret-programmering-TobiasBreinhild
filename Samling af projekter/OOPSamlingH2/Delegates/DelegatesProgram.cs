using System;

namespace Delegates
{
    class DelegatesProgram
    {
        public delegate void DelegateStuff();

        static void Main(string[] args)
        {
            DelegateStuff stuff = StuffStuff;

            stuff();
        }

        public static void StuffStuff()
        {
            Console.WriteLine("Even More Stuff!");
        }
    }
}
