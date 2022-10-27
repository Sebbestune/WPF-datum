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

namespace WpfApp6_tidochdatum
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> valdaDatum = new List<string>() { "22-10-2022 12:00"};

        string[] valbaraTider = { "8:00", "9:00", "10:00" };

        public MainWindow()
        {
            InitializeComponent();
            DisplayContent();

            TidsBox.ItemsSource = valbaraTider;
        }

        private void DisplayContent()
        {
            MyListBox.ItemsSource = null;
            MyListBox.ItemsSource = valdaDatum;
        }

        private void AddDateToList(object sender, RoutedEventArgs e)
        {
            valdaDatum.Add(DatumPicker.Text + " " + TidsBox.Text);

            DisplayContent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Kalender.SelectedDate != null)
            {
                valdaDatum.Add(Kalender.SelectedDate.Value.ToString("dd/MM/yyyy"));
                DisplayContent();
            }
        }
    }
}
