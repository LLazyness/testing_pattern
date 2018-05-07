using System.Windows;
using System.Windows.Controls;
using WpfApp1.FillMainform;

namespace WpfApp1.StackPanels
{
    internal class Nav:Id,IStackPanel
    {
        private readonly StackPanel _nav = new StackPanel();
        public StackPanel CreateStackPanel()
        {
            _nav.Orientation = Orientation.Vertical;
            _nav.VerticalAlignment = VerticalAlignment.Center;
            _nav.HorizontalAlignment = HorizontalAlignment.Center;
            _nav.Name = "nav" + GetId();
            _nav.Margin = new Thickness(10, 10, 10, 10);
            _nav.MinWidth = 10;
            _nav.MinHeight = 10;
            AddChildren();
            return _nav;
        }

        public void AddChildren()
        {
            ICreateForm item = new CreateForm();
            var button = new ButtonOfTestCase().TestCaseButton(GetId());
            var labelUrl = item.CreateLabel((short)GetId(), "labelUrl");
            var labelId = item.CreateLabel((short)GetId(), "labelId");
            var url = new TestCaseTextBox().CreateUrl((short)GetId());
            var id = new TestCaseTextBox().CreateId((short)GetId());
            _nav.Children.Add(button);
            _nav.Children.Add(labelUrl);
            _nav.Children.Add(url);
            _nav.Children.Add(labelId);
            _nav.Children.Add(id);
         
        }
    }
}
