using System;
using System.IO;


namespace Homework6
{
    public class Homework
    {
        public static void Main(string [] args)
        {

            BankAccount myFirstAccount = new BankAccount();
            myFirstAccount.Types = BankAccount.TypeAccount.CURRENCY;
            myFirstAccount.Balance = 3504M;
           
            BankAccount mySecondAccount = new BankAccount(2, 3500M);

            Console.WriteLine(mySecondAccount.ToString());
            


         

            


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