using System;

namespace GoogleQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new GoggolApi();
            var sobakes = a.Search("собака");
            Console.ReadLine();
        }
    }
}
