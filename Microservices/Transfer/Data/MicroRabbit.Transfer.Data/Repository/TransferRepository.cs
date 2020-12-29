using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
