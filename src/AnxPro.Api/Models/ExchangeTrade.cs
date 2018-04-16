using System;
using System.Collections.Generic;
using System.Text;

namespace AnxPro.Api.Models
{
    public class ExchangeTrade
    {
        public Guid uuid { get; set; }

        public bool primary { get; set; }

        public decimal tradedAmount { get; set; }

        public decimal settlementAmount { get; set; }

        public string tradedCcy { get; set; }

        public string settlementCcy { get; set; }

        public string ccyPair { get; set; }

        public decimal price { get; set; }

        public string side { get; set; }

        public long timestampMillis { get; set; }

        public string version { get; set; }

        public string market { get; set; }
    }
}
