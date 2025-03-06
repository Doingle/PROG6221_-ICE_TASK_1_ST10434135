using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PROG6221__ICE_TASK_1
{
    //This is a user class that stores the user's name, phone number and age
    internal class User
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Age { get; set; }
    }


    internal class UserDatabase
    {
        //This is a list that stores the user's information
        List<User> userDatabase = new List<User>();

        //...........................................................................................................................\\
        //This method adds a new member to the user database, it takes in the name, phone number and age of the user
        public void AddNewMember(string name, string phoneNumber, string age)
        {
            User newUser = new User
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Age = age
            };
            userDatabase.Add(newUser);
        }

        //...........................................................................................................................\\
        //This method prints a summary of the user's details
        public void PrintUserDetailSummary()
        {
            //An if statement that checks if the user database is empty, if it is, it prints an error message to the user
            if (userDatabase.Count > 0)
            {
                Console.WriteLine("User details summary:");
                Console.WriteLine("--------------------");

                //A foreach loop that iterates through the user database and prints the user's name, phone number and age
                foreach (var user in userDatabase)
                {
                    Console.WriteLine("Name: " + user.Name);
                    Console.WriteLine("Phone number: " + user.PhoneNumber);
                    Console.WriteLine("Age: " + user.Age);
                    Console.WriteLine("---------------------");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("User database not yet full, please input some information first.");
            }
        }
        //...........................................................................................................................\\
    }
}
//.................................................................................EOF...................................................................................................\\