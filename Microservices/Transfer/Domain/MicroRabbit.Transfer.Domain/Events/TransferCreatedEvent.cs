﻿namespace MicroRabbit.Transfer.Domain.Event
{
    public class TransferCreatedEvent : MicroRabbit.Domain.Core.Events.Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
