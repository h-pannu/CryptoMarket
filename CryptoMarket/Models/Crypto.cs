using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMarket.Models
{
    public class Crypto
    {
        public Crypto()
        {

        }
        public string? Symbol { get; set; }
        public string? Name { get; set; }
        public double? CurrentPrice { get; set; }
        public double? MarketCap { get; set; }
    }
}
