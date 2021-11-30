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

        public static bool check_pwd()
        {


        return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("****************");
            Console.WriteLine("Password Manager");
            Console.WriteLine("****************");


            Console.WriteLine("Enter the Password to Decrypt the Database :");
            if ( check_pwd() == true)//Checkt ob passwort/key richtig eingegebn wurde
            {
                //alle optionen die der Nutzer hat
                int user_input;
                user_input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                Console.WriteLine("[1] Show all passwords");
                Console.WriteLine("[2] Add a Password to the Database");
                Console.WriteLine("[3] Exit");
                Console.WriteLine("----------------------------------");
                //1
                if (user_input == 1)
                {
                    open(path);
                }
                //2
                if (user_input == 2)
                {
                    add_pwd(string path, string pwd);
                }
                //3
                if (user_input == 3)
                {
                    Console.WriteLine("Quitting...");
                    Environment.Exit(0);//Methode um programm zu beenden
                }


            }
        }
    }
}