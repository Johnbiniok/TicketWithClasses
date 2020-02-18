using System;
using System.IO;

namespace TicketWithClasses
{
    public class retrieveFile
    {
        public static string file = @"Tickets.csv";
        public retrieveFile()
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
}