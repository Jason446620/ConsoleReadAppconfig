using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sValue = ConfigurationSettings.AppSettings["BatFile"];
            string smtpserver = ConfigurationSettings.AppSettings["smtp"];
            string sharelocation = System.Configuration.ConfigurationSettings.AppSettings["share"];
            string usercount = System.Configuration.ConfigurationSettings.AppSettings["UserCount"];
            Console.WriteLine(sValue);
            Console.WriteLine(smtpserver);
            Console.WriteLine(sharelocation);
            Console.WriteLine(usercount);
            string test = " { \"First line\", \"Second line\", \"Third line啊萨达萨达萨达是\" }";
            string log = @"D:\home\site\wwwroot\app_data\jobs\continuous\ConsoleApp1\log.txt";
            using (var sw = new StreamWriter(log))
            {
                sw.WriteLine(test);
            }
            Console.Read();
        }
    }
}
