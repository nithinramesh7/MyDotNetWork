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

namespace Wpf01Xaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var book = booklist.SelectedItem as Book;
           // if(book!=null)
            //   MessageBox.Show(book.ToString(), "Selected Book", MessageBoxButton.OK, MessageBoxImage.Information);

            if (book == null)
                MessageBox.Show("Please Select a Book First", "No Book Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                titleText.Text = book.Title;
                authorText.Text = book.Author;
                priceText.Text = "₹ " + book.Price;
        }
    }
}
