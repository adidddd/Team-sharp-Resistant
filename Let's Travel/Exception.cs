using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class AccountExistException : Exception
    {
        public AccountExistException(): base("Account Already Exists") { }
    }
}
