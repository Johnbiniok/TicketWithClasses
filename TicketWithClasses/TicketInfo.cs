using System;

namespace TicketWithClasses
{
    public class TicketInfo
    {
        private string summary = "";
        private string status = "";
        private string priority = "";
        private string submitter = "";
        private string assigned = "";
        private string watching = "";
        private static int ticketID = 0;
        public TicketInfo()
        {
            ticketID = ticketID + 1;
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
        }

        public int getTicketID()
        {
            return ticketID;
        }
        public string getSummary()
        {
            return summary;
        }

        public string getStatus()
        {
            return status;
        }
        public string getPriority()
        {
            return priority;
        }

        public string getSubmitter()
        {
            return submitter;
        }

        public string getAssigned()
        {
            return assigned;
        }

        public string getWatching()
        {
            return watching;
        }
    }
}