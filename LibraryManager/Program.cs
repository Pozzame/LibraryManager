using System;

namespace LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var UI = new UserInterface(new Processor());
            UI.MainMenu();
        }
    }
}
