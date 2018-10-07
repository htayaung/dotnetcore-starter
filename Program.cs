using System;

namespace dotnetcore_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Welcome());
            
            Console.ReadLine();
        }

        private static string Welcome(){
            return "Welcome!";
        }
    }
}
