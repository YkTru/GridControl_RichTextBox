using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace SpreadSheet.WPF
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Car> cars;

        [ObservableProperty]
        private RichTextBox? selectedRichTextBox;

        public MainViewModel()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car { ID = 1, Trademark = "Toyota", Model = "Corolla", Description = "Reliable sedan" },
                new Car { ID = 2, Trademark = "Ford", Model = "F-150", Description = "Popular truck" },
                new Car { ID = 3, Trademark = "Tesla", Model = "Model S", Description = "Electric sedan" },
                new Car { ID = 4, Trademark = "BMW", Model = "X5", Description = "Luxury SUV" },
                new Car { ID = 5, Trademark = "Honda", Model = "Civic", Description = "Compact car" }
            };
        }

        [RelayCommand]
        private void ChangeTextColor(string color)
        {
            if (SelectedRichTextBox == null)
                return;

            var selection = SelectedRichTextBox.Selection;
            if (selection.IsEmpty)
                return;

            var brush = color switch
            {
                "Red" => Brushes.Red,
                "Orange" => Brushes.Orange,
                "Green" => Brushes.Green,
                _ => Brushes.Black
            };

            selection.ApplyPropertyValue(TextElement.ForegroundProperty, brush);
        }
    }
}