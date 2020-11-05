using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public abstract class TransferCommands : Command
    {
        public int From { get; set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
