using System;
using System.Collections.Generic;


namespace Swin_Adventure
{
    public class Player : Game_Object 
    {
        private Inventory _inventory;

        public Player(string name, string desc) : base(new string[] { name.ToLower()},name,desc)
        {
            _inventory = new Inventory();
        }

        public Game_Object Locate(string id)
        {
            if(AreYou(id))
            {
                return this;
            }
            else if(_inventory.HasItem(id))
            {
                return _inventory.Fetch(id);
            }
            else
            {
                return null;
            }
        }

        public override string FullDescription
        {
            get { return Name+"("+FirstId+")";}
        }

        public Inventory Inventory { get { return _inventory; } }
    }
}
