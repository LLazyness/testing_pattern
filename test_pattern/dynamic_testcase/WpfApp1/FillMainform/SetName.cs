using System.Windows;

namespace WpfApp1.FillMainform
{
   

    public class SetName<T> where T : FrameworkElement
    {
        public T set_id(T element, int id) 
        {
            
            element.Name = "name" + (id + 1);
            element.Uid = (id + 1).ToString();
            return element;
        }
    }
}
