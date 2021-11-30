using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordManager
{
    public class Program
    {
        public static void open(string path)
        {

        }

        public static void add_pwd(string path, string pwd)
        {

        }

        public static void encrypt(string data, string pwd)
        {
            
        }

        public static void decrypt(string a)
        {
            
        }

        public static void check_pwd(string pwd)
        {

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("****************")
            Console.WriteLine("Password Manager");
            Console.WriteLine("****************")
            
            Console.WriteLine("Enter the Password to Decrypt the Database :");
            if (check_psswd == true)//Checkt ob passwort/key richtig eingegebn wurde
            {
                //alle optionen die der Nutzer hat
                string user_input;
                Console.WriteLine("----------------------------------")
                Console.WriteLine("[1] Show all passwords")
                Console.WriteLine("[2] Add a Password to the Database")
                Console.WriteLine("[3] Exit")
                Console.WriteLine("----------------------------------")
                //1
                if (user_input == 1)
                {
                    open(string_path);
                }
                //2
                if (user_input == 2)
                {
                add_pwd(string path, string pwd);
                }
                //3
                if (user_input == 3)
                {
                    Console.WriteLine("Quitting...")
                    Environment.Exit()//Methode um programm zu beenden
                }
            
            
            }
        }
    }
}
