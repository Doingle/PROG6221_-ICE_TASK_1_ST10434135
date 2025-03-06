using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221__ICE_TASK_1
{
    internal class MenuNavigation
    {

        //This is a new instance of the ProgramFunctions class
        ProgramFunctions programFunctions = new ProgramFunctions();

        //...........................................................................................................................\\
        //This method displays the menu to the user and allows them to navigate through the program
        public void MenuNavigationMethod()
        {
            Console.WriteLine("Welcome to the Milnerton Aquatic Club User Database");
            Console.WriteLine("Please select an option from the menu below:");
            Console.WriteLine("");
            Console.WriteLine("1.Add new member");
            Console.WriteLine("2. Exit the program");
            Console.WriteLine("Please enter the number of the option you would like to select:");
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("");
            
            string userInput = Console.ReadLine();

            //A switch case statement that allows the user to choose what they would like to do
            switch (userInput)
            {
                case "1":
                programFunctions.AddNewMember();
                    break;
                case "2":
                    Console.WriteLine("Program has been Closed");
                    break;
                default:
                    Console.WriteLine("Invalid input, please enter either a ''1'' or a ''2''");
                    break;

            }
        }
        //...........................................................................................................................\\

    }
}
//.................................................................................EOF...................................................................................................\\
