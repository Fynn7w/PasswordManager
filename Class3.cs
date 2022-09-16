using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace pwd_manager
{
    class Screen
    {
        public ConsoleColor menu_c { get; set; }
        public ConsoleColor rw_context_c { get; set; }
        public ConsoleColor exit_c { get; set; }

        public Screen()
        {

        }
        public Screen(ConsoleColor _m ,ConsoleColor _r,ConsoleColor _w)
        {
            menu_c = _m;
            rw_context_c = _r;
            exit_c = _w;
        }
        public void show_menu()
        {
            Console.WriteLine(@"
 ____                 __  __
|  _ \ __ _ ___ ___  |  \/  | __ _ _ __   __ _  __ _  ___ _ __
| |_) / _` / __/ __| | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__|
|  __/ (_| \__ \__ \ | |  | | (_| | | | | (_| | (_| |  __/ |
|_|   \__,_|___/___/ |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_|
                                               |___/            
            ");

            Console.ForegroundColor = menu_c;
            Console.WriteLine("\n[1] see saved Passwords");
            Console.WriteLine("[2] add a Password");
            Console.WriteLine("[3] Show Menu");
            Console.WriteLine("[4] Delete the Databse");
            Console.WriteLine("[5] Generate random password");
            Console.WriteLine("[6] Exit\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void show_access()
        {
            Console.ForegroundColor = rw_context_c; 
            Console.WriteLine("\n Please Enter the Password to encrypt the Database");
            Console.Write("\n Password : ");
            Console.ForegroundColor = ConsoleColor.Black;
            
        }
        public void show_exit()
        {
            Console.ForegroundColor = exit_c;
            Console.WriteLine("\n Quitting");
        }
        public void show_deleting()
        {
            Console.ForegroundColor = exit_c;
            Console.WriteLine("\n Deleting the Databse ...");
            Console.WriteLine(" Succesfully deleted the Database");
        }
        public void show_back_to_menu()
        {
            Console.WriteLine("\npress 3 to return to the menu\n");
            //Console.Write(" command :");
        }
        public void show_info()
        {
            Console.ForegroundColor = rw_context_c; 
            Console.WriteLine("\n Beispiel :   Anwendung  :  Passwort");
            Console.Write("\n Command : ");
        }
        public void show_entries()
        {
            Console.ForegroundColor = rw_context_c;
            Console.WriteLine("\n Einträge : ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
