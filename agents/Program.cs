using System;
using agents.model;
using agents.controller;
using agents.view;
using System.Diagnostics;

namespace agents
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int mapSize = GetMapInput();
            Debug.Assert(mapSize != 0);

            Model model = new Model(mapSize);
            View view = new View();
            Controller controller = new Controller(model, view);
        }

        private static int GetMapInput()
        {
            Console.Write("Please insert the map size (NxN): ");
            string temp = Console.ReadLine();
            int mapSize = Convert.ToInt32(temp);
            return mapSize;
        }
    }
}
