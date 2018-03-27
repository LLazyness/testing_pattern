using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1.FillMainform
{
    internal class ButtonOfTestCase: FrameworkElement
    {
        
        public Button TestCaseButton(short count, StackPanel panel)
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
                ICreateForm item = new CreateForm();

                ICreateForm ob = new CreateForm();

                var obj = LogicalTreeHelper.FindLogicalNode(panel, "rows" + count);

                if (obj == null) return;

                var rowsCount = (short)((StackPanel) obj).Children.Count;

                var row = item.CreateRowTestCase(rowsCount, 400.0);

                var combobox = ob.CreateComboBox(rowsCount, 135, 35);

                row.Children.Add(combobox);
               
                (obj as StackPanel).Children.Add(row); //добавляем новый row
            };
            return button;
        }
    }
}
