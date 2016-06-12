using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skarbonka_Consol
{
    public class Session
    {
        public void InitSession()
        {
            string SessionMenuSwitch;
            SessionMenuSwitch = Console.ReadLine();
            var options = new List<string> { "1.Nowa sesja.", "2.Wczytaj aktualny raport.", "3.Zakończ."};
            Console.WriteLine("MENU Sesji:\n\n1.Nowa sesja\n2.Wczytaj aktualny raport.\n3.Zakończ.");
            switch (SessionMenuSwitch)
            {
                case "1":
                    Console.WriteLine("\n\nWybrałeś opcję: " + options[0]);
                    //System.Threading.Thread.Sleep(1000);
                    break;

                case "2":
                    Console.WriteLine("\n\nWybrałeś opcję: " + options[1]);
                    
                    break;

                case "3":
                    Console.WriteLine("\n\nWybrałeś opcję: " + options[2]);
                    Environment.Exit(0);
                    break;
              
            }
        }
    }
}

