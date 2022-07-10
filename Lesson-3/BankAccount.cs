using System;

namespace Homework3
{
    public class BankAccount
    {
        public enum TypeAccount 
        {
            CURRENCY = 1,
            BROKER,
            SAVINGS,
        }
        private int numberAccount = numAcc;
        private decimal balance;
        private TypeAccount type;
        static int numAcc = 1;
        

       


        public BankAccount(int type,decimal balance)
        {
            CreateNumAccount();

            switch (type)
            {
                case 1:
                    this.type = TypeAccount.CURRENCY;
                    break;
                case 2:
                    this.type = TypeAccount.BROKER;
                    break;
                case 3:
                    this.type = TypeAccount.SAVINGS;
                    break;
                default:
                    throw new Exception("Incorrect input value");
            }


            if (balance >= 0)
            {
                this.balance = balance;
            }
            else
            {
                throw new Exception("Incorrect input values");
            }

        }


        public BankAccount(int type)
        {
            CreateNumAccount();

            switch (type)
            {
                case 1:
                    this.type =  TypeAccount.CURRENCY;
                    break;
                case 2:
                    this.type = TypeAccount.BROKER;
                    break;
                case 3:
                    this.type = TypeAccount.SAVINGS;
                    break;
                default:
                    throw new Exception("Incorrect input value");
            }
        }

       
        public BankAccount(decimal balance)
        {
            CreateNumAccount();

            if (balance >= 0)
            {
                this.balance = balance;
            }
            else
            {
                throw new Exception("Incorrect input values");
            }
        }


        public BankAccount()
        {
            CreateNumAccount();
        }
        

        /// <summary>
        /// Свойство чтения номера счета
        /// </summary>
        public int NumberAccount
        {
            get
            {
                return numberAccount;
            }
        }

        /// <summary>
        /// Свойство присвоения и чтения баланса
        /// </summary>
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if(value >= 0)
                {
                    this.balance = value;
                }
                else
                {
                    throw new Exception("Incorrect input values");
                    
                }
            }
        }

        /// <summary>
        /// Свойство присвоения и чтения типа счета
        /// </summary>
        public TypeAccount Types
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
                    
            }
        }


        internal void CreateNumAccount()
        {
            numAcc++;
        }


        /// <summary>
        /// Задача №1 
        /// </summary>
        /// <param name="account">счет откуда снимаются деньги</param>
        /// <param name="summa">сумма снятия</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public decimal Transfer(BankAccount account,decimal summa)
        {
            if(summa <= account.balance)
            {
                account.balance -= summa;
            }
            else
            {
                throw new Exception("You can't debit more than what's in your account.");
            }

            return this.balance += summa;
            
        }
        


		
	}
}

