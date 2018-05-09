using System.Windows;
using System.Windows.Controls;
using WpfApp1.FillMainform;

namespace WpfApp1.StackPanels
{
    internal class Row:Id, IStackPanel
    {
        private readonly StackPanel _row = new StackPanel();
        
        public StackPanel CreateStackPanel()
        {
            _row.HorizontalAlignment = HorizontalAlignment.Center;
            _row.VerticalAlignment = VerticalAlignment.Top;
            _row.Orientation = Orientation.Horizontal;
            _row.Name = "row" + GetId();
            _row.Margin = new Thickness(10, 10, 10, 10);
            _row.VerticalAlignment = VerticalAlignment.Center;
            AddChildren();
            return _row;
        }

        public void AddChildren()
        {
            var combobox = new ComboBoxElement((short)GetId(), 200.0, 40.0).GetComboBox;
            _row.Children.Add(combobox);
        }
    }
}
