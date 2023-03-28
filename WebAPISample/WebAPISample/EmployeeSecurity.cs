using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPISampleDAL;

namespace WebAPISample
{
    public class EmployeeSecurity
    {
        public static bool Login(string userName, string password)
        {
            using(SQLPracticeEntities context = new SQLPracticeEntities())
            {
                return context.Users.Any(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            }
        }
    }
}