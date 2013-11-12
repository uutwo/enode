﻿using System;

namespace BankTransferSample.Domain.BankAccounts
{
    /// <summary>表示一笔转账交易中的预转出信息
    /// </summary>
    public class DebitPreparation
    {
        public Guid TransactionId { get; private set; }
        public double Amount { get; private set; }

        public DebitPreparation(Guid transactionId, double amount)
        {
            TransactionId = transactionId;
            Amount = amount;
        }
    }
}
