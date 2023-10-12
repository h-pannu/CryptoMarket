using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMarket.Models
{
    public class CryptoManager
    {
        public static ObservableCollection<Crypto> _DatabaseCrypto = new ObservableCollection<Crypto>() { 
            new Crypto() { Symbol="BTC", Name="Bitcoin",CurrentPrice=27000.40, MarketCap=50000000000.45 }, 
            new Crypto() { Symbol="ETH", Name="Ethereum",CurrentPrice=1500.60, MarketCap=23000000000.45 }, 
            new Crypto() { Symbol="SHIB", Name="Shiba Inu",CurrentPrice=0.00014, MarketCap=12000000000.45 } 
        };

        public static ObservableCollection<Crypto> _GetCryptos()
        {
            return _DatabaseCrypto;
        }

        public static void AddCrypto(Crypto crypto)
        { 
            _DatabaseCrypto.Add(crypto); 
        }
    }
}
