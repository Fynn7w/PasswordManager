using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace pwd_manager
{
    class Database
    {
        public string path { get; set; }
        public string input { get; set; }
        public string Acces_pwd { get; set; }

        public XOR xor = new XOR();
        public Screen screen =new Screen(ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Cyan);
        
        public Database(string _p)
        {
            path = _p;
        }
        public Database()
        {

        }
        public List<string> Read()
        {
            string Data_to_decrypt;
            string key = Console.ReadLine();
            byte[] decode_key = Encoding.UTF8.GetBytes(key);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(path);
            list = File.ReadLines(path).ToList();
            sr.Close();
            screen.show_entries();
            for (int i = 0; i < list.Count; i++)
            {
                Data_to_decrypt = list[i];
                byte[] data_to_decrypt2 = Convert.FromBase64String(Data_to_decrypt);
                Console.WriteLine(" "+xor.encrypt(data_to_decrypt2, decode_key));

            }
            Console.ForegroundColor = ConsoleColor.White;
            return list;
        }
        public void Write()
        {
            string key = Console.ReadLine();
            screen.show_info();
            string new_pwd = Console.ReadLine();
            byte[] decode_key = Encoding.UTF8.GetBytes(key);
            byte[] decode_data = Encoding.UTF8.GetBytes(new_pwd);
            string output = xor.decrypt(decode_data, decode_key);
            StreamWriter sw = new StreamWriter(path, append: true);
            sw.Write("\n"+output);
            sw.Close();
        }
        public void delete_database()
        {
            Console.WriteLine("\n are you sure ?  y/n ");
            Console.Write("\n Command : ");
            string input = Console.ReadLine();
            if (input == "y")
            {
                screen.show_deleting();
                File.WriteAllText(path, String.Empty);
                screen.show_back_to_menu();
            }
            else{
                screen.show_back_to_menu();
            }
        }
    }
}
