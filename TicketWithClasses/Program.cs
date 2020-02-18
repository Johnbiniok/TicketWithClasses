using System;
using System.IO;

namespace TicketWithClasses
{
    class Program
    {
        public static string file = @"Tickets.csv";

        static void Main(string[] args)
        {
            userMenu();

        }


        static void userMenu()
        {
            string userChoice = "";

            do
            {
                uMenu forUser = new uMenu();

                switch (forUser.getuserChoice())
                {
                    case "1":
                        writeFile();
                        break;
                    case "2":
                        readFile();
                        break;
                    case "3":
                        userChoice = "3";
                        System.Environment.Exit(0);
                        break;
                }
            } while (userChoice != "3");
        }

        static void writeFile()
        {
            string userStart;
            do
            {
                Console.Write("Would you like to make an entry?(Y/N)");
                userStart = Console.ReadLine();
                if (userStart.Equals("Y") || userStart.Equals("y"))
                {
                    TicketInfo tiNew = new TicketInfo();

                    TicketFile tFile = new TicketFile(tiNew.getStatus(), tiNew.getSummary(), tiNew.getPriority(), tiNew.getSubmitter(), tiNew.getAssigned(), tiNew.getWatching());

                }

            } while (userStart.Equals("Y") || userStart.Equals("y"));

        }

        static void readFile()
        {
            retrieveFile retrieveFile = new retrieveFile();
        }
    }

    class Ticket
        {
            public int Number { get; set; }

            public string description { get; set; }

            public string priority { get; set; }

            public DateTime ExpirationDate { get; set; }

            public bool isValid()
            {
                return true;
            }
        }

        class TicketManager
        {
            Ticket ticket = new Ticket();
        }

}





