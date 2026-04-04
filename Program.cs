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
            menu.ShowMenu();

            int Showoption = menu.GetInput();

            List<user> users = new List<user>();

            switch (Showoption)
            {
                case 1:
                    if (users.Count = 0)
                    {
                        Console.WriteLine("There are no users availible");
                    } 
                    else
                    {
                        for (int i = 0; i < users.count; i++) ;
                    }
                    break;

                default:
                    Console.WriteLine("add new user");
                    break;

                case 2:
                    Console.Clear();

                    users.Add(menu.adduser());


                    if (KeyData == Keys.M)
                    {
                        option = menu.ShowMenu();
                    }
                    break;

                    Console.WriteLine("no valid option was chosen!");
                    break;

                case 3:
                    Console.WriteLine("edit existing user");
                    

                   
                    break;

                case 4:
                    Console.WriteLine("delete existing user");
                  

                
                    Console.WriteLine("no valid option was chosen!");
                    break;
            }      

        }
        
    }
}