using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace WpfApp1.FillMainform
{
    public class TestCase
    {
        readonly BrushConverter _bc = new BrushConverter();
        public short CountOfTestCase { get; }

        public StackPanel GetTestcase { get; } = new StackPanel();

        public TestCase(short countOfTestCase)
        {
            CountOfTestCase = countOfTestCase;
            GetTestcase.Orientation = Orientation.Horizontal;
            GetTestcase.HorizontalAlignment = HorizontalAlignment.Right;
            GetTestcase.VerticalAlignment = VerticalAlignment.Center;
            GetTestcase.MinWidth = 1024;
            GetTestcase.Margin = new Thickness(5, 5, 5, 5);
            GetTestcase.Background =
                new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/WpfApp1;component/picture/banner-landing-dark-blue.png")));
            GetTestcase.Name = "testcase" + countOfTestCase;
        }
        
    }
}
