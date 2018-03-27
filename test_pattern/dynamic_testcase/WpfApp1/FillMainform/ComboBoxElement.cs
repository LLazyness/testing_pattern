using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1.FillMainform
{
    internal class ComboBoxElement
    {
        public short Count { get; }
        private readonly BrushConverter _bc = new BrushConverter();
        public ComboBox GetComboBox { get; } = new ComboBox();

        public ComboBoxElement(short count, double width, double height)
        {
            Count = count;
            GetComboBox.Width = width;
            GetComboBox.Height = height;
            GetComboBox.HorizontalAlignment = HorizontalAlignment.Left;
            GetComboBox.Name = "ComboBox" + count;
            GetComboBox.Items.Add("Выбрать действие");
            GetComboBox.Items.Add("Найти элемент");
            GetComboBox.Items.Add("Сравнить элемент");
            GetComboBox.SelectedItem = GetComboBox.Items.GetItemAt(0);
            
           
            GetComboBox.VerticalContentAlignment = VerticalAlignment.Center;
            GetComboBox.HorizontalContentAlignment = HorizontalAlignment.Center;
            GetComboBox.Margin = new Thickness(5, 5, 5, 5);
            GetComboBox.Background = (Brush)_bc.ConvertFrom("#fcfcfc");
            GetComboBox.SelectionChanged += delegate
            {
                var obj = LogicalTreeHelper.FindLogicalNode(GetComboBox.Parent, "row"+count);

                switch ((string) GetComboBox.SelectedItem)
                {
                    case "Найти элемент":
                        var check = LogicalTreeHelper.FindLogicalNode(obj ?? throw new InvalidOperationException(), "TextBox"+count);
                        if (check != null) return;
                        var textbox = new TextBoxElement(count, 80.0, 30.0);
                    
                        (obj as StackPanel)?.Children.Add(textbox.GetTextBox);
                        break;
                    case "Сравнить элемент":
                        break;
                    default:
                        MessageBox.Show("notfind");
                        break;
                }
            };

        }
    }
}
