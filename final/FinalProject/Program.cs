using System;

class Program
{
    static void Main(string[] args)
    {
        UserRegistry registry = new UserRegistry();

        string userSelection;
        while (true)
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Quit");
            Console.WriteLine("Select an option");
            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                string userNameLogin;
                string emailLogin;
                Console.WriteLine("Enter your username");
                userNameLogin = Console.ReadLine();
                Console.WriteLine("Enter your email");
                emailLogin = Console.ReadLine();
                if(registry.IsUsernameTaken(userNameLogin) && registry.IsEmailTaken(emailLogin))
                {
                    string userSelection3;
                    Console.WriteLine("");
                    Console.WriteLine($"Welcome {userNameLogin}!!");
                    Console.WriteLine("1. Create a task");
                    Console.WriteLine("2. Edit a task");
                    Console.WriteLine("3. Mark a task as complete");
                    Console.WriteLine("4. Delete a task");
                    Console.WriteLine("5. Show all tasks");
                    Console.WriteLine("Select an option");
                    userSelection3 = Console.ReadLine();
                    if(userSelection3 == "1")
                    {
                        string project;
                        string title;
                        string description;
                        string deadLineString;
                        DateTime deadLine;
                        Console.WriteLine("Project");
                        project = Console.ReadLine();
                        Console.WriteLine("Title:");
                        title = Console.ReadLine();
                        Console.WriteLine("Description:");
                        description = Console.ReadLine();
                        Console.WriteLine("Deadline:");
                        deadLineString = Console.ReadLine();
                        deadLine = DateTime.Parse(deadLineString);
                    }

                }
                else
                {
                    Console.WriteLine("The username or email entered does not exist");
                }
            }
            else if (userSelection == "2")
            {
                string userSelection2;
                string userName;
                string email;
                Console.WriteLine("1. AdminUser");
                Console.WriteLine("2. NormalUser");
                Console.WriteLine("What type of user you need?");
                userSelection2 = Console.ReadLine();
                if(userSelection2 == "1")
                {
                    Console.WriteLine("Create a username");
                    userName = Console.ReadLine();
                    Console.WriteLine("Enter an email");
                    email = Console.ReadLine();
                    AdminUser adminUser1 = new AdminUser(userName, email);
                    registry.RegisterUser(adminUser1);
                }
            }
            else if (userSelection == "3")
            {
                break;
            }
        }
    }
}