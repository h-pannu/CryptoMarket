using CryptoMarket.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CryptoMarket.Views
{
    /// <summary>
    /// Interaction logic for AddCrypto.xaml
    /// </summary>
    public partial class AddCrypto : Window
    {
        public AddCrypto()
        {
            InitializeComponent();
            AddCryptoViewModel addCryptoViewModel = new AddCryptoViewModel();
            this.DataContext = addCryptoViewModel;
        }
    }
}
