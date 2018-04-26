using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.StackPanels
{
    internal class Rows :Id, IStackPanel
    {
        private readonly StackPanel _rows = new StackPanel();

        public void AddChildren()
        {
            
            _rows.Children.Add(new Row().CreateStackPanel());
        }

        public StackPanel CreateStackPanel()
        {
            _rows.HorizontalAlignment = HorizontalAlignment.Center;
            _rows.Orientation = Orientation.Vertical;
            _rows.Name = "rows" + GetId();
            _rows.Margin = new Thickness(10, 10, 10, 10);
            AddChildren();
            return _rows;
        }
        
    }
}
