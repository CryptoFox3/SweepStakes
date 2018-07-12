using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    class UserInterface
    {


   


        public void GetContestantInformation(Contestant contestant)
        {
            Console.WriteLine($"Your registration number is: {contestant.RegistrationNumber}");
            Console.WriteLine("Please enter your first name:");
            contestant.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            contestant.LastName = Console.ReadLine();
            Console.WriteLine("Please enter your email address:");
            contestant.EmailAddress = Console.ReadLine();
            ConfirmInformation(contestant);
            
        }

        public Contestant ConfirmInformation(Contestant contestant) {
            Console.WriteLine("Is the below information correct? Please type 'yes' or 'no'");
            Console.WriteLine($"First name: {contestant.FirstName} \n Last name: {contestant.LastName} \n Email address: {contestant.EmailAddress}");
            string choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                return contestant;
            }
            else if (choice == "no")
            {
                GetContestantInformation(contestant);
                return
            }
            else
            {

            }


        }

       



    }
}
