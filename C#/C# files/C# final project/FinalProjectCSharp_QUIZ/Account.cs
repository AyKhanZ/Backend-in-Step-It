using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp_QUIZ
{
    internal class Account
    {
        private string Login { get; set; }
        private string Password { get; set; }
        private DateTime Date {get; set; }
         
        
        // Settings method
        public void ChangeSettings()
        {
            Console.WriteLine("Settings");
        }
        // History method
        public void WatchHistory()
        {
            Console.WriteLine("History");
        }
        // Method exit
        public void Exit()
        {
            Menus menu = new();
            menu.RegistrationOrLoginMenu();
        }
    }
}
