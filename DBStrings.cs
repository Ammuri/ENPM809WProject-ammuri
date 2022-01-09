using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wonderdrinks
{
    public static class DBStrings
    {
        public static string UserDBString
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student\Workspace\wonderdrinks\App_Data\UsersDB.mdf;Integrated Security=True";
            }
        }
        public static string DrinksDBString
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student\Workspace\wonderdrinks\App_Data\DrinkDB.mdf;Integrated Security=True";
            }
        }
    }
}