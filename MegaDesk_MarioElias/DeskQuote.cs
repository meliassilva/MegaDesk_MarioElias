using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_MarioElias
{
    public struct DeskQuote
    {
        public enum Delivery
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }


        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public Delivery ShippingType { get; set; }

        public decimal QuotePrice { get; set; }

        public Desk Desk { get; set; }

        public decimal GetQuotePrice()
        {
            //TODO: add logic to calculate price
            return 0;
        }
    }
}
