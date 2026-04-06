using System;
using System.Collections.Generic;
using System.Text;

namespace usr_mgmt_v2
{
    class Program
    {
        static void Main(string[] args)
        {

            menu menu = new menu();
            int Showoption = menu.ShowMenu();

            

            List<user> users = new List<user>();

            users.Add(new user(username: "dan", password: "7819", email: "email", address: "1313GP", phone: "0622378"));
            users.Add(new user(username: "cristi", password: "0128", email: "email", address: "1313GP", phone: "0622452"));

            while (Showoption < 5)
            {
                switch (Showoption)
                {
                    case 1:
                        Console.Clear();
                        menu.Showusers(users);
                        Console.ReadLine();

                        Showoption = menu.ShowMenu();

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("add new user");
                      
                        users.Add(menu.adduser());

                        Showoption = menu.ShowMenu();

                        break;

                    case 3:
                        Console.Clear();
                        menu.Showusers(users);
                        int usrNo;

                        do
                        {
                            usrNo = menu.GetInput("Select the user to update: ");
                        }
                        while (usrNo - 1 >= users.Count);

                        user user = users[usrNo - 1];
                        Console.WriteLine($"[1] Username:   {user.getUsername()}");
                        Console.WriteLine($"[2] Password:   {user.getPassWord()}");
                        Console.WriteLine($"[3] Email:      {user.getEmail()}");
                        Console.WriteLine($"[4] Address:    {user.getAddress()}");
                        Console.WriteLine($"[5] Phone:      {user.getPhone()}");

                        int opt = menu.GetInput("Select item: ");
                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine($"Current value: {user.getUsername()}");
                                Console.WriteLine("set new username: ");
                                string gebruikersnaam = Console.ReadLine();
                                user.setUsername(gebruikersnaam);

                                break;
                            case 2:
                                Console.WriteLine($"Current value: {user.getPassWord()}");
                                Console.WriteLine("set new password: ");
                                string wachtwoord = Console.ReadLine();
                                user.setPassWord(wachtwoord);
                                break;
                            case 3:
                                Console.WriteLine($"Current value: {user.getEmail()}");
                                Console.WriteLine("set new email: ");
                                string email = Console.ReadLine();
                                user.setEmail(email);
                                break;
                            case 4:
                                Console.WriteLine($"Current value: {user.getAddress()}");
                                Console.WriteLine("set new adress: ");
                                string adress = Console.ReadLine();
                                user.setAddress(adress);
                                break;
                            case 5:
                                Console.WriteLine($"Current value: {user.getPhone()}");
                                Console.WriteLine("set new PhoneNumber: ");
                                string telefoonnummer = Console.ReadLine();
                                user.setPhone(telefoonnummer);
                                break;
                            default:
                                Console.WriteLine("Invalid option!");
                                menu.ShowMenu();
                                break;
                        }

                        Console.WriteLine($"[1] Username:   {user.getUsername()}");
                        Console.WriteLine($"[2] Password:   {user.getPassWord()}");
                        Console.WriteLine($"[3] Email:      {user.getEmail()}");
                        Console.WriteLine($"[4] Address:    {user.getAddress()}");
                        Console.WriteLine($"[5] Phone:      {user.getPhone()}");

                        Console.ReadLine();
                        Showoption = menu.ShowMenu();
                        break;

                    case 4:
                        Console.Clear();
                        menu.Showusers(users);

                        int DeleteUser = menu.GetInput("Select a user: ");
                        users.RemoveAt(DeleteUser - 1);

                        Showoption = menu.ShowMenu();

                        break;

                    default:
                        Console.WriteLine("no valid option was chosen!");
                        break;
                }
            }
        }  
    }
} 
