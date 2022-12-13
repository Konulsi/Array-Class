using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Class
{
    public class Account


    {
        public string username;
        public string password;


       public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void Login()
        {
            if (username == "Cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("emeliyyat ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password sehvdir");
            }
        }
	}
        
}


