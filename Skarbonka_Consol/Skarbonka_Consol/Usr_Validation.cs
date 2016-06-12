using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skarbonka_Consol
{
    class Usr_Validation
    {
        String login;
        String password;

        public void MainMenu(Usr_Validation UserAccount, User UserProfile)
        {
            var options = new List<string> { "1.Zaloguj się.", "2.Dodaj nowego użytkownika.", "3.Wyjdź z programu." };
            String MainMenuSwitch;

            Console.Clear();
            Console.WriteLine("MENU:\n\n1.Zaloguj się.\n2.Dodaj nowego użytkownika\n3.Wyjdź z programu.");


            MainMenuSwitch = Console.ReadLine();

            switch (MainMenuSwitch)
            {

                case "1":
                    Console.Clear();
                    Console.WriteLine("\n\nWybrałeś opcję: " + options[0] + "\n\n");
                    UserAccount.checkUser(UserAccount);
                   
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("\n\nWybrałeś opcję: " + options[1] + "\n\n");
                    UserProfile.addUsr(UserProfile);

                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("\n\nWybrałeś opcję: " + options[2]+ "\n\n");
                    System.Threading.Thread.Sleep(1500);
                    Environment.Exit(0);
                    break;

            }
        }

        public int checkUser(Usr_Validation usrLog)
        {
            int LogPosition=0;                          // Na liście użytkowników 0 pozycję zajmuje użytkownik "pusty"...
            Console.WriteLine("Podaj swój login:");     // ...zwrócenie przez funkcję "checkUser" pozycji 0 oznacza, że...
            usrLog.login=Console.ReadLine();            // ...użytkownik nie został znaleziony na liście.    
            Console.WriteLine("Podaj swoje hasło:");
            usrLog.password=Console.ReadLine();
            return LogPosition;
        }

        public void NewUser()
        {

        }
    }
}
