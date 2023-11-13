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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double totalAmount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddPurchase_Click(object sender, RoutedEventArgs e)
        {
            
            if (double.TryParse(purchaseTextBox.Text, out double purchaseAmount))
            {
                totalAmount += purchaseAmount;
                totalAmountTextBlock.Text = $"${totalAmount:F2}";
                // Очистка TextBox
                purchaseTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Введите корректную стоимость покупки.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

