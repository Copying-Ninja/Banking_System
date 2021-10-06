using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public static class IOService
    {
        private static string _conn = @"C:\Users\USER_PC_0383\Desktop\Programing\C#";
        private static string _format = "json";
        public static string Read(string fileName)
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{_conn}\\{fileName}.{_format}", Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
           
        }

        public static bool Write(string fileName, string data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{_conn}\\{fileName}.{_format}", false, Encoding.UTF8))
                {
                    sw.WriteLine(data);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
