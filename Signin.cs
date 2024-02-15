using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class Signin
    {
        public string Authentication(string userName, string password)
        {
            string msg;
            if ((string.IsNullOrEmpty(userName)) || string.IsNullOrEmpty(password))
            {
                msg = "User name and password requiredd";
            }
            else
            {
                if ((userName == "admin") && (password == "admin@123"))
                {  
                    msg = "Authentication Pass";
                }
                 else
                {
                    msg = "Authentication Fail";
                }
            }
        return msg;
        }
}
}
