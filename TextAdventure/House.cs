using System;

namespace TextAdventure
{
    public class House
    {
         public static void house()
        {
            string option;

            Console.WriteLine("YOU CONTINUE TO TRY AND PRY THE DOOR OPEN BUT IT WONT GIVE.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Look around");
            Console.WriteLine("2. Give up and simply walk away");
            Console.WriteLine("3. Bash the door in");
            Console.Write("Option:");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("On the porch you see a flower pot, a rug that says ‘tuUuRN aaAwaAy’, and");
                    Console.WriteLine("a wooden chair.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    porch();
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
                case "3":
                {
                    Console.WriteLine("You take a couple of steps back and run towards the door and throw yourself");
                    Console.WriteLine("against it, but it won't budge.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    house();
                    break;
                }
                default:
                {
                    Program.error();
                    house();
                    break;
                }
            }
        }

        public static void porch()
        {
            string option;

            Console.WriteLine("What do you check?");
            Console.WriteLine("1. Flower pot");
            Console.WriteLine("2. The rug");
            Console.WriteLine("3. The chair");
            Console.Write("Option:");
            option = Console.ReadLine().ToLower();
            Console.Clear();

            switch (option)
            {
                case "1":
                case "pot":
                {
                    Console.WriteLine(
                        "You rummage through the flower pot but find nothing except for the wilted flowers and dirt.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    porch();
                    break;
                }
                case "2":
                case "rug":
                {
                    Console.WriteLine("You lift the rug and see a small brass key beneath it.");
                    Console.WriteLine("You pick it up and put it in the keyhole. When you twist");
                    Console.WriteLine("it, you hear a click and the door opens.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    interior();
                    break;
                }
                case "3":
                case "chair":
                {
                    Console.WriteLine("You lift up the chair but there's nothing beneath it.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    porch();
                    break;
                }
                default:
                {
                    Program.error();
                    porch();
                    break;
                }
            }
        }

        public static void interior()
        {
            string option;

            Console.WriteLine(
                "YOU OPEN THE DOOR AND ENTER THE BRICK HOUSE. THERE IS A SINGLE ROOM WITH A SLEEPING COT AND");
            Console.WriteLine(
                "A SMALL KITCHEN WITH FOOD LEFT ON THE STOVE, THE FIRE BENEATH HAS LONG BURNED OUT. THE ROOM");
            Console.WriteLine(
                "IS IN A DISARRAY… LOOKS LIKE SOMEONE HAVEN’T BEEN HERE FOR QUITE A WHILE AND HAVE LEFT IN A HURRY.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Look around");
            Console.WriteLine("2. Give up and simply walk away");
            Console.WriteLine("3. Bash the door in");
            Console.Write("Option:");
            option = Console.ReadLine().ToLower();
            Console.Clear();

            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("You close the door behind you and start perusing.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    searchHouse();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("You leave the house and walk towards forest.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    CrossRoads.Forest();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("The door it already open you dum-dum");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    interior();
                    break;
                }
                default:
                {
                    Program.error();
                    interior();
                    break;
                }
            }
        }

        public static void searchHouse()
        {
            string option;

            Console.WriteLine("YOU SEARCH THE HOUSE AND FIND AN ASSORTMENT OF OBJECTS. A SQUEAKY MOUSE TOY, ");
            Console.WriteLine("A LEFT HANDED HAMMER, A RUBBER CHICKEN, A MONKEY WRENCH AND A SWORD THAT GOES 'TING'.");
            Console.WriteLine("FOR SOME PECULIAR REASON, EVERY KNICK-KNACK IN THIS HOUSE IS GLUED TO THE SPOT -");
            Console.WriteLine("EXCEPT FOR A PAPER WITH SOMETHING SCRIBBLED ON IT");
            Console.WriteLine("Do you examine the paper?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. Leave it");
            Console.Write("Option:");
            option = Console.ReadLine().ToLower();
            Console.Clear();

            switch (option)
            {
                case "1":
                case "yes":
                {
                    Console.WriteLine("   _________________________________________");
                    Console.WriteLine("  / |                                       |");
                    Console.WriteLine(" /  |          ..---..                      |");
                    Console.WriteLine("/___|        .’  _    `.                    |");
                    Console.WriteLine("    |    __..’  (o)    :                    |");
                    Console.WriteLine("    |   `..__          ;                    |");
                    Console.WriteLine("    |        `.       /                     |");
                    Console.WriteLine("    |         ;      `..---...___           |");
                    Console.WriteLine("    |       .'                   `~-. .-‘)  |");
                    Console.WriteLine("    |     .                         ' _.'   |");
                    Console.WriteLine("    |     :                           :     |");
                    Console.WriteLine("    |     |                           '     |");
                    Console.WriteLine("    |      +                         J      |");
                    Console.WriteLine("    |        `._                   _.'      |");
                    Console.WriteLine("    |           `~—....___...---~'¨         |");
                    Console.WriteLine("    |   ____________________________________|___");
                    Console.WriteLine("    |  /                                       /");
                    Console.WriteLine("    |_/_______________________________________/");

                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    leaveHouse();
                    break;
                }
                case "2":
                case "leave it":
                {
                    Console.WriteLine("'Yeah, that can't be too important anyway' you think to yourself");
                    Console.WriteLine("as you exit the house.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    leaveHouse();
                    break;
                }
                default:
                {
                    Program.error();
                    searchHouse();
                    break;
                }

            }
        }

        public static void leaveHouse()
        {
            Console.WriteLine("Press 'Enter'");
            Console.ReadLine();
            Console.Clear();
            CrossRoads.Forest();
        }
    }
}