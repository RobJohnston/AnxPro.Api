using System;
using System.Collections.Generic;
using System.Text;

namespace AnxPro.Api.Models
{
    public class MarketTick
    {
        public string market { get; set; }

        public long timestampMillis { get; set; }

        public decimal bid { get; set; }

        public decimal ask { get; set; }

        public decimal volume { get; set; }

        public decimal vwap { get; set; }

        public decimal high { get; set; }

        public decimal low { get; set; }

        public string ccyPair { get; set; }

        public decimal last { get; set; }
    }
}
