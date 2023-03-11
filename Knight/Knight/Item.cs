using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight
{
    class Item
    {
        private int _weight = 0;
        private int _price = 0;

        private string _name = "Неизвестный предмет";
        private string _description = "Только богам известно, на что он способен";

        public Item(string name, string description)
        {   
            _name = name;
            _description = description;
        }

        public Item(string name, string description, int weight, int price)
        {
            _name = name;
            _description = description;
            _weight = weight;
            _price = price;
        }

        public Item()
        {

        }

        public string ToString()
        {
            string info = "";
            info += "\n   Предмет:   " + _name;
            info += "\n   Описание:   " + _description;

            info += "\n   Вес:   " + _weight.ToString() + " кг.";
            info += "\n   Цена:   " + _price.ToString() + " тугр.";


            return info;
        }

    }
}
