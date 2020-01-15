using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleOpretBruger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input fname, lname, email, kodeord, gentag kodeord, køn og alder");
            string returnString = Database.OpretNyBruger(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(returnString);
        }
    }
}
