using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.StackPanels;

namespace WpfApp1.FillMainform
{
    internal class ButtonOfTestCase: FrameworkElement
    {
        
        public Button TestCaseButton(int count)
        {
            var bc = new BrushConverter();

            var button = new Button
            {
                Width = 120,
                Height = 35,
                Margin = new Thickness(10, 10, 10, 10),
                Background = (Brush) bc.ConvertFrom("#fcfcfc"),
                Content = "Добавить действие",
                Uid = count.ToString()
            };
            button.Click += (sender, args) =>
            {
                var obj = LogicalTreeHelper.FindLogicalNode(MainPanel.MainBlockPanel, "rows" + count);

                if (obj == null) return;
                
                var row = new Row().CreateStackPanel();
                
                (obj as StackPanel)?.Children.Add(row); //добавляем новый row
            };
            return button;
        }
    }
}
