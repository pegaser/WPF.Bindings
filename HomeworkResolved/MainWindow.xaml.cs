using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace HomeworkResolved
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            binding.Source = this.Resources["convertDistance"];
            binding.Path = new PropertyPath("MethodParameters[0]");
            binding.BindsDirectlyToSource = true;
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding.Converter = new DoubleToString();
            txtUserValue.SetBinding(TextBox.TextProperty, binding);

            binding = new Binding();
            binding.Source = this.Resources["convertDistance"]; 
            binding.Path = new PropertyPath("MethodParameters[1]");
            binding.BindsDirectlyToSource = true;
            cmbDistanceType.SetBinding(ComboBox.SelectedValueProperty, binding);

            binding = new Binding();
            binding.Source = this.Resources["convertDistance"];
            lblResult.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}
