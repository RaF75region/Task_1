using System;

namespace Task1.Model
{
    public sealed class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}
