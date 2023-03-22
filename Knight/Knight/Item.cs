using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight
{
    public class Item
    {
        public string Name
        {
            get { return _name; }
            set { if (value != "") _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { if (value != "") _description = value; }
        }
        public float Weight
        {
            get { return _weight; }
            set { if (value > 0) _weight = value; }
        }
        public float Price { 
            get { return _price; }
            set { if (value >= 0) _price = value; } 
        }

        private float _weight = 0;
        private float _price = 0;

        private string _name = "Неизвестный предмет";
        private string _description = "Только богам известно, на что он способен";

        public Item(string name, string description)
        {   
            _name = name;
            _description = description;
        }

        public Item(string name, string description, float weight, float price)
        {
            _name = name;
            _description = description;
            _weight = weight;
            _price = price;
        }

        public Item()
        {

        }

        public override string ToString()
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
