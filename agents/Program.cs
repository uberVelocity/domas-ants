using System;

namespace agents
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent topolska = new Agent();
            Console.WriteLine("The age of the agent is " + topolska.Age);
            topolska.Age = 22;
            Console.WriteLine("Now his age is: " + topolska.Age);
        }
    }
}
