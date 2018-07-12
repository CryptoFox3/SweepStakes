using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    class UserInterface
    {


   


        public void GetContestantInformation(Contestant contestant, int RegistrationNumber)
        {
            Console.Clear();
            Console.WriteLine($"Your registration number is: {contestant.RegistrationNumber}");
            Console.WriteLine("Please enter your first name:");
            contestant.FirstName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Your registration number is: {contestant.RegistrationNumber}");
            Console.WriteLine("Please enter your last name:");
            contestant.LastName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Your registration number is: {contestant.RegistrationNumber}");
            Console.WriteLine("Please enter your email address:");
            contestant.EmailAddress = Console.ReadLine();
            ConfirmInformation(contestant, RegistrationNumber);
            
        }

        public void ConfirmInformation(Contestant contestant, int RegistrationNumber) {
            Console.Clear();
            Console.WriteLine("Is the below information correct? Please type 'yes' or 'no'");
            Console.WriteLine($"First name: {contestant.FirstName} \nLast name: {contestant.LastName} \nEmail address: {contestant.EmailAddress}");
            string choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                Console.Clear();
                Console.WriteLine("Contestant added!");
                Console.ReadKey();
                return;
            }
            else if (choice == "no")
            {
                GetContestantInformation(contestant, RegistrationNumber);
                
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                ConfirmInformation(contestant, RegistrationNumber);
            }
        }

       public void DisplayWinner()
        {

        }

       



    }
}
