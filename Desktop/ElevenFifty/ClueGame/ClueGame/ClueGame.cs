using System;
using System.Collections.Generic;
using System.Text;

namespace ClueGame
{
    class ClueGame
    {
        public void Run()
        {


            Console.WriteLine(                                                                                                                                                                                               
                 "                                                                                                                                                                              \n" +                   
                 "                 MMMMMMMM               MMMMMMMMYYYYYYY       YYYYYYY   SSSSSSSSSSSSSSS TTTTTTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRRRRRRRR   YYYYYYY       YYYYYYY\n" +                   
                 "                 M:::::::M             M:::::::MY:::::Y       Y:::::Y SS:::::::::::::::ST:::::::::::::::::::::TE::::::::::::::::::::ER::::::::::::::::R  Y:::::Y       Y:::::Y\n" +                  
                 "                 M::::::::M           M::::::::MY:::::Y       Y:::::YS:::::SSSSSS::::::ST:::::::::::::::::::::TE::::::::::::::::::::ER::::::RRRRRR:::::R Y:::::Y       Y:::::Y\n" +                  
                 "                 M:::::::::M         M:::::::::MY::::::Y     Y::::::YS:::::S     SSSSSSST:::::TT:::::::TT:::::TEE::::::EEEEEEEEE::::ERR:::::R     R:::::RY::::::Y     Y::::::Y\n" +                   
                 "                 M::::::::::M       M::::::::::MYYY:::::Y   Y:::::YYYS:::::S            TTTTTT  T:::::T  TTTTTT  E:::::E       EEEEEE  R::::R     R:::::RYYY:::::Y   Y:::::YYY\n" +                   
                 "                 M:::::::::::M     M:::::::::::M   Y:::::Y Y:::::Y   S:::::S                    T:::::T          E:::::E               R::::R     R:::::R   Y:::::Y Y:::::Y\n" +                      
                 "                 M:::::::M::::M   M::::M:::::::M    Y:::::Y:::::Y     S::::SSSS                 T:::::T          E::::::EEEEEEEEEE     R::::RRRRRR:::::R     Y:::::Y:::::Y\n" +                       
                 "                 M::::::M M::::M M::::M M::::::M     Y:::::::::Y       SS::::::SSSSS            T:::::T          E:::::::::::::::E     R:::::::::::::RR       Y:::::::::Y\n" +                        
                 "                 M::::::M  M::::M::::M  M::::::M      Y:::::::Y          SSS::::::::SS          T:::::T          E:::::::::::::::E     R::::RRRRRR:::::R       Y:::::::Y\n" +                         
                 "                 M::::::M   M:::::::M   M::::::M       Y:::::Y              SSSSSS::::S         T:::::T          E::::::EEEEEEEEEE     R::::R     R:::::R       Y:::::Y\n" +                          
                 "                 M::::::M    M:::::M    M::::::M       Y:::::Y                   S:::::S        T:::::T          E:::::E               R::::R     R:::::R       Y:::::Y\n" +                          
                 "                 M::::::M     MMMMM     M::::::M       Y:::::Y                   S:::::S        T:::::T          E:::::E       EEEEEE  R::::R     R:::::R       Y:::::Y\n" +                          
                 "                 M::::::M               M::::::M       Y:::::Y       SSSSSSS     S:::::S      TT:::::::TT      EE::::::EEEEEEEE:::::ERR:::::R     R:::::R       Y:::::Y\n" +                          
                 "                 M::::::M               M::::::M    YYYY:::::YYYY    S::::::SSSSSS:::::S      T:::::::::T      E::::::::::::::::::::ER::::::R     R:::::R    YYYY:::::YYYY\n" +                       
                 "                 M::::::M               M::::::M    Y:::::::::::Y    S:::::::::::::::SS       T:::::::::T      E::::::::::::::::::::ER::::::R     R:::::R    Y:::::::::::Y\n" +                       
                 "                 MMMMMMMM               MMMMMMMM    YYYYYYYYYYYYY     SSSSSSSSSSAAASS       TTTTTTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEEEEEERRRRRRRR     RRRRRRR    YYYYYYYYYYYYY\n" +                       
                 "                                                                               A:::A        T:::::::::::::::::::::T\n" +                                                                              
                 "                                                                              A:::::A       T:::::::::::::::::::::T\n" +                                                                              
                 "                                                                             A:::::::A      T:::::TT:::::::TT:::::T\n" +                                                                              
                 "                                                                            A:::::::::A     TTTTTT  T:::::T  TTTTTT\n" +                                                                              
                 "                                                                           A:::::A:::::A            T:::::T\n" +                                                                                      
                 "                                                                          A:::::A A:::::A           T:::::T\n" +                                                                                      
                 "                                                                         A:::::A   A:::::A          T:::::T\n" +                                                                                      
                 "                                                                        A:::::A     A:::::A         T:::::T\n" +                                                                                      
                 "                                                                       A:::::AAAAAAAAA:::::A        T:::::T\n" +                                                                                      
                 "                                                                      A:::::::::::::::::::::A       T:::::T\n" +                                                                                      
                 "                                                                     A:::::AAAAAAAAAAAAA:::::A      T:::::T\n" +                                                                                      
                 "                                                                    A:::::A             A:::::A   TT:::::::TT\n" +                                                                                    
                 "                                                                   A:::::A               A:::::A  T:::::::::T\n" +                                                                                    
                 "                                                                  A:::::A                 A:::::A T:::::::::T\n" +                                                                                    
                 "    HHHHHHHHH     HHHHHHHHHIIIIIIIIIILLLLLLLLLLL            LLLLLLLLLLLA                 HHHHHHHHHTTTTTHHHHHHHHH     OOOOOOOOO     UUUUUUUU     UUUUUUUU   SSSSSSSSSSSSSSS EEEEEEEEEEEEEEEEEEEEEE\n" +
                 "    H:::::::H     H:::::::HI::::::::IL:::::::::L            L:::::::::L                  H:::::::H     H:::::::H   OO:::::::::OO   U::::::U     U::::::U SS:::::::::::::::SE::::::::::::::::::::E\n" +
                 "    H:::::::H     H:::::::HI::::::::IL:::::::::L            L:::::::::L                  H:::::::H     H:::::::H OO:::::::::::::OO U::::::U     U::::::US:::::SSSSSS::::::SE::::::::::::::::::::E\n" +
                 "    HH::::::H     H::::::HHII::::::IILL:::::::LL            LL:::::::LL                  HH::::::H     H::::::HHO:::::::OOO:::::::OUU:::::U     U:::::UUS:::::S     SSSSSSSEE::::::EEEEEEEEE::::E\n" +
                 "      H:::::H     H:::::H    I::::I    L:::::L                L:::::L                      H:::::H     H:::::H  O::::::O   O::::::O U:::::U     U:::::U S:::::S              E:::::E       EEEEEE\n" +
                 "      H:::::H     H:::::H    I::::I    L:::::L                L:::::L                      H:::::H     H:::::H  O:::::O     O:::::O U:::::D     D:::::U S:::::S              E:::::E\n" +             
                 "      H::::::HHHHH::::::H    I::::I    L:::::L                L:::::L                      H::::::HHHHH::::::H  O:::::O     O:::::O U:::::D     D:::::U  S::::SSSS           E::::::EEEEEEEEEE\n" +   
                 "      H:::::::::::::::::H    I::::I    L:::::L                L:::::L                      H:::::::::::::::::H  O:::::O     O:::::O U:::::D     D:::::U   SS::::::SSSSS      E:::::::::::::::E\n" +   
                 "      H:::::::::::::::::H    I::::I    L:::::L                L:::::L                      H:::::::::::::::::H  O:::::O     O:::::O U:::::D     D:::::U     SSS::::::::SS    E:::::::::::::::E\n" +   
                 "      H::::::HHHHH::::::H    I::::I    L:::::L                L:::::L                      H::::::HHHHH::::::H  O:::::O     O:::::O U:::::D     D:::::U        SSSSSS::::S   E::::::EEEEEEEEEE\n" +   
                 "      H:::::H     H:::::H    I::::I    L:::::L                L:::::L                      H:::::H     H:::::H  O:::::O     O:::::O U:::::D     D:::::U             S:::::S  E:::::E\n" +             
                 "      H:::::H     H:::::H    I::::I    L:::::L         LLLLLL L:::::L         LLLLLL       H:::::H     H:::::H  O::::::O   O::::::O U::::::U   U::::::U             S:::::S  E:::::E       EEEEEE\n" +
                 "    HH::::::H     H::::::HHII::::::IILL:::::::LLLLLLLLL:::::LL:::::::LLLLLLLLL:::::L     HH::::::H     H::::::HHO:::::::OOO:::::::O U:::::::UUU:::::::U SSSSSSS     S:::::SEE::::::EEEEEEEE:::::E\n" +
                 "    H:::::::H     H:::::::HI::::::::IL::::::::::::::::::::::L::::::::::::::::::::::L     H:::::::H     H:::::::H OO:::::::::::::OO   UU:::::::::::::UU  S::::::SSSSSS:::::SE::::::::::::::::::::E\n" +
                 "    H:::::::H     H:::::::HI::::::::IL::::::::::::::::::::::L::::::::::::::::::::::L     H:::::::H     H:::::::H   OO:::::::::OO       UU:::::::::UU    S:::::::::::::::SS E::::::::::::::::::::E\n" +
                 "    HHHHHHHHH     HHHHHHHHHIIIIIIIIIILLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL     HHHHHHHHH     HHHHHHHHH     OOOOOOOOO           UUUUUUUUU       SSSSSSSSSSSSSSS   EEEEEEEEEEEEEEEEEEEEEE\n" +
                 "                                                                                                                                                                                                 \n");                                                                                                                                                                                                

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hello Detective Gray. You've reached the Hill House at 7:30 p.m. as requested by Mr. Boddy." +
                " No one answered the bell,\nso you permitted yourself to walk in. Turns out, Mr. Boddy was blackmailing all of his guests," +
                " and one of them \ndiscovered his plans early. By the time you arrived, Mr. Boddy was dead and the guests had dispersed into" +
                " different \nrooms. Who is the killer? How did they kill him? You'll have to investigate the house and demand information about" +
                " his \nguests.\n");

