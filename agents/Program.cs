using System;
using agents.model;
using agents.controller;
using agents.view;

namespace agents
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller(model, view);
        }
    }
}
