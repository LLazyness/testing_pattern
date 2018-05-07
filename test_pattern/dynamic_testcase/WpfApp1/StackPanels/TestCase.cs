using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.FillMainform;

namespace WpfApp1.StackPanels
{
    internal class TestCase:Id,IStackPanel
    {
        private StackPanel _testcase = new StackPanel();
        private readonly string _name;
        private readonly string _uid;

        public TestCase()
        {
            _name = "testcase" + GetId();
            _uid = GetId().ToString();
        }

        public StackPanel CreateStackPanel()
        {
            _testcase = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center,
                MinWidth = 1024,
                Margin = new Thickness(5, 5, 5, 5),
                Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/WpfApp1;component/picture/banner-landing-dark-blue.png"))),
                Name = _name,
                Uid=_uid
                
            };
            AddChildren();
            return _testcase;
        }

        public void AddChildren()
        {
            _testcase.Children.Add(new Nav().CreateStackPanel());
            _testcase.Children.Add(new Rows().CreateStackPanel());
            _testcase.Children.Add(new ButtonDelete().DeleteTestCase((short)GetId()));
        }
    }
}
