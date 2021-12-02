﻿using BlueBank.System.Domain.Shared.Entities;
using System;

namespace BlueBank.System.Domain.OrderManagement.Entities
{
    public class Transaction : Entity
    {
        public Guid AccountOrigin { get; set; }
        public Guid AccountRecipient { get; set; }
        public DateTime Date {get; set; }
        public decimal Value { get; set; }

        public Transaction(Guid accountOrigin, Guid accountRecipient, DateTime date, decimal value)
        {
            AccountOrigin = accountOrigin;
            AccountRecipient = accountRecipient;
            Date = date;
            Value = value;
        }        
    }
}
