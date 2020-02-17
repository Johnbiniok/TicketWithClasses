using System;
using System.IO;

namespace TicketWithClasses
{
    class Program
    {
        public static string file = @"Tickets.csv";
        private static int ticketID = 0;

        static void Main(string[] args)
        {
            //assignticketNum();
            userMenu();





            /*


            switch (userChoice)
            {
                case "1":
                    do
                    {
                        Console.Write("Would you like to make an entry?(Y/N)");
                        userStart = Console.ReadLine();
                        String[] userFull = new string[7];
                        if (userStart.Equals("Y") || userStart.Equals("y"))
                        {
                            ticketID += 1;
                            Console.Write("Enter a summary: ");
                            summary = Console.ReadLine();
                            Console.Write("Enter a status: ");
                            status = Console.ReadLine();
                            Console.Write("Enter priority: ");
                            priority = Console.ReadLine();
                            Console.Write("Enter submitter name: ");
                            submitter = Console.ReadLine();

                            Console.Write("Names of assigned: ");
                            assigned = Console.ReadLine();

                            Console.Write("Name of watching: ");
                            watching = Console.ReadLine();


                            using (FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write))
                            {
                                using TextWriter tw = new StreamWriter(fs);

                                tw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", ticketID, summary, status, priority,
                                    submitter,
                                    assigned, watching);

                            }
                        }

                    } while (userStart.Equals("Y") || userStart.Equals("y"));

                    break;
                case "2":
                    if (File.Exists(file))
                    {
                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split(',');
                            // display array data
                            Console.WriteLine(
                                "{0}        {1}        {2}        {3}        {4}        {5}        {6}",
                                arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);

                        }

                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }

                    break;
                case "3":
                    System.Environment.Exit(0);
                    break;
            }
        } while (userChoice != "3");*/
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
            TicketFile tFile = new TicketFile();
            string summary = "";
            string status = "";
            string priority = "";
            string submitter = "";
            string assigned = "";
            var watching = "";
            string userStart;
            do
            {
                Console.Write("Would you like to make an entry?(Y/N)");
                userStart = Console.ReadLine();
                String[] userFull = new string[7];
                if (userStart.Equals("Y") || userStart.Equals("y"))
                {
                    ticketID += 1;
                    Console.Write("Enter a summary: ");
                    summary = Console.ReadLine();
                    Console.Write("Enter a status: ");
                    status = Console.ReadLine();
                    Console.Write("Enter priority: ");
                    priority = Console.ReadLine();
                    Console.Write("Enter submitter name: ");
                    submitter = Console.ReadLine();

                    Console.Write("Names of assigned: ");
                    assigned = Console.ReadLine();

                    Console.Write("Name of watching: ");
                    watching = Console.ReadLine();


                    using (FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write))
                    {
                        using TextWriter tw = new StreamWriter(fs);

                        tw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", ticketID, summary, status, priority,
                            submitter,
                            assigned, watching);

                    }
                }

            } while (userStart.Equals("Y") || userStart.Equals("y"));

        }

        static void readFile()
        {
            if (File.Exists(file))
            {
                // read data from file
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // convert string to array
                    string[] arr = line.Split(',');
                    // display array data
                    Console.WriteLine(
                        "{0}        {1}        {2}        {3}        {4}        {5}        {6}",
                        arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);

                }

            }
            else
            {
                Console.WriteLine("File does not exist");
            }

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





