namespace Participation_Logic_and_Loops_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string playerName = "adventurer";
            string userChoice = "NONE";

            //Start of Program
            Console.WriteLine("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names\n\n");
            Console.WriteLine("Wait... I don't actually know your name");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            //Grab some user input
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

            //Continuing the story
            Console.WriteLine("" +
                "We approach a clearing in the jungle\n" +
                "There seems to be a big bear sleeping to the left... \n" +
                "And a cave entrance to the right.\n"
                );

            //Using narrator to talk
            Console.WriteLine("Which path do you choose?");
            Console.WriteLine("Type 'left' to choose the path and go left or type 'right' to choose the cave and go right.");

            //Grab some user input
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou choose: " + userChoice + "\n");

            //Select our path
            if(userChoice == "left")
            {
                //To go to the left
                Console.WriteLine("You take the path to the left. It leads you to the sleeping big bear. Be careful!");

            }else if (userChoice == "right")
            {
                //To go to the right
                Console.WriteLine("You take the path to the right. It leads you to a cave. You're safe now.");
            }
            else
            {
                //Oh no! the user typed in something else.
                userChoice = "NONE";

                while (userChoice != "left" && userChoice != "right" && userChoice != "up")
                {
                    Console.WriteLine("Please enter either 'left', 'right', or our now super secret answer of 'up'.");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("\nYou chose: " + userChoice + "\n");
                } 
                if (userChoice == "left")
                {
                    //To go to the left
                    Console.WriteLine("You take the path to the left. It leads you to the sleeping big bear. Be careful!");
                }
                else if (userChoice == "right")
                {
                    //To go to the right
                    Console.WriteLine("You take the path to the right. It leads you into a cave. You're safe now.");
                } 
                else if (userChoice == "up")
                {
                    //Easter Egg
                    Console.WriteLine("'up' seriously? 'up'!? How can we go up? UP YOURS! |_(O_O)_/ **Flips the keyboard** CLOSE THE PROGRAM!");
                }
                else
                {
                    Console.WriteLine("I honestly don't know how you got here. Congrats.");
                }
            }
        }
    }
}
