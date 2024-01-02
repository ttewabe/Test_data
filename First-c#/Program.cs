
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int onlineUsers;
            onlineUsers = 2;
            i = 50;

            double d = 1.5;
            double accountBalance = 120.35;
            d = 50.6;

            char c = 'a';
            char dollar = '$';

            string s = "Hello World";
            string welcomeMessage = "Welcome to data types demo.";
            string emptyString = "";
            string oneCharacter = "a";

            bool b = true;
            bool activeBankAccount = false;
            activeBankAccount = b;                                                            


            Console.Out.WriteLine(welcomeMessage);
            Console.Out.WriteLine();
            Console.Out.WriteLine("AccountActive: ");
            Console.Out.WriteLine(activeBankAccount);
            Console.Out.WriteLine("AccontBalance: ");
            Console.Out.WriteLine(dollar);
            Console.Out.WriteLine(accountBalance);
            Console.Out.WriteLine();
            Console.Out.WriteLine("Press Eneter to Continoe... ");
            Console.In.Read();

        }
    }
}



