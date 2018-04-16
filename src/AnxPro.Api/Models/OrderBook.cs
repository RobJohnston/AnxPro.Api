using System;
using System.Collections.Generic;
using System.Text;

namespace AnxPro.Api.Models
{
    public class OrderBook
    {
        public string market { get; set; }

        public string ccyPair { get; set; }

        public long timestampMillis { get; set; }

        public List<Order> bids { get; set; }

        public List<Order> asks { get; set; }

        public class Order
        {
            public decimal price { get; set; }

            public decimal quantity { get; set; }

            public decimal total { get; set; }
        }
    }
}
