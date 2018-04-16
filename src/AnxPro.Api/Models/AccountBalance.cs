using System;

namespace AnxPro.Api.Models
{
    public class AccountBalance
    {
        public decimal balance { get; set; }

        public decimal availableBalance { get; set; }

        public long timestampMillis { get; set; }

        public Guid user { get; set; }

        public Guid uuid { get; set; }
    }
}
