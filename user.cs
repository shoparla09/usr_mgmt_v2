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

        public string getPassWord()
        {
            return password;
        }

        public string getEmail()
        {
            return email;
        }

        public string getAddress()
        {
            return address;
        }

        public string getPhone()
        {
            return phone;
        }

        public void setUsername(string a)
        {
             this.username = a;
        }

        public void setPassWord(string b)
        {
            this.password = b;
        }

        public void setEmail(string c)
        {
             this.email = c;
        }

        public void setAddress(string d)
        {
            this.address = d;
        }

        public void setPhone(string e)
        {
            this.phone = e;
        }
        public void GetUserData()
        {
            Console.WriteLine(this.username, this.password, this.email, this.address, this.phone);
        }
    }
}
