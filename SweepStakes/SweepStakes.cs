using System;
using System.Collections.Generic;
using System.Text;

namespace SweepStakes
{
    class SweepStakes
    {
        
        Dictionary<int, Contestant> ContestantDictionary = new Dictionary<int, Contestant>();
        UserInterface userInterface = new UserInterface();
        public int RegistrationNumber { get; set; }

        public SweepStakes()
        {
            RegistrationNumber = 1;
            MainMenu();
        }

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose what you would like to do below");
            Console.WriteLine("'Add Contestant', 'Display Contestants', 'Draw Winner', 'Exit'");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "add contestant":
                    RegisterContestant();
                    MainMenu();
                    break;
                case "display contestants":
                    DisplayContestants();
                    MainMenu();
                    break;
                case "draw winner":
                    PickWinner();
                    MainMenu();
                    break;
                case "exit":
                    EndSweepstakes();
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }
        }


        public void RegisterContestant()
        {
            Contestant contestant = new Contestant();
            contestant.RegistrationNumber = RegistrationNumber;
            userInterface.GetContestantInformation(contestant, RegistrationNumber);
            ContestantDictionary.Add(RegistrationNumber, contestant);
            RegistrationNumber++;
        }

        public void DisplayContestants()
        {
            foreach (KeyValuePair<int, Contestant> contestant in ContestantDictionary)
            {
                Console.WriteLine($"Contestant name: {contestant.Value.FirstName} {contestant.Value.LastName} Registration Number: {contestant.Value.RegistrationNumber}");
            }
            Console.ReadKey();

        }



        public int PickWinner()
        {
            Random random = new Random();
            int winner = random.Next(1, ContestantDictionary.Count); //MAKE RANDOM CLASS
            if (ContestantDictionary.ContainsKey(winner))
            {
                Contestant contestant = ContestantDictionary[winner];
                Console.WriteLine($"The winner is: {contestant.FirstName} {contestant.LastName}");
            }
            Console.ReadKey();
            return winner;
        }



        public void EndSweepstakes()
        {
            Console.Clear();
            Console.WriteLine($"The Sweepstakes has ended. \nWould you like to run Sweepstakes again? Type: Yes or No.");
            string choice = Console.ReadLine().ToLower();
            {
                switch (choice)
                {
                    case ("yes"):
                        RegistrationNumber = 1;
                        ContestantDictionary.Clear();
                        MainMenu();
                        break;
                    case ("no"):
                        Console.WriteLine("Thanks for playing...");
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        EndSweepstakes();
                        break;
                }


            }
        }
    }
}
