using System.Windows;
using System.Windows.Controls;
using WpfApp1.FillMainform;

namespace WpfApp1.StackPanels
{
    internal class Url:IStackPanel
    {
        private StackPanel _urlPanel = new StackPanel();
        public StackPanel CreateStackPanel()
        {
            _urlPanel.HorizontalAlignment = HorizontalAlignment.Center;
            
            _urlPanel.Orientation = Orientation.Horizontal;
            _urlPanel.Name = "urlPanel";
            _urlPanel.Margin = new Thickness(10, 10, 10, 10);
            _urlPanel.VerticalAlignment = VerticalAlignment.Center;
            AddChildren();
            return _urlPanel;
        }

        public void AddChildren()
        {
            var obj = new TextBoxGoToUrl();
            var urlTextBox = obj.CreateUrlTextBox();
            _urlPanel.Children.Add(urlTextBox);
            //_urlPanel.Children.Add(new CreateForm().CreateLabel(1, "URL"));
            //_urlPanel.Children.Add(new CreateForm().CreateCheckBox());

        }
    }
}
