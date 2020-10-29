using System;
using System.Dynamic;

namespace forfra
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which nationality: ");
            string userNationality = TryAnswer();

            Console.Write("Which league: ");
            var userLeague = TryAnswer();
            //int userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Which club:  ");
            string userClub = TryAnswer();

            Console.WriteLine(" Nationality: " + userNationality + "\n League: " + userLeague + "\n Club: " + userClub);


            if (userClub == "flamengo" && userNationality == "brazil")
            {
                Console.WriteLine(" Diego Alves");
            }
            if (userClub == "psg" && userNationality == "france")
            {
                Console.WriteLine(" Kylian mbappe ");
            }
            if (userClub == "napoli" && userNationality == "italy")
            {
                Console.WriteLine(" Dries mertens ");
            }
        }
        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didnt type anything, please try again");
                return Console.ReadLine();
            }
            return answer;
        }

    }
}
/*
            var code = "";

            while (code != "secret")
            {

                Console.WriteLine("What is the pass code?");
                //var code = Console.ReadLine(); vi declarer var i toppen
                code = Console.ReadLine();

                /*if (code == "secret")
                {
                    Console.WriteLine("Authenticated"); Overflødigt, i og med når condition er met, brydes loop
                }
                if (code != "secret")
                {
                    Console.WriteLine("Not autenticated");
                }
            }
                    Console.WriteLine("Authenticated");
        } 
    }
} */
