using System;

namespace TextAdventure
{
    public class CrossRoads
    {
        public static void Forest()
        {
            string option;
            Console.WriteLine(
                "THE INVITATION HAS PLANTED A SEED OF GREAT CURIOSITY AND TEMPTATION DEEP INSIDE OF YOU, AND IT GROWS WITH THE POWER OF A THOUSAND STORMS. YOU JUST HAVE TO GO TO THE PARTY.");
            Console.WriteLine("SURROUNDING THE HOUSE YOU SEE 3 DIFFERENT PATHS.");
            Console.WriteLine("NOW YOUR ADVENTURE BEGINS.");
            Console.WriteLine("Which way do you choose?");
            Console.WriteLine(
                "1. WEST. The path is filled with sharp thorns and big leafy bushes. Going through here doesn't seem like an easy deed.");
            Console.WriteLine(
                "2. NORTH. The narrow gravel path looks tidy and accessible. It does seem to lead deep into the dark, scary forest though... ");
            Console.WriteLine(
                "3. EAST. The ground seems wet and muddy. Good thing you happen to wear your favorite rain boots.");
            Console.Write("Option: ");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("YOU CHOOSE THE WESTERN PATH.");
                    Console.WriteLine(
                        "THE THICK BUSHES PROVE IMPOSSIBLE TO BREAK THROUGH EVEN WITH YOUR STRONG, MUSCULAR BODY");
                    Console.WriteLine("AND THE THORNS TEAR THROUGH YOUR CLOTHES, CUTTING INTO YOUR SKIN.");
                    Console.WriteLine("EXHAUSTED AND BLEEDING YOU REALIZE THAT GOING THIS WAY WAS AN IDIOTIC CHOICE.");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("YOU CHOOSE THE NORTHERN PATH.");
                    Console.WriteLine(
                        "FOG STARTS TO THICKEN AROUND YOU AND YOU SEEM TO MOVE DEEPER INTO THE DARKNESS.");
                    Console.WriteLine(
                        "WITH NO SOURCE OF LIGHT ANYWHERE YOU REALIZE YOU HAVE NO WAY OF MOVING FORWARD IN THE PITCH BLACK FOREST.");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("YOU CHOOSE THE EASTERN PATH.");
                    Console.WriteLine("THE MUDDY TERRAIN DOESN'T STAND A CHANCE AGAINST YOUR SHINY WELLINGTONS.");
                    Console.WriteLine("YOU ARRIVE AT A BIG NASTY SWAMP.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Swamp();
                    break;
                }
                default:
                {
                    Program.Error();
                    Forest();
                    break;
                }
            }
        }
        public static void Swamp()
        {
            string option;

            Console.WriteLine("YOU MADE IT TO ANOTHER CROSSROADS.");
            Console.WriteLine(
                "THE NAUSEATING STENCH OF THE SWAMP IS MAKING YOU FEEL FAINT. YOU HAVE TO GET OUT OF HERE QUICKLY.");
            Console.WriteLine("SURROUNDING THE SWAMP YOU SEE 3 DIFFERENT PATHS.");
            Console.WriteLine("Which way do you choose?");
            Console.WriteLine(
                "1. WEST. The muddy swamp water is flowing down this path that seems to be going downhill. You can't see where the road ends.");
            Console.WriteLine(
                "2. NORTH. The northern road is a steep, rocky uphill. It seems to be the most dry way though.");
            Console.WriteLine(
                "3. EAST. Between the trees you can see a small path leading away from the swamp. It seems narrow to get through due to the trees' sprawling twigs.");
            Console.Write("Option: ");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("YOU CHOOSE THE WESTERN PATH.");
                    Console.WriteLine("THE FURTHER DOWN THE ROAD YOU GO, THE HIGHER THE WATER RISES UP YOUR LEGS");
                    Console.WriteLine(
                        "AND BEFORE YOU KNOW IT YOU'RE STANDING SHOULDER DEEP IN THE FOUL SMELLING SWAMP LIQUID.");
                    Console.WriteLine(
                        "THESE BOOTS MIGHT HAVE BEEN MADE FOR WALKIN', BUT THEY CERTAINLY WEREN'T MADE FOR SWIMMING IN SWAMPS.");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("YOU CHOOSE THE NORTHERN PATH.");
                    Console.WriteLine("THE ROCKS AND GRAVEL MAKE YOUR WAY UP A CHALLENGING ENDEAVOUR.");
                    Console.WriteLine(
                        "THOUGH YOU STUMBLE AND FALL COUNTLESS OF TIMES, YOUR STUBBORN DETERMINATION GETS YOU TO THE TOP OF THE HILL.");
                    Console.WriteLine("AS YOU STAND PROUDLY AT THE TOP, THINKING ABOUT HOW STRONG AND BRAVE YOU ARE");
                    Console.WriteLine(
                        "REALITY HITS YOU AND YOU REALIZE YOU'RE STANDING AT THE ENTRANCE OF AN ABANDONED CEMETERY.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Cemetery();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("YOU CHOOSE THE EASTERN PATH.");
                    Console.WriteLine("YOU SEEM TO OVERESTIMATE YOUR PHYSICAL CAPABILITY ONCE AGAIN.");
                    Console.WriteLine(
                        "THE TWIGGY PATH PROVES TO BE JUST AS IMPOSSIBLE TO GET THROUGH AS THE THORNY PATH AT THE FIRST CROSSROADS.");
                    Console.WriteLine("YOU CURSE YOURSELF FOR NOT LEARNING FROM YOUR PAST MISTAKES.");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                default:
                {
                    Program.Error();
                    Swamp();
                    break;
                }
            }
        }
        public static void Cemetery()
        {
            string option;

            Console.WriteLine("YOU MADE IT TO ANOTHER CROSSROADS.");
            Console.WriteLine("THE AIR SUDDENLY FEEL COLDER THAN BEFORE, AND AN ICY GUST OF WIND EMBRACES YOU,");
            Console.WriteLine("CAUSING YOUR BODY SHIVER TO THE VERY CORE.");
            Console.WriteLine("YOU CAN SENSE SOMETHING EVIL LURKING CLOSE BY. BETTER HURRY OUT OF HERE.");
            Console.WriteLine("SURROUNDING THE CEMETERY YOU SEE 3 DIFFERENT PATHS.");
            Console.WriteLine("Which way do you choose?");
            Console.WriteLine(
                "1. WEST. Underneath some shrubbery you notice a small tunnel. There's a light at the end of it. Is that good or bad?");
            Console.WriteLine(
                "2. NORTH. You see a gate at the other side of the cemetery, but you have to walk through hundreds of rows of tombstones to get there.");
            Console.WriteLine(
                "3. EAST. The eastern path leads past a small cabin. Legend says there's a possessed priest living there...");
            Console.Write("Option: ");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("YOU CHOOSE THE WESTERN PATH.");
                    Console.WriteLine(
                        "YOUR OPTIMISTIC INTERPRETATION OF 'THE LIGHT AT THE END OF THE TUNNEL' SEEMED TO HAVE PAID OFF.");
                    Console.WriteLine(
                        "AFTER A FEW MINUTES OF CRAWLING THROUGH THE NARROW UNDERPASS, YOU SUDDENLY START TO FEEL THE WARMTH OF THE SUN");
                    Console.WriteLine("ON YOUR FACE AND THE GRASS AGAINST YOUR FINGERTIPS AS YOU EMERGE.");
                    Console.WriteLine("YOU ARRIVE AT A LAKE.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Lake();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("YOU CHOOSE THE NORTHERN PATH.");
                    Console.WriteLine(
                        "AS YOU MAKE YOUR WAY THROUGH THE DARK AND MISTY CHURCHYARD, LEGS TREMBLING AND TEETH CHATTERING,");
                    Console.WriteLine("YOU SEE SHADOWS RISING FROM THE TOMBSTONES.");
                    Console.WriteLine("SOON, YOU'RE SURROUNDED BY STRANGE GHOSTS AND WRAITHS.");
                    Console.WriteLine(
                        "GETTING THROUGH HERE WITH YOUR LIFE INTACT WOULD BE NOTHING SHORT OF A MIRACLE.");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("YOU CHOOSE THE EASTERN PATH.");
                    Console.WriteLine("YOU MOVE SILENTLY PAST THE CABIN, AS TO NOT ALERT THE ALLEGED PRIEST.");
                    Console.WriteLine("YOU ACCIDENTALLY KNOCK DOWN A TIN BUCKET HANGING ON THE SIDE OF THE WALL,");
                    Console.WriteLine("AND IT SMASHES DOWN TO THE ROCKY GROUND, CAUSING A LOUD CRASH.");
                    Console.WriteLine(
                        "BEFORE YOU CAN BLINK, THE PRIEST IS STANDING ON THE DOORSTEP WITH A SHOTGUN IN HIS HANDS.");
                    Console.WriteLine("(⌐■_■)--︻╦╤─");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                default:
                {
                    Program.Error();
                    Cemetery();
                    break;
                }
            }
        }
        public static void Lake()
        {
            string option;

            Console.WriteLine("YOU MADE IT TO ANOTHER CROSSROADS.");
            Console.WriteLine("THE ONLY WAY TO CONTINUE YOUR JOURNEY TO THE PARTY SEEMS TO BE THROUGH WATER TRAVEL.");
            Console.WriteLine("TO YOUR DELIGHT YOU SEE A TINY DINGHY TIED TO A POLE, AND YOU SWIFTLY JUMP ABOARD.");
            Console.WriteLine("AFTER ROWING FOR A WHILE YOU NOTICE THE LAKE SPLIT UP IN TO THREE DIFFERENT ROUTES.");
            Console.WriteLine(
                "THERE'S NO WAY OF KNOWING WHICH WAY TO CHOOSE, SINCE ALL THE ROUTES LEAD THROUGH TUNNELS, SO YOU CAN'T SEE WHAT'S ON THE OTHER SIDE.");
            Console.WriteLine("YOU REALIZE YOU WILL HAVE TO TAKE A SHOT IN THE DARK HERE AND HOPE FOR THE BEST.");
            Console.WriteLine("Which way do you choose?");
            Console.WriteLine("1. WEST.");
            Console.WriteLine("2. NORTH.");
            Console.WriteLine("3. EAST.");
            Console.Write("Option: ");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("YOU CHOOSE THE WESTERN PATH.");
                    Console.WriteLine(
                        "AS YOU MAKE YOUR WAY DOWN THE WESTERN ROUTE YOU SUDDENLY FEEL YOUR OAR GET STUCK ON SOMETHING?");
                    Console.WriteLine("TO YOUR HORROR, A LONG SLIMY TENTACLE IS WRAPPED AROUND IT.");
                    Console.WriteLine(
                        "LOOKING DOWN INTO THE DEEP BLUE SEA, YOU SEE A DARK FIGURE GET CLOSER AND CLOSER.");
                    Console.WriteLine("YOU HAVE AWOKEN THE KRAKEN!");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("YOU CHOOSE THE NORTHERN PATH.");
                    Console.WriteLine("THE SUN IS SHINING, THE BOAT IS FLOATING GENTLY DOWN THE STREAM,");
                    Console.WriteLine("AND YOU FEEL A SENSE OF PEACE FOR THE FIRST TIME SINCE YOUR JOURNEY BEGAN.");
                    Console.WriteLine("SMOOTH SAILING ALL THE WAY!");
                    Console.WriteLine("YOU ARRIVE AT THE DOCKS OF A SMALL TOWN.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Town();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("YOU CHOOSE THE EASTERN PATH.");
                    Console.WriteLine(
                        "THE DINGHY SUDDENLY STARTS TO SPEED UP, AND THE WAVES ARE GROWING BIGGER AND BIGGER.");
                    Console.WriteLine(
                        "AN ENORMOUS WATERFALL APPEARS IN FRONT OF YOU. GOING DOWN IT WOULD BE THE DEATH OF YOU.");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                default:
                {
                    Program.Error();
                    Lake();
                    break;
                }
            }
        }
        public static void Town()
        {
            string option;

            Console.WriteLine("YOU MADE IT TO ANOTHER CROSSROADS.");
            Console.WriteLine("YOU FINALLY ARRIVE IN TOWN, THE PARTY MUST BE CLOSE BY NOW!");
            Console.WriteLine("THE INVITATION DIDN'T SPECIFY AN ADDRESS FOR THE PARTY,");
            Console.WriteLine("BUT IT DID MENTION IT WAS GOING TO TAKE PLACE IN AN OLD INDUSTRIAL AREA.");
            Console.WriteLine("STANDING ON THE MAIN STREET CROSSING, THE ROAD SPLITS UP IN THREE DIRECTIONS.");
            Console.WriteLine("Which way do you choose?");
            Console.WriteLine("1. WEST.");
            Console.WriteLine("2. NORTH.");
            Console.WriteLine("3. EAST.");
            Console.Write("Option: ");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("YOU CHOOSE THE WESTERN PATH.");
                    Console.WriteLine(
                        "AS YOU MAKE YOUR WAY DOWN THE STREET SWEET, SWEET MUSIC STARTS FLOWING INTO YOUR EARS,");
                    Console.WriteLine(
                        "BASS STARTS POUNDING UNDER YOUR FEET AND FILLS YOU WHOLE BODY WITH THE URGE TO DANCE.");
                    Console.WriteLine(
                        "YOU FOLLOW THE ALLURING TUNES, UNTIL YOU ARRIVE OUTSIDE A BIG INDUSTRIAL COMPLEX.");
                    Console.WriteLine("YOU RECOGNIZE A SYMBOL ON THE DOOR THAT MATCHES THE ONE ONE THE INVITATION.");
                    Console.WriteLine("THIS MUST BE WHERE THE PARTY'S AT!");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Party.PartyExterior();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("YOU CHOOSE THE NORTHERN PATH.");
                    Console.WriteLine(
                        "AS YOU'RE STRUTTING DOWN THE STREET, FEELING COOL AND CONFIDENT, THE GROUND SUDDENLY DISAPPEAR UNDER YOUR FEET.");
                    Console.WriteLine(
                        "SINCE YOU WERE DAYDREAMING ABOUT THE AMAZING PARTY, YOU HAVEN'T PAID ATTENTION TO YOUR SURROUNDINGS,");
                    Console.WriteLine(
                        "AND YOU WALKED STRAIGHT ONTO A CONSTRUCTION SITE AND FELL DOWN A DEEP PIT. OUCH!!");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("YOU CHOOSE THE EASTERN PATH.");
                    Console.WriteLine(
                        "AFTER WALKING FOR A WHILE, YOU HEAR A CAR SLOWING DOWN BEHIND YOU, AND BLUE AND RED LIGHTS START FLASHING IN THE CORNER OF YOUR EYE.");
                    Console.WriteLine("'WHAT THE HELL DO YOU THINK YOU'RE DOING?' A VOICE ASKS YOU IN A SNIDE TONE.");
                    Console.WriteLine("APPARENTLY A COP THINKS YOU'RE LOITERING AND WANTS TO TAKE YOU IN TO CUSTODY.");
                    Console.WriteLine(
                        "YOU START RUNNING AS FAST AS YOU CAN, AND MANAGE TO ESCAPE POWER ABUSING COP, BUT YOU DON'T FEEL SAFE HERE ANYMORE.");
                    Console.WriteLine("You will have to turn back to the house and choose a different way.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Forest();
                    break;
                }
                default:
                {
                    Program.Error();
                    Town();
                    break;
                }
            }
        }
    }
}