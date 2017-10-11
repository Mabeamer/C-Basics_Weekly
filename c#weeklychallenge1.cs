using System;

namespace WeeklyChallenges
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // challenge one 
            Console.WriteLine("Hello World!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Moving to Challenge two.");
            // create a loading bar here
            Console.WriteLine("er sorry, What was your name?");
            // console readline reads from the user input
            string userName = Console.ReadLine();
            Console.WriteLine("Oh! Hello, " + userName + "!");
            // create loading bar
            System.Threading.Thread.Sleep(1000);


            //Challenge two
            Console.WriteLine("Alright, " + userName + " , I want you to enter a number enter a number 10 - 20");
            int userNumber;
            int savedNumber;
            userNumber = Convert.ToInt16(Console.ReadLine());
            try
            {
                savedNumber = userNumber;
                if(savedNumber < 10){
                    Console.WriteLine("That number is a little to small dont you think...");
                } else if(savedNumber >= 10 && savedNumber < 20){
                    Console.WriteLine("This is good enough, we'll remember you choice, " + userName);
                    //else if statement does not loop back to the start and continues on fix this
                }else if(savedNumber > 20){
                    Console.WriteLine("Way too big my man.");
                }
            }
            catch(Exception)
            {
				Console.WriteLine("please enter a valid number!");
            }
            //Console.WriteLine(savedNumber + " user number");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Okay your name is " + userName + " and your number is " + userNumber + " We'll keep this in our records for later...");
            System.Threading.Thread.Sleep(900);
            Console.WriteLine("moving to challenge three");
            System.Threading.Thread.Sleep(900);
            //Challenge three

            //two for loops one for height and one that fills with * kepe for later
            int i;
            string line = new String('x', 10);
            for (i = 0; i <= 5; i++){
                Console.WriteLine("*");
            }
        }
    }
}
