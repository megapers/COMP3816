using System.Windows;

namespace Assignment3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Manager manager = new Manager();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = manager;
        }
        private void Serialize_Btn(object sender, RoutedEventArgs e)
        {
            var serializer = new Serializer();
            serializer.SerializeXml(manager, CheckBoxXml.IsChecked);
        }
        private void Deserialize_Btn(object sender, RoutedEventArgs e)
        {
            var serializer = new Serializer();
            manager = serializer.Deserialize();
            this.DataContext = manager;
        }
    }
}
