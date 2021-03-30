using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTitle();
            House.house();
            House.porch();
            House.interior();
            House.searchHouse();
            House.leaveHouse();
            CrossRoads.Forest();
            CrossRoads.Swamp();
            CrossRoads.Cemetery();
            CrossRoads.Lake();
            CrossRoads.Town();
            Party.partyInterior();
            Party.partyExterior();
        }

        public static void GameTitle()
        {

            Console.WriteLine("Welcome to Adventure!!");
            Console.WriteLine("Press 'Enter' to begin");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void error()
        {
            Console.WriteLine("Please choose one of the given options.");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void first()
        {
            string option;

            Console.WriteLine("YOU ARE STANDING AT THE END OF A ROAD BEFORE A SMALL BRICK BUILDING.");
            Console.WriteLine("AROUND YOU IS A FOREST. A SMALL STREAM FLOWS OUT OF THE BUILDING");
            Console.WriteLine("AND DOWN A GULLY.");
            Console.WriteLine("How do you proceed? (press 1, 2 or 3 + 'Enter')");
            Console.WriteLine("1. Walk up to the house");
            Console.WriteLine("2. Look around you");
            Console.WriteLine("3. Take a nap");
            Console.Write("Option:");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("YOU BEGIN WALKING UP TO THE HOUSE, AND AS YOU GET CLOSER");
                    Console.WriteLine("YOU CAN SEE A MAILBOX.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    second();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("YOU SEE NOTHING ELSE AROUND YOU, EXCEPT FOR A MAILBOX");
                    Console.WriteLine("SITUATED NEXT TO THE HOUSE.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    second();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("YOU WAKE UP. AS YOU STAND UP, YAWNING, TO STRETCH OUT YOUR ARMS");
                    Console.WriteLine("YOU SPOT A MAILBOX OUTSIDE THE HOUSE.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    second();
                    break;
                }
                default:
                {
                    error();
                    first();
                    break;
                }
            }
        }


        public static void second()
        {

            string option;

            Console.WriteLine("YOU WALK UP TO THE MAILBOX AND SEE SOMETHING STICKING");
            Console.WriteLine("OUT OF IT.");

            Console.WriteLine("Do you check the mailbox? (Yes or No)");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("Option:");
            option = Console.ReadLine().ToLower();
            Console.Clear();

            switch (option)
            {
                case "1":
                case "y":
                case "yes":
                {
                    Console.WriteLine("You proceed to check the mailbox.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    third();
                    break;
                }
                case "2":
                case "n":
                case "no":
                {
                    Console.WriteLine("This is an adventure game, of course you look");
                    Console.WriteLine("in the mailbox, dummy!");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    third();
                    break;
                }
                default:
                {
                    error();
                    second();
                    break;
                }

            }
        }

        public static void third()
        {
            //string option;

            Console.WriteLine("YOU REACH OUT YOUR HAND TO GRAB THE THING STICKING OUT");
            Console.WriteLine("OF THE MAILBOX. IT'S A LETTER, YOU OPEN IT TO READ THE FOLLOWING:");
            Console.WriteLine("'Invitation '");
            Console.WriteLine("'Party invitation...'");
            Console.WriteLine("'Party invitation...'");
            Console.WriteLine("'Party invitation...'");
            Console.WriteLine("'Party invitation...'");
            Console.WriteLine(
                "YOU DECIDE TO KEEP THE LETTER EVEN THOUGH IT ISN'T ADDRESSED TO YOU. YOU NAUGHTY LIL' FELLA.");
            Console.WriteLine("Press 'Enter'");
            Console.ReadLine();
            Console.Clear();
            fourth();

            /*
            Console.WriteLine("How do you proceed?");
            Console.WriteLine("1. Put the letter in your pocket");
            Console.WriteLine("2. Put it back");
            Console.Write("Option:");
            option = Console.ReadLine().ToLower();
            Console.Clear();

            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("Inventory: Party Invitation");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    fourth();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    fourth();
                    break;
                }
                default:
                {
                    error();
                    third();
                    break;                       
                }

            }*/
        }

        public static void fourth()
        {
            string option;

            Console.WriteLine("YOU TAKE A DEEP BREATH AND WONDER WHAT YOU WILL DO NEXT...");
            Console.WriteLine("YOU'RE QUITE COLD AND YOU COULD MAYBE WARM UP INSIDE OF THE HOUSE,");
            Console.WriteLine("ON THE OTHER HAND, YOU ARE FILLED WITH WANDERLUST AND WOULD LIKE");
            Console.WriteLine("TO EXPLORE THAT DARK, GREEN AND VAST FOREST.");
            Console.WriteLine("Where do you go?");
            Console.WriteLine("1. Into the house");
            Console.WriteLine("2. Turn back and walk toward the forest");
            Console.Write("Option:");
            option = Console.ReadLine().ToLower();
            Console.Clear();

            switch (option)
            {
                case "1":
                case "house":
                {
                    Console.WriteLine(
                        "As you reach for the handle and turn the door knob, you realize the door is locked.");
                    Console.WriteLine("Typical!");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    House.house();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("You turn around to walk and you're now approaching the forest.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    CrossRoads.Forest();
                    break;
                }
                default:
                {
                    error();
                    fourth();
                    break;
                }
            }
        }

    }
}


//public static void win()