            Console.WriteLine("As you walk into the Hill House you are greeted by an unknown voice:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I would welcome you to the Hill House, but this is not a good time. Are you sure this is the place for you?");
            Console.ResetColor();
            Console.ReadLine();
            Ballroom();

        }


        //BALLROOM
        private void Ballroom()
        {
            Console.Clear();
            Console.WriteLine("As the man speaks you notice someone lying on the floor, no movement.. no breathing. " +
                "A middle-aged man wearing a long \ngreen coat with dark brown hair stands" +
                " across the room, eyes focused on the body and back to you.\n \n" +
                "Do you:\n" +
                "A. Talk to Mr.Green\n" +
                "B. Investigate the body\n" +
                "C. Move to the Kitchen\n" +
                "D. Move to the Conservatory");

            string userInput = Console.ReadLine();
            string userChoice = userInput.ToUpper();
            if (userChoice == "A")
            {
                Console.WriteLine("\nMr.Green (Conniving and Religious):");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("WELL I DIDN'T DO IT! I'm being blackmailed all right. Mr.Boddy and I had a business arrangement. He was a great man.");
                Console.ResetColor();
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Ballroom();

            }
            else if (userChoice == "B")
            {
                Console.WriteLine("\nThe deceased appears to have been struck in the head with a heavy object. Body identified as the owner of Hill House,\nMr. Boddy.\n" +
                    "Press Enter to Continue");
                Console.ReadLine();
                Ballroom();
            }
            else if (userChoice == "C")
            {
                Kitchen();
            }
            else if (userChoice == "D")
            {
                Conservatory();
            }
            else
            {
                Console.WriteLine("User input unknown. Please press any key to continue: ");
                Console.ReadLine();
                Ballroom();
            }
        }

