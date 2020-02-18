using System;

namespace TicketWithClasses
{
    public class uMenu
    {
        public string userChoice;
        public uMenu()
        {
            Console.WriteLine("1. Write File ");
            Console.WriteLine("2. Read File ");
            Console.WriteLine("3. Exit ");
            userChoice = Console.ReadLine();

        }

        public string getuserChoice()
        {
            return userChoice;
        }

    }
}