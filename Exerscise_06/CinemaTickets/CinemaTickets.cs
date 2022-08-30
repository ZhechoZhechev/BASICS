using System;

namespace P06_CinemaTickets
{
    class Program
    {
        static void Main()
        {
            int studentTicketsSold = 0;
            int standardTicketsSold = 0;
            int kidTicketsSold = 0;

            int totalTicketsSold = 0;

            string input = "";

            while (input != "Finish")
            {
                input = Console.ReadLine();

                if (input == "Finish")
                {
                    break;
                }

                string filmTitle = input;

                int seatsAvailable = int.Parse(Console.ReadLine());

                int ticketsSoldForFilm = 0;

                while (ticketsSoldForFilm < seatsAvailable)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    ticketsSoldForFilm++;
                    totalTicketsSold++;

                    if (ticketType == "student")
                    {
                        studentTicketsSold++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicketsSold++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketsSold++;
                    }
                }

                double percFull = ticketsSoldForFilm / (seatsAvailable * 1.00) * 100;
                Console.WriteLine($"{filmTitle} - {percFull:f2}% full.");
            }

            Console.WriteLine($"Total tickets: {totalTicketsSold}");

            double percStudentTickets = studentTicketsSold / (totalTicketsSold * 1.00) * 100;
            double percStandardTickets = standardTicketsSold / (totalTicketsSold * 1.00) * 100;
            double percKidTickets = kidTicketsSold / (totalTicketsSold * 1.00) * 100;

            Console.WriteLine($"{percStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percKidTickets:f2}% kids tickets.");
        }
    }
}