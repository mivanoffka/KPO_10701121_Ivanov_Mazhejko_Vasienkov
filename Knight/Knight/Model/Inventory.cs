using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight
{
    public class Inventory
    {
        public List<Item> Items;

        public Inventory()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public float GetOverallPrice()
        {
            float sum = 0;
            foreach (Item item in Items)
            {
                sum += item.Price;
            }
            return sum;
        }

        public Item GetCheapestItem()
        {
            Item cheapestItem = Items[0];
            foreach(Item item in Items)
            {
                if(item.Price < cheapestItem.Price)
                {
                    cheapestItem = item;
                }
            }
            return cheapestItem;
        }
        public Item GetExpensiveItem()
        {
            Item expensiveItem = Items[0];
            foreach (Item item in Items)
            {
                if (item.Price > expensiveItem.Price)
                {
                    expensiveItem = item;
                }
            }
            return expensiveItem;
        }
    }
}
