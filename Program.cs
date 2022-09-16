using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;



namespace pwd_manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen(ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Cyan);
            Database database = new Database(@"C:\Users\User\Desktop\Database.txt");
            XOR xor = new XOR();
            screen.show_menu();
            while (true)
            { 
                screen.menu_c = ConsoleColor.Red;
                Console.Write("\nCommand : ");
                int input = Convert.ToInt32(Console.ReadLine());

                       
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        screen.show_access();
                        database.Read();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        screen.show_back_to_menu();
                        break;
                    case 2:
                        Console.Clear();
                        screen.show_access();
                        database.Write();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        screen.show_back_to_menu();
                        break;
                    case 3:
                        Console.Clear();
                        screen.show_menu();
                        break;
                    case 4:
                        Console.Clear();
                        database.delete_database();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n"+generate_rnd_password()+"\n");
                        screen.show_back_to_menu();
                        break;
                    case 6:
                        Console.Clear();
                        screen.show_exit();
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public static string generate_rnd_password()
        {
            string password;
            StringBuilder sb = new StringBuilder("", 50);
            List<string> list = new List<string>() { "a", "%", "#", "d", "(", "§", "&", "z", "i", "-", "k", "+","t","s","r","q","p","o","l" };
            var rnd = new Random();
            int x = rnd.Next(100, 50000);
            sb.Append(x);
            for (int i = 0; i < list.Count+10; i++) { 
                var rnd2 = list[rnd.Next(list.Count)];
                sb.Append(rnd2.ToString());

            }
            password = sb.ToString();
            return password;
        }
    }  
}
