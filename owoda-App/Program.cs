using System;

namespace owoda_App
{
    class Program
    {

        static void Main(string[] args)
        {

            int dailyTicket = 100;
            int monthlyTicket = 50;
            int ticketNumber;
            int monthDays = 30;
            double chairmanCut;
            int total;
            Console.WriteLine(@"Press 1 and Enter Key to buy a daily ticket.
Press 2  and Enter Key to buy a monthly ticket.");
            string input = Console.ReadLine();
            if(input.Equals("1"))
            {
                Console.WriteLine("indicate speculated time frame in days");
                string timeFrame = Console.ReadLine();
                if (Int32.TryParse(timeFrame, out  int convertedTimeFrame))
                {
                    Random random = new Random();
                    ticketNumber = random.Next();
                    total = convertedTimeFrame * dailyTicket;
                    chairmanCut = 0.65 * total;
                    Console.WriteLine("Your total is {0} and the chairman's cut is {1} with ticket number {2}", total,chairmanCut,ticketNumber);

                }else
                {
                    Console.WriteLine("invalid input");
                }
            }else if (input.Equals("2"))
            {
                Console.WriteLine("indicate speculated time frame in months");
                string timeFrame = Console.ReadLine();
                if (Int32.TryParse(timeFrame, out int convertedTimeFrame))
                {
                    Random random = new Random();
                    ticketNumber = random.Next();
                    total = convertedTimeFrame * monthlyTicket*monthDays;
                    chairmanCut = 0.65 * total;
                    Console.WriteLine("Your total is {0} and the chairman's cut is {1} with ticket number {2}", total, chairmanCut, ticketNumber);

                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.Read();
        }
    }
}
