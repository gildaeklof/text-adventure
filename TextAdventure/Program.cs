using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTitle();
            House.Building();
            House.Porch();
            House.Interior();
            House.SearchHouse();
            House.LeaveHouse();
            CrossRoads.Forest();
            CrossRoads.Swamp();
            CrossRoads.Cemetery();
            CrossRoads.Lake();
            CrossRoads.Town();
            Party.PartyExterior();
            WinGame();
        }

        public static void GameTitle()
        {
            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine("█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Console.WriteLine("█░░║║║╠─║─║─║║║║║╠─░░█");
            Console.WriteLine("█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.WriteLine("WELCOME TO THE PURSUIT OF A RAVE!!");
            Console.WriteLine("Press 'Enter' to begin!");
            Console.ReadLine();
            Console.Clear();
            First();
        }

        public static void Error()
        {
            Console.WriteLine("Please choose one of the given options.");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void First()
        {
            string option;

            Console.WriteLine("░░░░░░░░░░░░░░░░▄▓▄");
            Console.WriteLine("░░░░▄█▄░░░░░░░░▄▓▓▓▄");
            Console.WriteLine("░░▄█████▄░░░░░▄▓▓▓▓▓▄");
            Console.WriteLine("░▀██┼█┼██▀░░░▄▓▓▓▓▓▓▓▄");
            Console.WriteLine("▄▄███████▄▄▄▄▄▄▄▄█▄▄▄▄");

            Console.WriteLine("YOU ARE STANDING AT THE END OF A ROAD BEFORE A SMALL BRICK BUILDING.");
            Console.WriteLine("AROUND YOU IS A FOREST. A SMALL STREAM FLOWS OUT OF THE BUILDING");
            Console.WriteLine("AND DOWN A GULLY.");
            Console.WriteLine("How do you proceed? (press 1, 2 or 3 + 'Enter')");
            Console.WriteLine("1. Walk up to the house");
            Console.WriteLine("2. Look around you");
            Console.WriteLine("3. Take a nap");
            Console.Write("Option: ");
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
                    Second();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("YOU SEE NOTHING ELSE AROUND YOU, EXCEPT FOR A MAILBOX");
                    Console.WriteLine("SITUATED NEXT TO THE HOUSE.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Second();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("YOU WAKE UP. AS YOU STAND UP, YAWNING, TO STRETCH OUT YOUR ARMS");
                    Console.WriteLine("YOU SPOT A MAILBOX OUTSIDE THE HOUSE.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Second();
                    break;
                }
                default:
                {
                    Error();
                    First();
                    break;
                }
            }
        }


        public static void Second()
        {

            string option;

            Console.WriteLine("YOU WALK UP TO THE MAILBOX AND SEE SOMETHING STICKING");
            Console.WriteLine("OUT OF IT.");

            Console.WriteLine("Do you check the mailbox? (Yes or No)");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("Option: ");
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
                    Third();
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
                    Third();
                    break;
                }
                default:
                {
                    Error();
                    Second();
                    break;
                }

            }
        }

        public static void Third()
        {
            string option;

            Console.WriteLine("YOU REACH OUT YOUR HAND TO GRAB THE THING STICKING OUT");
            Console.WriteLine("OF THE MAILBOX. IT'S A LETTER, YOU OPEN IT TO READ THE FOLLOWING:");
            Console.WriteLine("");
            Console.WriteLine("    _________________________________________________________");
            Console.WriteLine("(O)==)><><><><><><><><><><><><><><><><><><><><><><><><><><><)==(O)");
            Console.WriteLine("    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''' ");
            Console.WriteLine("    (                                                      (  ");
            Console.WriteLine("     )                                                      ) ");
            Console.WriteLine("    (                  Hear Ye, Hear Ye!                   (  ");
            Console.WriteLine("    |                                                      |  ");
            Console.WriteLine("    |       Let it be known that on this very night        |  ");     
            Console.WriteLine("    (       we shall be having a feast in town,            (  ");
            Console.WriteLine("     )      and you are cordially invited to partake        ) ");
            Console.WriteLine("    (       in the festivities.                            (  ");
            Console.WriteLine("    |                                                      |  ");
            Console.WriteLine("    |       You will find the address below.               |  ");
            Console.WriteLine("    (	   (terms and conditions apply)                   (  ");
            Console.WriteLine("     )	                                                   ) ");
            Console.WriteLine("    (       The big house,                                 (  ");
            Console.WriteLine("    |       Industrial area,                	           |");
            Console.WriteLine("    |       Town                                           |  ");
            Console.WriteLine("    (                                                      (  ");
            Console.WriteLine("     )                                                      ) ");
            Console.WriteLine("    (______________________________________________________(  ");
            Console.WriteLine("(O)==)><><><><><><><><><><><><><><><><><><><><><><><><><><><)==(O)");
            Console.WriteLine("    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''");

            Console.WriteLine("YOU DECIDE TO KEEP THE LETTER EVEN THOUGH IT ISN'T ADDRESSED TO YOU. YOU NAUGHTY LIL' FELLA.");
            Console.WriteLine("Press 'Enter' to continue");
            Console.Clear();
            Fourth();
        }

        public static void Fourth()
        {
            string option;

            Console.WriteLine("YOU TAKE A DEEP BREATH AND WONDER WHAT YOU WILL DO NEXT...");
            Console.WriteLine("YOU'RE QUITE COLD AND YOU COULD MAYBE WARM UP INSIDE OF THE HOUSE,");
            Console.WriteLine("ON THE OTHER HAND, YOU ARE FILLED WITH WANDERLUST AND WOULD LIKE");
            Console.WriteLine("TO EXPLORE THAT DARK, GREEN AND VAST FOREST.");
            Console.WriteLine("Where do you go?");
            Console.WriteLine("1. Into the house");
            Console.WriteLine("2. Turn back and walk toward the forest");
            Console.Write("Option: ");
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
                    House.Building();
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
                    Error();
                    Fourth();
                    break;
                }
            }
        }
        public static void WinGame()
        {
            Console.Clear();
            Console.WriteLine("────█▀█▄▄▄▄─────██▄");
            Console.WriteLine("────█▀▄▄▄▄█─────█▀▀█");
            Console.WriteLine("─▄▄▄█─────█──▄▄▄█");
            Console.WriteLine("██▀▄█─▄██▀█─███▀█");
            Console.WriteLine("─▀▀▀──▀█▄█▀─▀█▄█▀");

            Console.WriteLine("YOU GOT IN TO THE PARTY AFTER YOUR LONG, TIRING JOURNEY.");
            Console.WriteLine("IT TURNED OUT TO BE THE BEST NIGHT OF YOUR WHOLE ENTIRE LIFE,");
            Console.WriteLine("AND YOU DANCED UNTIL DAWN, SURROUNDED BY A BUNCH OF AWESOME PEOPLE,");
            Console.WriteLine("WHO HAPPENED TO BE THE LIFELONG FRIENDS YOU ALWAYS DREAMED OF.");
            Console.WriteLine("CONGRATULATIONS, YOU WON THE GAME!!");

            Console.WriteLine("████████████████████████");
            Console.WriteLine("█▄─▄███─▄▄─█▄─█─▄█▄─▄▄─█");
            Console.WriteLine("██─██▀█─██─██─█─███─▄█▀█");
            Console.WriteLine("▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀");

            Console.WriteLine("Press 'Enter' to play again!");
            Console.ReadLine();
            Console.Clear();
            GameTitle();
        }

    }
}