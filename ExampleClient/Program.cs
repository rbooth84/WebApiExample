using RestSharp;
using System;
using System.Threading;

namespace ExampleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            var result = client.DoLogin("TestUser", "pwdwrdOne");

            Console.WriteLine($"Successful: {result.Successful}");
            Console.WriteLine($"AllowedToDoSomething: {result.AllowedToDoSomething}");
            Console.WriteLine($"AllowedToDoSomethingElse: {result.AllowedToDoSomethingElse}");
        }
    }
}
