using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory() 
        { 
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id.ToLower()))
                { return true; }
            }
            return false;
        }

        public void Put(Item itm)
        {
             _items.Add(itm);
        }

        public Item Take(string id)
        {
            Item itemRemove = null;
            foreach(Item item in _items)
            {
                if(item.AreYou(id))
                {
                    itemRemove = item;
                    break;
                }
            }

            if(itemRemove!= null)
            {
                _items.Remove(itemRemove);
                return itemRemove;
            }
            return null;
        }

        public Item Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                { return item; }
            }
            return null;
        }

        public string ItemList
        { 
            get
            {
                string itemlist = "";
                foreach(Item item in _items)
                {
                    itemlist  += item.ShortDescription; 
                }
                return itemlist ;
            }
        }
    }
}
