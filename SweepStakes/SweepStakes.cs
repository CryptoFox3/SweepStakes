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
            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("Please choose what you would like to do below");
            Console.WriteLine("'Add Contestant', 'Display Contestants', 'Draw Winner'");
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
                default:
                    MainMenu();
                    break;
            }
        }


        public void RegisterContestant()
        {
            Contestant contestant = new Contestant(RegistrationNumber);
            userInterface.GetContestantInformation(contestant);
            contestant.RegistrationNumber = RegistrationNumber;
            ContestantDictionary.Add(RegistrationNumber, contestant);
            RegistrationNumber++;
        }

        public void DisplayContestants()
        {
             foreach (int RegistrationNumber in ContestantDictionary)
                {
                        
                }

        }



        public int PickWinner()
        {
            Random random = new Random();
            int winner = random.Next(0, ContestantDictionary.Count); //MAKE RANDOM CLASS


            return winner;
        }






    }
}
