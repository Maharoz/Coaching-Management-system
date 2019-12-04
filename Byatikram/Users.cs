using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byatikram.Properties
{
    public static class Users
    {
        private static string _userId = "";

        public static string UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }

        private static string _email = "";

        public static string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private static string _name = "";

        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
