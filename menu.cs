using System;
using System.Collections.Generic;
using System.Text;

namespace usr_mgmt_v2
{
    internal class menu
    {
        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Available options:");
            Console.WriteLine("[1] List users");
            Console.WriteLine("[2] Add user");
            Console.WriteLine("[3] Edit user");
            Console.WriteLine("[4] Delete user");
            Console.WriteLine("[5] Exit application!");
            Console.Write("Choose an option: ");
            return GetInput();

        }
        public int GetInput()
        {
            int option;
            bool tp = Int32.TryParse(Console.ReadLine(), out option);
            while (tp == false)
            {
                Console.WriteLine("put in a valid option");
                tp = Int32.TryParse(Console.ReadLine(), out option);
            }
            return option;
        }

           public user adduser()
        {
            Console.Clear();
            Console.WriteLine("addUser");
            Console.WriteLine("username: "); string username = Console.ReadLine();
            Console.WriteLine("password: "); string password = Console.ReadLine();
            Console.WriteLine("email: "); string email = Console.ReadLine();
            Console.WriteLine("address: "); string address = Console.ReadLine();
            Console.WriteLine("PhoneNumber: "); string phonenumber = Console.ReadLine();

        user adduser = new user(
        username = username,
        password = password,
        email = email,
        address = address,
        phonenumber = phonenumber);

            return adduser;
        }
        public void Showusers(List<user> UserList)
        {
            if (UserList.Count == 0)
            {
                Console.WriteLine("There are no users availible");
            }
            else
            {
                for (int i = 0; i < UserList.Count; i++)
                {
                    Console.WriteLine(UserList[i].getUsername());
                }
            }
            Console.ReadLine();
        }
    }
}
