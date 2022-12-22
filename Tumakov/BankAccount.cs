using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tumakov
{
    enum TypeOfBankAccount
    {
        current,
        saving
    }
    class BankAccount
    {
        Queue<BankTransaction> bankTransactions;
        private static int AccountNumberCounter { get; set; } = 1;
        private int AccountNumber { get; }
        static public int AmountOfMoney { get; set; }
        static private TypeOfBankAccount Type { get; set; }
        public BankAccount(int amountOfMoney)
        {
            AmountOfMoney += amountOfMoney;
            AccountNumber++;
        }
        public BankAccount(TypeOfBankAccount type)
        {
            Type = type;
            AccountNumber++;
        }
        public BankAccount(int amountOfMoney, TypeOfBankAccount type)
        {
            AmountOfMoney += amountOfMoney;
            Type = type;
            AccountNumber++;
        }
        public string Display()
        {
            return $"{AccountNumber} {AmountOfMoney} {Type}";
        }
        public void TakeMoneyFromAccount()
        {
            Console.WriteLine("Сколько денег вы хотите снять?");
            int i = int.Parse(Console.ReadLine());
            if (AmountOfMoney < i)
            {
                Console.WriteLine("У вас меньше средств на счету чем столько сколько вы просите");
            }
            else
            {
                bankTransactions.Enqueue(new BankTransaction(i));
                AmountOfMoney -= i;
            }
        }
        public void PutMoneyOnAccount(int money)
        {
            bankTransactions.Enqueue(new BankTransaction(money));
        }
        public void Dispose()
        {
            using (StreamWriter stream = new StreamWriter("Queue Info.txt"))
            {
                stream.WriteLine($"{bankTransactions.Dequeue()}");
            }
            GC.SuppressFinalize(this);
        }



    }
}
