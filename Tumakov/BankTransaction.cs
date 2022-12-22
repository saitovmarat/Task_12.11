using System;
using System.Collections.Generic;
using System.Text;

namespace Tumakov
{
    class BankTransaction
    {
        DateTime Date { get; }
        int TakenMoney { get; }
        public BankTransaction(int takenMoney)
        {
            TakenMoney = takenMoney;
        }
    }
}
