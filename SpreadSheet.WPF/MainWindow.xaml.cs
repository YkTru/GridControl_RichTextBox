using System.Windows;
using System.Windows.Controls;
using SpreadSheet.WPF;

namespace SpreadSheet.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void RichTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainViewModel vm && sender is RichTextBox richTextBox)
            {
                vm.SelectedRichTextBox = richTextBox;
            }
        }
    }
}