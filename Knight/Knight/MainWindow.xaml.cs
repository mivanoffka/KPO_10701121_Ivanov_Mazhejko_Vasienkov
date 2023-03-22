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
        Inventory inventory;
        public MainWindow()
        {
            InitializeComponent();
            inventory = new Inventory();
            AddDefaultItems();
            dgInventory.ItemsSource = inventory.Items;
        }
        
        private void AddDefaultItems()
        {
            inventory.AddItem(new Item("Стандартный меч", 
                "Твой первый меч. Бесценен. Нет, буквально, он никому не нужен.", 2f, 0f));

            inventory.AddItem(new Item("Стандартная броня", 
                "Ты с огромным трудом можешь назвать свою рубашку бронёй, но ладно", 0.5f, 0.1f));

            inventory.AddItem(new Item("Зелеье исцеления", 
                "Хоть что-то полезное. Лечит 10% от макс HP", 0.1f, 10f));

        }

        public void DoSmth()
        {
            Console.Clear();

            WriteLine(String.Format("Стоимость всей амуниции составляет {0} тугр.", inventory.GetOverallPrice().ToString()));
            
            //конечно, можно обойтись без bufferItem, но тогда мы получим фигово читаемую матрёшку,
            //где мы вызываем метод в методе. Нам это надо? Я считаю нет
            Item bufferItem = inventory.GetCheapestItem();
            WriteLine(String.Format("Самый дешёвый предмет - {0} стоимостью {1} тугр.",bufferItem.Name,bufferItem.Price));
            bufferItem = inventory.GetExpensiveItem();
            WriteLine(String.Format("Самый дорогой предмет - {0} стоимостью {1} тугр.", bufferItem.Name, bufferItem.Price));
        }

        public void WriteLine(string txt)
        {
            Console.Text += txt;
            Console.Text += Environment.NewLine;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DoSmth();
        }
    }
}
