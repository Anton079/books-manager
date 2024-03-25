using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books_manager
{
    public class User
    {
        private string _id;
        private string _email;
        private string _password;
        private int _phone;

      //todo:constrcutorul de initialiazare
        public User(string Id, string Email, string Password, int Phone)
        {
            Id = id;
            Email = email;
            Password = password;
            Phone = phone;
        }

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int phone
        {
            get { return _phone; }
                
        }

        public string UserInfo()
        {
            string text = " ";
            text += "Id " + id + "\n";
            text += "Email " + email + "\n";
            text += "Password " + email + "\n";
            text += "Phone " + phone + "\n";
            return text;
        }
    }
}
