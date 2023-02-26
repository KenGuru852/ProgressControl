using Avalonia.Controls;
using Avalonia.Interactivity;
using ProgressControl.ViewModels;
namespace ProgressControl.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
