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

namespace Knight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private Inventory inventory;
        public MainWindow()
        {
            InitializeComponent();
            inventory = new Inventory();
            AddDefaultItems();
            dgInventory.ItemsSource = inventory.Items;
        }
       

        public void WriteLine(string txt)
        {
            Console.Text += txt;
            Console.Text += Environment.NewLine;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Calculate();
        }


    }
}
