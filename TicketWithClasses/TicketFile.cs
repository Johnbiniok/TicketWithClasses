using System.IO;

namespace TicketWithClasses
{
    public class TicketFile
    {
        private static int ticketID;
        private string summary = "";
        private string status = "";
        private string priority = "";
        private string submitter = "";
        private string assigned = "";
        private string watching = "";
        private string file = @"Tickets.csv";
        public TicketFile(string status, string summary, string priority, string submitter, string assigned, string watching)
        {
            ticketID = ticketID + 1;
            this.status = status;
            this.summary = summary;
            this.priority = priority;
            this.submitter = submitter;
            this.assigned = assigned;
            this.watching = watching;
            toFile();
        }

        private void toFile()
        {
            using FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write);
            using TextWriter tw = new StreamWriter(fs);

            tw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", ticketID, summary, status, priority, submitter,
                assigned, watching);
        }

    }
}