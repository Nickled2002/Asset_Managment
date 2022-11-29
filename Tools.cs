using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Managment
{
    public class Tools
    {
        public static String GetHashed(String psswrd)
        {
            SHA1 h1 = SHA1.Create();
            byte[] tohash = h1.ComputeHash(Encoding.Default.GetBytes(psswrd));

            StringBuilder GotHashed = new StringBuilder();

            for (int x = 0; x < tohash.Length; x++)
            {
                GotHashed.Append(tohash[x].ToString());
            }
            return GotHashed.ToString();
        }

        private static string connection = "Data Source=tolmount.abertay.ac.uk;USer ID=mssql2001975;Password=vUKQ5rkSPY;database=mssql2001975;";

        public static string ConCreds { get => connection; }

        private static string Type = "Laptop";

        public static string TypeDeets { get => Type; }

        private static string Manu = "Dell";

        public static string ManuDeets { get => Manu; }

        private static string Model = "Dell G15 5511";

        public static string ModelDeets { get => Model; }

        private static string Name = Environment.MachineName;

        public static string NameDeets { get => Name; }

        private static string OSName = ""+Environment.OSVersion;

        public static string OSNameDeets { get => OSName; }

        private static string OSVersion = "" + Environment.OSVersion;

        public static string OSVersionDeets { get => OSVersion; }

        private static string OSManu = "Microsoft";

        public static string OSManuDeets { get => OSManu; }
    }
}
