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
            GetComboBox.VerticalAlignment = VerticalAlignment.Bottom;
            GetComboBox.Name = "ComboBox" + count;
            GetComboBox.Items.Add("Выбрать действие");
            GetComboBox.Items.Add("Найти элемент");
            GetComboBox.Items.Add("Сравнить элемент");
            GetComboBox.SelectedItem = GetComboBox.Items.GetItemAt(0);
            
           
            GetComboBox.VerticalContentAlignment = VerticalAlignment.Center;
            GetComboBox.HorizontalContentAlignment = HorizontalAlignment.Center;
            GetComboBox.Margin = new Thickness(5, 0, 5, 5);
            GetComboBox.Background = (Brush)_bc.ConvertFrom("#fcfcfc");
            GetComboBox.SelectionChanged += (sender, args) =>
            {
                ICreateForm ob = new CreateForm();
                var row = GetComboBox.Parent;
                var countOfRowChild = ((StackPanel)row).Children.Count; 
                for (var i=0; i<countOfRowChild; i++)
                {
                    if (i != 0)
                        ((StackPanel) row)?.Children.Remove(((StackPanel) row)?.Children[i]);

                }
                switch ((string) GetComboBox.SelectedItem)
                {
                    case "Найти элемент":

                        var check = LogicalTreeHelper.FindLogicalNode(row ?? throw new InvalidOperationException(), "TextBox" + count);

                        var val = new CreateForm();

                        if (check != null) return;

                        var label = ob.CreateLabel(count, "Идентификатор");

                        var textbox = new TextBoxElement(count, 80.0, 30.0).GetTextBox;

                        var processFindElementPanel = new StackPanelElement(count, 10).GetStackPanelOfProcessFindElement();

                        

                        processFindElementPanel.Children.Add(label);

                        processFindElementPanel.Children.Add(textbox);

                        var checkBoxPanel = new StackPanelElement(count, 10).GetStackPanelOfCheckBox();

                        checkBoxPanel.Children.Add(val.CreateLabel(count, "checkbox"));

                        checkBoxPanel.Children.Add(val.CreateCheckBox());

                        ((StackPanel) row)?.Children.Add(processFindElementPanel);

                        ((StackPanel)row)?.Children.Add(checkBoxPanel);

                        var testcase = ((StackPanel)((StackPanel)row).Parent).Parent;

                        var nameOfRows = ((StackPanel)testcase).Name;

                        //MessageBox.Show(nameOfRows);
                        
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
