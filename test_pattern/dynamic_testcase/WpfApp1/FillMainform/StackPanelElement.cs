using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1.FillMainform
{
    public class StackPanelElement
    {
        public short CountOfRows { get; }
        public StackPanel GetRowTestCase { get; } = new StackPanel();

        public StackPanelElement(short count, double width)
        {
            CountOfRows = count;
            GetRowTestCase.MinWidth = width;

            if (width == 400.0)
            {
                GetRowTestCase.HorizontalAlignment = HorizontalAlignment.Center;
                GetRowTestCase.VerticalAlignment = VerticalAlignment.Top;
                GetRowTestCase.Orientation = Orientation.Horizontal;
                GetRowTestCase.Name = "row" + count;
                //GetRowTestCase.Background=Brushes.Blue;
            }
            else if (width == 401.0)
            {
                GetRowTestCase.HorizontalAlignment = HorizontalAlignment.Center;
                GetRowTestCase.VerticalAlignment = VerticalAlignment.Top;
                GetRowTestCase.Orientation = Orientation.Vertical;
                GetRowTestCase.Name = "rows" + count;
                //GetRowTestCase.Background = Brushes.Green;
                
            }
            
            else
            {
                GetRowTestCase.HorizontalAlignment = HorizontalAlignment.Center;
                GetRowTestCase.VerticalAlignment = VerticalAlignment.Top;
                GetRowTestCase.Orientation = Orientation.Vertical;
                GetRowTestCase.Name = "nav" + count;
            }
                
            
            

        }
    }
}