        //CONSERVATORY
        private void Conservatory()
        {
            Console.Clear();
            Console.WriteLine("You’ve entered the Conservatory. A tremendous man in a mustard pocket utility jacket and cargo pants towered" +
                " over \neverything, eyes scanning the room but he doesn’t seem to notice you. You see a revolver on a small table near \nthe elder.\n \n" +
                "Do you:\n" +
                "A. Talk to Colonel Mustard \n" +
                "B. Investigate the revolver \n" +
                "C. Move to the Ballroom\n" +
                "D. Move to the Library");

            string userInput = Console.ReadLine();
            string userChoice = userInput.ToUpper();
            if (userChoice == "A")
            {
                Console.WriteLine("\nColonel Mustard (Militant and Athletic):");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You can address me as Colonel Mustard. I just returned from a safari and decided to visit my dear friend, Mr.Boddy.");
                Console.ResetColor();
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Conservatory();

            }
            else if (userChoice == "B")
            {
                Console.WriteLine("\nThere is one bullet left in this gun.\n" +
                    "Press Enter to Continue");
                Console.ReadLine();
                Conservatory();
            }
            else if (userChoice == "C")
            {
                Ballroom();
            }
            else if (userChoice == "D")
            {
                Library();
            }
            else
            {
                Console.WriteLine("User input unknown. Please press any key to continue: ");
                Console.ReadLine();
                Conservatory();
            }
        }

