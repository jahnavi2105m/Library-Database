using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class User
    {
        private string username;
        private string password;

        public User()
        {
        }

        public void setUsername(string username)
        {
            this.username = username;
        }
        public string getUsername()
        {
            return this.username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return this.password;
        }
    }
}
