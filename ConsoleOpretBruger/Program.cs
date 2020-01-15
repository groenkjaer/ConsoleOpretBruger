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
        private static SqlConnection conn;
        static void Main(string[] args)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["post"].ConnectionString); //setup

            Console.WriteLine("Firstname");
            string fname = Console.ReadLine().ToString();
            Console.WriteLine("Lastname");
            string lname = Console.ReadLine().ToString();
            Console.WriteLine("email");
            string email = Console.ReadLine().ToString();
            Console.WriteLine("Kodeord");
            string kodeord1 = Console.ReadLine().ToString();
            Console.WriteLine("Gentag kodeord");
            string kodeord2 = Console.ReadLine().ToString();
            Console.WriteLine("Køn");
            string koen = Console.ReadLine().ToString();
            Console.WriteLine("Alder");
            string alder = Console.ReadLine().ToString();


            if (kodeord1 == kodeord2)
            {
                try
                {
                    SqlCommand comm = new SqlCommand(string.Format("INSERT INTO Medlemmer (Fornavn, Efternavn, Koen, Alder, [Status], Email, Kodeord) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", fname, lname, koen, alder, "Aktiv", email, kodeord1), conn);
                    conn.Open();

                    if (comm.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("Du har nu oprettet en bruger");
                        conn.Close();
                    }
                    else
                    {
                        Console.WriteLine("Bruger kunne ikke oprettes");
                        conn.Close();
                    }
                }
                catch
                {
                    Console.WriteLine("Kunne ikke oprette bruger, venligst kontakt personalet");
                }
            }
            else
            {
                Console.WriteLine("Kodeord matcher ikke");
            }
        }
    }
}
