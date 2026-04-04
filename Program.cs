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

            while (Showoption < 5)
            {
                switch (Showoption)
                {
                    case 1:
                        if (users.Count == 0)
                        {
                            Console.WriteLine("There are no users availible");
                        }
                        else
                        {
                            for (int i = 0; i < users.Count; i++)
                            {
                                Console.WriteLine(users[i].getUsername() );
                            }
                        }
                        Console.ReadLine();

                        Showoption = menu.ShowMenu();

                        break;

                    case 2:
                        Console.WriteLine("add new user");
                      
                        users.Add(menu.adduser());

                        Showoption = menu.ShowMenu();

                        break;

                    case 3:
                        Console.WriteLine("edit existing user");
                        Showoption = menu.ShowMenu();


                        break;

                    case 4:
                        Console.WriteLine("delete existing user");
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