using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skarbonka_Consol
{
   
    public class User
    {
        public List<User> UsersList;
        public string name { get; set; }
        public float shortObj { get; set; }
        public float longObj { get; set; }
        public float periodOutcome { get; set; }
        public float periodIncome { get; set; }
        public float Balance { get; set; }
       


        public void addUsr(User user)
        {
            Console.WriteLine("Stwórz swój login:");
            user.name = Console.ReadLine();
            Console.WriteLine("Stwórz swoje hasło:");
            user.name = Console.ReadLine();
            Console.WriteLine("Powtórz swoje hasło:");
            user.name = Console.ReadLine();
        }

        public void delUsr()
        {

        }

    }
}
