using CryptoMarket.Commands;
using CryptoMarket.Models;
using CryptoMarket.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoMarket.ViewModel
{
    public class CryptoListViewModel
    {
        public ObservableCollection<Crypto> Cryptos { get; set; }
        public ICommand ShowWindowCommand { get; set; }

        public CryptoListViewModel()
        {
            Cryptos = CryptoManager._GetCryptos();

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddCrypto addCryptoWin = new AddCrypto();
            addCryptoWin.ShowDialog();
        }
    }
}
