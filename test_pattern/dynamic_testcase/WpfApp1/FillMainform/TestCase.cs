using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            GetTestcase.Background = (Brush)_bc.ConvertFrom("#b0d1e5");
            GetTestcase.Name = "testcase" + countOfTestCase;
        }
        
    }
}
