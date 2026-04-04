using System;
using System.Collections.Generic;
using System.Text;

namespace usr_mgmt_v2
{
    internal class user
    {
        private string username { get; set; }
        private string password { get; set; }
        private string email { get; set; }
        private string address { get; set; }
        private string phone { get; set; }

        public user(String username, String password, String email, String address, String phone)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.address = address;
            this.phone = phone;

        }
        public string getUsername()
        {
            return username;
        }

    }
}