        //KITCHEN
        private void Kitchen()
        {
            Console.Clear();
            Console.WriteLine("You’ve entered the Kitchen. An enormous kitchen with dedicated spaces for drinks and food, with their own fridges and \nequipment. " +
                "Everything is clean and in its place, except one large knife on the island in the center of the room.\n \n" +
                "Do you:\n" +
                "A. Investigate the Butcher Knife \n" +
                "B. Move to the Dining Room \n" +
                "C. Move to the Ballroom\n");

            string userInput = Console.ReadLine();
            string userChoice = userInput.ToUpper();
            if (userChoice == "A")
            {
                Console.WriteLine("\nHeavy-duty 6 to 8 inches long broad rigid blade. \n" +
                    "Press Enter to Continue");
                Console.ReadLine();
                Kitchen();

            }
            else if (userChoice == "B")
            {
                DiningRoom();
            }
            else if (userChoice == "C")
            {
                Ballroom();
            }
            else
            {
                Console.WriteLine("User input unknown. Please press any key to continue: ");
                Console.ReadLine();
                Kitchen();
            }
        }

        //LIBRARY
        private void Library()
        {
            Console.Clear();
            Console.WriteLine("You’ve entered the Library. An average-sized woman greets you to the Boddy family mansion and apologizes for the \ncircumstances. " +
                "She introduces herself as Blanche White, the maid of the manor. Behind her, a rope partially \nhangs off a \nmid-level shelf on a wall-to-wall bookcase.\n \n" +
                "Do you:\n" +
                "A. Talk to Mrs. White\n" +
                "B. Investigate the rope\n" +
                "C. Investigate the bookcase\n" +
                "D. Move to the Conservatory\n" +
                "E. Move to the Study\n");

            string userInput = Console.ReadLine();
            string userChoice = userInput.ToUpper();
            if (userChoice == "A")
            {
                Console.WriteLine("\nMrs. White (Dutiful and Domestic): \n" +
                    "I don’t want a scandal, do I? We had a very humiliating public confrontation. He was deranged. " +
                    "He was a lunatic! \nHe didn't actually seem to like me very much; he had threatened to kill me in public.\n" +
                    "Press Enter to Continue");
                Console.ReadLine();
                Library();

            }
            else if (userChoice == "B")
            {
                Console.WriteLine("\nDouble braided rope lightly used. \n" +
                    "Press Enter to Continue");
                Console.ReadLine();
                Library();
            }
            else if (userChoice == "C")
            {
                Console.WriteLine("\nYou notice a section that has scuff marks on the floors as though there was a door that swung wide " +
                    "open in front of it \nrepeatedly. You push on the wood and a swinging bookcase opens to reveal a long narrow hallway. As you " +
                    "walk down the \nhallway you are lead to the Kitchen.\n" +
                    "Press Enter to Continue \n");
                Console.ReadLine();
                Kitchen();
            }
            else if (userChoice == "D")
            {
                Conservatory();
            }
            else if (userChoice == "E")
            {
                Study();
            }
            else
            {
                Console.WriteLine("User input unknown. Please press any key to continue: ");
                Console.ReadLine();
                Ballroom();
            }

        }

