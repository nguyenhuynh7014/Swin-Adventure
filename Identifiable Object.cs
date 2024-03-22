using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    public class Identifiable_Object
    {
        private List<string> _identifiers = new List<string>();
        //Constructor
        public Identifiable_Object(string[] idents)
        {
            foreach(string id in idents)
            {
                _identifiers.Add(id.ToLower());
            }
        }
        //AreYou method
        public bool AreYou(string id)
        {
            foreach(string ident in _identifiers)
            {
                if (ident == id.ToLower())
                    return true;
            }
            return false;
        }
        //Add Ident Function
        public void AddIdentifier(string id)
            {
                _identifiers.Add(id.ToLower());
            }
        //First Id property
        public string FirstId
        {
            get 
            {
                if (_identifiers.Count >= 0)
                    return _identifiers[0].ToLower();
                else
                    return string.Empty;
            }
        }
    }
}
