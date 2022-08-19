using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataBindingWithComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() //constructor program açılırken
        {
            InitializeComponent();

            this.DataContext = this;
            MessageBox.Show("Program açıldı");
            //string[] comboItems = new[] { "Kola", "Ayran", "Çay" };
            ObservableCollection<Mesrubat> icecekler = new ObservableCollection<Mesrubat>();
            icecekler.Add(new Mesrubat("Kola", 15));
            icecekler.Add(new Mesrubat("Ayran", 11));
            icecekler.Add(new Mesrubat("Soda", 7));
            icecekler.Add(new Mesrubat("kefir", 20));
            OrnekComboBox.ItemsSource = icecekler;
            OrnekComboBox.DisplayMemberPath = "Ad"; //anahtar key ad
            OrnekComboBox.SelectedValuePath = "Fiyat"; //key value ilişkisi valuemuz fiyat
            MessageBox.Show("Program kapandı");
        }

        private void OrnekButton_Click(object sender, RoutedEventArgs e)
        {
            OrnekLabel.Content = OrnekComboBox.SelectedValue;
        }
    }
}