        //DINING ROOM
        private void DiningRoom()
        {
            Console.Clear();
            Console.WriteLine("You’ve entered the Dining Room. Before you there is a long narrow table about 60 inches long; " +
                "layers of architectural\nlighting wash the walls and a statement chandelier hangs over more than half the table. " +
                "On top of the table,\na single candlestick with no candle to burn and a beautiful young woman in a red romper sitting " +
                "cross legged.\n \n" +
                "Do you:\n" +
                "A. Talk to Ms. Scarlet \n" +
                "B. Investigate the candlestick \n" +
                "C. Move to the Kitchen\n" +
                "D. Move to the Lounge");

            string userInput = Console.ReadLine();
            string userChoice = userInput.ToUpper();
            if (userChoice == "A")
            {
                Console.WriteLine("\nMs. Scarlet (Sultry and Beautiful):");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I’m... I'm really too devastated to talk, understand? Please... this isn’t a good time.");
                Console.ResetColor();
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                DiningRoom();

            }
            else if (userChoice == "B")
            {
                Console.WriteLine("\nAntique 19th century solid silver candlesticks in pristine condition; appears to have been recently polished.\n" +
                    "Press Enter to Continue");
                Console.ReadLine();
                DiningRoom();
            }
            else if (userChoice == "C")
            {
                Kitchen();
            }
            else if (userChoice == "D")
            {
                Lounge();
            }
            else
            {
                Console.WriteLine("User input unknown. Please press any key to continue: ");
                Console.ReadLine();
                DiningRoom();
            }

        }

