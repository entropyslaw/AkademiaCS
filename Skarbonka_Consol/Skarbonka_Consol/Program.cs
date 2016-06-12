using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skarbonka_Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            Usr_Validation SetAccount = new Usr_Validation();
            User UserProfile = new User();

            Console.WriteLine(DateTime.Now+"\n");
            Console.WriteLine("Witaj w konsoli skarbonki!\n\n");
           
            while (true)
            {
                SetAccount.MainMenu(SetAccount, UserProfile);
            }

                Console.ReadKey();
        }
    }
}
