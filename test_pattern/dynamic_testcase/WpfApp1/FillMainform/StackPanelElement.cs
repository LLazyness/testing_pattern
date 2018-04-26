using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Orientation = System.Windows.Controls.Orientation;

namespace WpfApp1.FillMainform
{
    public class StackPanelElement
    {
        readonly BrushConverter _bc = new BrushConverter();
        public short CountOfRows { get; }
        public StackPanel GetRowTestCase { get; } = new StackPanel();

        public StackPanelElement(short count, double width)
        {
            CountOfRows = count;
            GetRowTestCase.MinWidth = width;
            GetRowTestCase.MinHeight = 10;

            if (width == 400.0)
            {
                GetRowTestCase.HorizontalAlignment = HorizontalAlignment.Center;
                GetRowTestCase.VerticalAlignment = VerticalAlignment.Top;
                GetRowTestCase.Orientation = Orientation.Horizontal;
                GetRowTestCase.Name = "row" + count;
                //GetRowTestCase.Background=Brushes.Blue;
            }
            if (width == 401.0)
            {
                GetRowTestCase.HorizontalAlignment = HorizontalAlignment.Center;
               // GetRowTestCase.VerticalAlignment = VerticalAlignment.Top;
                GetRowTestCase.Orientation = Orientation.Vertical;
                GetRowTestCase.Name = "rows" + count;
                //GetRowTestCase.Background = Brushes.Green;
                
            }
            
            if (width == 120.0)
            {
                GetRowTestCase.HorizontalAlignment = HorizontalAlignment.Center;
                GetRowTestCase.VerticalAlignment = VerticalAlignment.Top;
                GetRowTestCase.Orientation = Orientation.Vertical;
                GetRowTestCase.Name = "nav" + count;
            }
                
            
            

        }

        public StackPanel GetStackPanelOfProcessFindElement()
        {
            GetRowTestCase.Orientation = Orientation.Vertical;
            GetRowTestCase.Name = "PanelFindElement";
            GetRowTestCase.VerticalAlignment = VerticalAlignment.Bottom;
            //GetRowTestCase.Background = (Brush) _bc.ConvertFrom("#44174f");
            return GetRowTestCase;
        }

        public StackPanel GetStackPanelOfCheckBox()
        {
            GetRowTestCase.Orientation = Orientation.Vertical;
            GetRowTestCase.Name = "CheckBoxpanel";
            GetRowTestCase.VerticalAlignment = VerticalAlignment.Top;
            GetRowTestCase.HorizontalAlignment = HorizontalAlignment.Left;
            //GetRowTestCase.MinHeight = 30;
            //GetRowTestCase.Background = (Brush) _bc.ConvertFrom("#44174f");
            return GetRowTestCase;
        }

        public StackPanel GetProcessInsertValueToTextBox()
        {
            GetRowTestCase.Orientation = Orientation.Vertical;
            GetRowTestCase.Name = "GetProcessInsertValueToTextBoxPanel";
            GetRowTestCase.VerticalAlignment = VerticalAlignment.Top;
            GetRowTestCase.HorizontalAlignment = HorizontalAlignment.Left;
            return GetRowTestCase;
        }

        public StackPanel GetTextBoxPanel()
        {
            GetRowTestCase.Orientation = Orientation.Vertical;
            GetRowTestCase.Name = "TextBoxPanel";
            GetRowTestCase.VerticalAlignment = VerticalAlignment.Top;
            GetRowTestCase.HorizontalAlignment = HorizontalAlignment.Left;
            return GetRowTestCase;
        }

        
    }
}
