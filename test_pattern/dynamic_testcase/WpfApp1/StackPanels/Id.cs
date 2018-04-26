using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WpfApp1.StackPanels
{
    internal class Id
    {
        private static List<int> _id = new List<int>();

        protected int GetId()
        {
            if (_id.Count == 0)
                return 0;
            return _id.Last()+1;
        }

        protected void AddId(int id)
        {
            
               
                    _id.Add(id);
               
            
        }

        protected void DropId(int id)
        {
            _id.Remove(id);

        }

        
    }
}
