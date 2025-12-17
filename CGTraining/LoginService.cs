using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGTraining
{
    public class LoginService
    {
        public bool Login(string username, string password)
        {
            if (username == null || password == null)
                return false;
            return true; //checking cherry pick
        }
    }
}
