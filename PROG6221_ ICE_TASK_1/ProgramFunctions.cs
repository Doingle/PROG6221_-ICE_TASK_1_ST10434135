using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221__ICE_TASK_1
{
    internal class ProgramFunctions
    {

        //This is a new instance of the UserDatabase class
        private UserDatabase userDatabase = new UserDatabase();
        

        //...........................................................................................................................\\
        //This method allows the user to add a new member to the user database
        public void AddNewMember()
        {
            //These are the variables that store the user's name, phone number and age
            string name = null;
            string phoneNumber = null;
            string age = null;

            //A while loop that runs until the user decides to exit the program
            while (true)
            {
                Console.WriteLine("Please choose what information you would like to add:");
                Console.WriteLine("1. Add name");
                Console.WriteLine("2. Add phone number");
                Console.WriteLine("3. Add age");
                Console.WriteLine("4. Print a summary of your details");
                Console.WriteLine("5. Exit Application");

                string userInput = Console.ReadLine();

                //A switch case statement that allows the user to choose what information they would like to add, it ensures the user can enter the information in any order they choose
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Please enter the name of the member:");
                        name = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Please enter the phone number of the member:");
                        phoneNumber = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Please enter the age of the member:");
                        age = Console.ReadLine();
                        break;
                    case "4":
                        userDatabase.PrintUserDetailSummary();
                        break;
                    case "5":
                        Console.WriteLine("You have selected to exit the program");
                        return;
                    default:
                        Console.WriteLine("Invalid input, please enter a number between ''1'' and ''5''");
                        break;
                }

                //An if statement that checks if the user has entered all the required information, if they have, it adds the user to the user database, if not, it continues to prompt the user to enter the information
                if (name != null && phoneNumber != null && age != null)
                {
                    userDatabase.AddNewMember(name, phoneNumber, age);
                    name = null;
                    phoneNumber = null;
                    age = null;
                }
                
            }
        }
        //...........................................................................................................................\\
    }
}
//.................................................................................EOF...................................................................................................\\