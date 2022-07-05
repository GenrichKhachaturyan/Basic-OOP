using System;
using System.IO;

namespace Homework3
{
    public class Homework
    {
        public static void Main(string [] args)
        {

            BankAccount myFirstAccount = new BankAccount();
            myFirstAccount.Types = BankAccount.TypeAccount.CURRENCY;
            myFirstAccount.Balance = 1000M;
           
            BankAccount mySecondAccount = new BankAccount(2, 3500M);


            myFirstAccount.Transfer(mySecondAccount, 100);

            Console.WriteLine($"Баланс первого счета {myFirstAccount.Balance}");
            Console.WriteLine($"Баланс первого счета {mySecondAccount.Balance}");


            string rever = "Hello";
            rever = Reverse(rever);
            Console.WriteLine(rever);


            string somethink = "Хачатурян Генрих Арменович & @Gamebox.1998@mail.ru";
            string somethink2 = SearchMail(ref somethink);
            Console.WriteLine(somethink2);


            BankAccount a = new BankAccount();
            BankAccount b = new BankAccount();
            BankAccount c = new BankAccount();

            Console.WriteLine($"number a : {a.NumberAccount} ");
            Console.WriteLine($"number b : {b.NumberAccount} ");
            Console.WriteLine($"number c : {c.NumberAccount} ");


        }


        /// <summary>
        /// Задание №2
        /// </summary>
        /// <param name="str">Параметр принимаемой строки</param>
        /// <returns></returns>
        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string reverString = new string(chars);

            return reverString;
        }

        /// <summary>
        /// Задание №3
        /// </summary>
        /// <param name="s">Параметр принимаемой строки</param>
        /// <returns></returns>
        public static string SearchMail(ref string s)
        {
            string[] email = s.Split(new char[] {'&'});
            return email[1];
        }

    }
}