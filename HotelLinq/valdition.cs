using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLinq
{
    internal class valdition
    {
        public static List<valdition> UserList = new List<valdition>();

        // make those fields public for accessibility
        public string Username;
        public string email;
        public string Password;
        public string rePassword;
        public int phone;
        public string adress;



        public valdition(string Username, string email, string Password, string rePassword, int phone, string adress)
        {
            // assign each fields with arguments from constructor
            this.Username = Username;
            this.email = email;
            this.Password = Password;
            this.rePassword = rePassword;
            this.phone = phone;
            this.adress = adress;

        }

        public static void AddUserToList(valdition user)
        {
            UserList.Add(user);
        }
    }
}