        //STUDY
        private void Study()
        {
            {
                Console.Clear();
                Console.WriteLine("You’ve entered the Study. A man in his thirties wearing a plum colored suit jacket and black full " +
                    "frame glasses looks \nup at you from a desk covered in books, newspapers, and handwritten notes. On the floor, " +
                    "just in view from under the \ndesk, you spot a wrench.\n \n" +
                    "Do you:\n" +
                    "A. Talk to Professor Plum \n" +
                    "B. Investigate the wrench\n" +
                    "C. Move to the Library\n" +
                    "D. Move to the Hall");

                string userInput = Console.ReadLine();
                string userChoice = userInput.ToUpper();
                if (userChoice == "A")
                {
                    Console.WriteLine("\nProfessor Plum (Scatterbrained and Intelligent)");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Hi, I’m Professor Plum. Terrible, terrible tragedy. I’m looking for an academic journal Mr. Boddy and " +
                        "I wrote together. It’s here somewhere. He’d want me to have it.");
                    Console.ResetColor();
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                    Study();

                }
                else if (userChoice == "B")
                {
                    Console.WriteLine("\nThe wrench is industrial grade and heavy-weight.\n" +
                        "Press Enter to Continue");
                    Console.ReadLine();
                    Study();
                }
                else if (userChoice == "C")
                {
                    Library();
                }
                else if (userChoice == "D")
                {
                    Hall();
                }
                else
                {
                    Console.WriteLine("User input unknown. Please press any key to continue: ");
                    Console.ReadLine();
                    Study();
                }
            }
        }

        //HALL
        private void Hall()
        {
            {
                Console.Clear();
                Console.WriteLine("You enter a long hall within the Hill house. As you continue you're investigation you unfortunately " +
                    "find \nnothing of importance within this room.\n \n" +
                    "Do you:\n" +
                    "A. Move to the Lounge\n" +
                    "B. Move to the Study");

                string userInput = Console.ReadLine();
                string userChoice = userInput.ToUpper();
                if (userChoice == "A")
                {
                    Lounge();
                }
                else if (userChoice == "B")
                {
                    Study();
                }
                else
                {
                    Console.WriteLine("User input unknown. Please press any key to continue: ");
                    Console.ReadLine();
                    Hall();
                }

            }
        }

        // LOUNGE
        private void Lounge()
        {
            Console.Clear();
            Console.WriteLine("You’ve entered the Lounge. Elegant jazz notes and a soft hum in tune with the music fills the dimly lit room. " +
                "As you \nwalk in, the music stops and a tall, green-eyed, red-head in a blue dress stands up from behind a piano.\n \n" +
                "Do you:\n" +
                "A. Talk to Ms. Peacock \n" +
                "B. Investigate the piano\n" +
                "C. Move to the Dining Room\n" +
                "D. Move to the Hall ");

            string userInput = Console.ReadLine();
            string userChoice = userInput.ToUpper();
            if (userChoice == "A")
            {
                Console.WriteLine("\nMs. Peacock (Sinister and Political:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("That will be Ms. Peacock to you. Don’t you know a murderer is afoot in this house? " +
                    "Our lives are in danger, you \nbeatnik. Why are you wasting your time here talking to me? " +
                    "My life is an open book. I haven’t done anything wrong.");
                Console.ResetColor();
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Lounge();

            }
            else if (userChoice == "B")
            {
                Console.WriteLine("\nThere appears to be an extra foot pedal on the piano. You push it and an inconspicuous door on a " +
                    "wall covered with an \nelaborate mural slowly creaks open. A hallway materializes.");
                Console.ReadLine();
                Cellar();
            }
            else if (userChoice == "C")
            {
                DiningRoom();
            }
            else if (userChoice == "D")
            {
                Hall();
            }
            else
            {
                Console.WriteLine("User input unknown. Please press any key to continue: ");
                Console.ReadLine();
                Lounge();
            }
        }


        // CELLAR
        private void Cellar()
        {

            Console.Clear();
            Console.WriteLine("You’ve entered the hidden Cellar. After a long wooden staircase, you've arrived at the cellar. " +
                "The room is much \ncooler and more humid than the rest of the house. The walls were made of stone with built in " +
                "wooden wine racks. Against the \nstone wall on the floor, you see a pipe with what appears to be red fabric thread.\n \n " +
                "Do you:\n" +
                "A. Investigate the Lead Pipe \n" +
                "B. Investigate the Red Thread \n");

            string userInput = Console.ReadLine();
            string userChoice = userInput.ToUpper();
            if (userChoice == "A")
            {
                Console.WriteLine("\nDull grey lead pipe with a lot of dings and what appears to be blood and red fabric.\n" +
                    "Press Enter to Continue");
                Console.ReadLine();
                Cellar();

            }
            else if (userChoice == "B")
            {
                Console.WriteLine("\nScarlet red polyester blend fabric that reminds you of the dame in the dining room. \n" +
                    "Press Enter to Continue");
                Console.ReadLine();
                Conclusion();
            }
            else
            {
                Console.WriteLine("User input unknown. Please press any key to continue: ");
                Console.ReadLine();
                Cellar();
            }
        }

        private void Conclusion()
        {
            Console.Clear();
            Console.WriteLine("As you're walking out the cellar door, you see Ms. Scarlett again." +
                " You stared at Ms. Scarlet and advanced towards her \nslowly, now noticing the tear in the " +
                "lower right hem of her pants. You begin to read her rights, voice clear and eyes \nlocked on hers.\n");
            Console.WriteLine("Detective Grey:\n “You have the right to remain...” Ms. Scarlet interrupts.\n");
            Console.WriteLine("Ms. Scarlet:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I would've gotten away with it if it hadn't been for you, you meddling detective!\n");
            Console.ResetColor();
            Console.WriteLine("Congratulations on solving the Mystery at Hill House!");
            Console.ReadLine();
           
        }
    }
}
