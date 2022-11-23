using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Managment
{
    public class Tools
    {
        public static String PasswordHashed(String Var)
        {
            SHA1 var2 = SHA1.Create();
            byte[] tohash = var2.ComputeHash(Encoding.Default.GetBytes(Var));

            StringBuilder vartoreturn = new StringBuilder();

            for (int i = 0; i < tohash.Length; i++)
            {
                vartoreturn.Append(tohash[i].ToString());
            }
            return vartoreturn.ToString();
        }

        private static string connection = "Data Source=tolmount.abertay.ac.uk;USer ID=mssql2001975;Password=vUKQ5rkSPY;database=mssql2001975;";

        public static string ConCreds { get => connection; }




    
    }
}
