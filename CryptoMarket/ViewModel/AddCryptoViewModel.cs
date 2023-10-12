using CryptoMarket.Commands;
using CryptoMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoMarket.ViewModel
{
    public class AddCryptoViewModel
    {
        public ICommand AddCryptoCommand { get; set; }
        public string? _Symbol { get; set; }
        public string? _Name { get; set; }
        public double? _CurrentPrice { get; set; }
        public double? _MarketCap { get; set; }

        public AddCryptoViewModel()
        {
            AddCryptoCommand = new RelayCommand(AddCrypto, CanAddCrypto);
        }

        private void AddCrypto(object obj)
        {
            CryptoManager.AddCrypto(new Crypto() { Symbol = _Symbol, Name = _Name, CurrentPrice = _CurrentPrice, MarketCap = _MarketCap });
        }

        private bool CanAddCrypto(object obj)
        {
            return true;
        }
    }
}
