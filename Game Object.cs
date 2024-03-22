using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    public abstract class Game_Object : Identifiable_Object
    {
        private string _description;
        private string _name;

        //Constructor
        public Game_Object(string[] ids, string name, string desc) : base(ids)
        {
            
            _description = desc;
            _name = name;

        }

        //Property   Name  Readonly
        public string Name
        {
            get { return _name; }
        }

        //Property SHortDescription   Readonly
        public String ShortDescription
        { get { return Name + "(" + FirstId +")"; } }

        //Property  virtual  FullDescription    Readonly    
        public virtual string FullDescription
        { get { return _description; } }
    }
}
