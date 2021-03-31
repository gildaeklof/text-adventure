using System;

namespace TextAdventure
{
    public class Party
    {
        public static void PartyExterior()
        {
            string option;

            Console.WriteLine("YOU WALK UP TO A LARGE WOODEN DOOR WITH A LARGE BRASS DOOR KNOCK");
            Console.WriteLine("AND A RUSTY SPEAKEASY. YOU LIFT THE HANDLE AND START KNOCKING.");
            Console.WriteLine("SUDDENLY THE HATCH IS OPENED AND YOU ARE MET WITH TWO EYES GLARING");
            Console.WriteLine("AT YOU.");
            Console.WriteLine("'PaASssSSwOOOorrd?'");
            Console.WriteLine("THE MAN BEHIND THE DOOR GRUNTS.");
            Console.WriteLine("What do you answer?");
            Console.Write("Option: ");
            option = Console.ReadLine().ToLower();
            Console.Clear();

            if (option == "rubber duck" || option == "rubberduck")
            {
                Console.WriteLine("'Aah, yes indeed! Ye may enter..'");
                Console.WriteLine("The man says and unlocks the door. It creaks loudly as it opens,");
                Console.WriteLine("and a warm light illuminates the street where you stand, and inside");
                Console.WriteLine("you can hear the uplifting tunes of the music more clearly, as well as");
                Console.WriteLine("people cheering. You enter the building...");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                Console.Clear();
                Program.WinGame();
            }

            else if (option == "duck")
            {
                Console.WriteLine("'Hmmm, close but not close enough! Rules are rules ye know.'");
                Console.WriteLine("The man grunts and closes the hatch.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Apparently, the party invitation in itself wasn't enough");
                Console.WriteLine("to gain entry to the festivities...");
                Console.WriteLine("Do you wish to try again, or will you go back to the house");
                Console.WriteLine("in search for more clues?");

                string choice;

                Console.WriteLine("1. Try again");
                Console.WriteLine("2. Go back to the house");
                Console.Write("Choice: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    PartyExterior();
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    House.Interior();
                }
                else
                {
                    Console.WriteLine("Please choose one of the given options.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    PartyExterior();
                }


            }
        }
    }
}