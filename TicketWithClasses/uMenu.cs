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

            /*switch (userChoice)
            {
                case "1":
                    writeFile();
                    break;
                case "2":
                    readFile();
                    break;
                case "3":
                    System.Environment.Exit(0);
                    break;
            }*/
        }

        public string getuserChoice()
        {
            return userChoice;
        }

    }
}