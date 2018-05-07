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
            GetComboBox.Items.Add("Ввести значение в элементе");
            GetComboBox.SelectedItem = GetComboBox.Items.GetItemAt(0);
            
           
            GetComboBox.VerticalContentAlignment = VerticalAlignment.Center;
            GetComboBox.HorizontalContentAlignment = HorizontalAlignment.Center;
            GetComboBox.Margin = new Thickness(5, 0, 5, 5);
            GetComboBox.Background = (Brush)_bc.ConvertFrom("#fcfcfc");

            

            GetComboBox.SelectionChanged += (sender, args) =>
            {
                var checkBoxPanel = new StackPanelElement(count, 30).GetStackPanelOfCheckBox();
                ICreateForm ob = new CreateForm();
                var row = GetComboBox.Parent;
                var countOfRowChild = ((StackPanel)row).Children.Count; 
                for (var i= countOfRowChild-1; i>=0; i--)
                {
                    if (i == 0) continue;
                    
                     ((StackPanel) row)?.Children.Remove(((StackPanel) row)?.Children[i]);
                }
                switch ((string) GetComboBox.SelectedItem)
                {
                    case "Найти элемент":

                        if (LogicalTreeHelper.FindLogicalNode(row ?? throw new InvalidOperationException(), "TextBox" + count) != null) return;
                        
                        var processFindElementPanel = new StackPanelElement(count, 10).GetStackPanelOfProcessFindElement();
                        
                        processFindElementPanel.Children.Add(ob.CreateLabel(count, "Идентификатор"));

                        processFindElementPanel.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);
                        
                        checkBoxPanel.Children.Add(new CreateForm().CreateLabel(count, "checkbox"));

                        checkBoxPanel.Children.Add(new CreateForm().CreateCheckBox());

                        ((StackPanel) row)?.Children.Add(processFindElementPanel);

                        ((StackPanel)row)?.Children.Add(checkBoxPanel);
                        
                        break;

                    case "Ввести значение в элементе":
                        
                        GetComboBox.Width= 190;

                        var processInsertValueToElement = new StackPanelElement(count, 10).GetProcessInsertValueToTextBox();

                        processInsertValueToElement.Children.Add(ob.CreateLabel(count, "Идентификатор"));

                        processInsertValueToElement.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);
                        
                        checkBoxPanel.Children.Add(new CreateForm().CreateLabel(count, "checkbox"));

                        checkBoxPanel.Children.Add(new CreateForm().CreateCheckBox());

                        var textBoxPanel = new StackPanelElement(count, 10).GetTextBoxPanel();

                        textBoxPanel.Children.Add(ob.CreateLabel(count, "insertedValue"));

                        textBoxPanel.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);

                        ((StackPanel)row)?.Children.Add(processInsertValueToElement);

                        ((StackPanel)row)?.Children.Add(checkBoxPanel);

                        ((StackPanel)row)?.Children.Add(textBoxPanel);
                        
                        break;
                        
                    default:

                        MessageBox.Show("notfind");

                        break;
                }
            };

        }
    }
}
