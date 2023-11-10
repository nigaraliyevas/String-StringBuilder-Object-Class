using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBilder_Object_Class.Models
{
    class Account
    {
        public string Username;
        public string Password;
        public void Login(string username,string password)
        {
            Username=username;
            Password=password;  
            if(username=="lorem123" && password == "123456*")
            {
                Console.WriteLine("Entered Succsessfully");
            }
            else
            {
                Console.WriteLine("Username or pasword is incorrect");
            }
        }
    }
}
