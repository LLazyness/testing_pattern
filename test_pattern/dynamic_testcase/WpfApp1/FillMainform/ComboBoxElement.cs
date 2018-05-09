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
            GetComboBox.Items.Add("Перейти по ссылке");
            GetComboBox.Items.Add("Сравнить значение  в \nопределенном элементе");
            GetComboBox.Items.Add("Выполнить клик \n по элементу");
            GetComboBox.Items.Add("Сравнить значение \n атрибута у элемента");
            GetComboBox.Items.Add("Получить значение \n атрибута css");
            GetComboBox.Items.Add("Проверка URL \n страницы");
            GetComboBox.SelectedItem = GetComboBox.Items.GetItemAt(0);
            
           
            GetComboBox.VerticalContentAlignment = VerticalAlignment.Center;
            GetComboBox.HorizontalContentAlignment = HorizontalAlignment.Center;
            GetComboBox.Margin = new Thickness(5, 0, 5, 5);
            GetComboBox.Background = (Brush)_bc.ConvertFrom("#fcfcfc");

            

            GetComboBox.SelectionChanged += (sender, args) =>
            {
                var checkBoxPanel = new StackPanelElement(count, 30).GetStackPanelOfCheckBox();
                checkBoxPanel.VerticalAlignment = VerticalAlignment.Bottom;
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

                        checkBoxPanel.VerticalAlignment = VerticalAlignment.Bottom;

                        var textBoxPanel = new StackPanelElement(count, 10).GetTextBoxPanel();

                        textBoxPanel.Children.Add(ob.CreateLabel(count, "insertedValue"));

                        textBoxPanel.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);


                        ((StackPanel)row)?.Children.Add(processInsertValueToElement);

                        ((StackPanel)row)?.Children.Add(checkBoxPanel);

                        ((StackPanel)row)?.Children.Add(textBoxPanel);
                        
                        break;
                    case "Перейти по ссылке":

                        GetComboBox.Width = 190;
                        
                        checkBoxPanel.Children.Add(new CreateForm().CreateLabel(count, "URL"));

                        checkBoxPanel.Children.Add(new CreateForm().CreateCheckBox());
                        
                        var urlTextBox = new TextBoxGoToUrl();

                        ((StackPanel)row)?.Children.Add(urlTextBox.CreateUrlTextBox());

                        ((StackPanel)row)?.Children.Add(checkBoxPanel);

                        break;
                    case "Сравнить значение  в \nопределенном элементе":
                        var processFindElementPanel1 = new StackPanelElement(count, 10).GetStackPanelOfProcessFindElement();

                        processFindElementPanel1.Children.Add(ob.CreateLabel(count, "Идентификатор"));

                        processFindElementPanel1.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);

                        checkBoxPanel.Children.Add(new CreateForm().CreateLabel(count, "checkbox"));

                        checkBoxPanel.Children.Add(new CreateForm().CreateCheckBox());

                        var processFindElementPanel2 = new StackPanelElement(count, 10).GetStackPanelOfProcessFindElement();

                        processFindElementPanel2.Children.Add(ob.CreateLabel(count, "Сравнить"));

                        processFindElementPanel2.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);

                        ((StackPanel)row)?.Children.Add(processFindElementPanel1);

                        ((StackPanel)row)?.Children.Add(checkBoxPanel);

                        ((StackPanel)row)?.Children.Add(processFindElementPanel2);

                        
                        break;
                    case "Выполнить клик \n по элементу":
                        var processFindElementPanel3 = new StackPanelElement(count, 10).GetStackPanelOfProcessFindElement();

                        processFindElementPanel3.Children.Add(ob.CreateLabel(count, "Идентификатор"));

                        processFindElementPanel3.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);

                        checkBoxPanel.Children.Add(new CreateForm().CreateLabel(count, "checkbox"));

                        checkBoxPanel.Children.Add(new CreateForm().CreateCheckBox());

                        ((StackPanel)row)?.Children.Add(processFindElementPanel3);

                        ((StackPanel)row)?.Children.Add(checkBoxPanel);

                        break;
                    case "Сравнить значение \n атрибута у элемента":
                        var processFindElementPanel4 = new StackPanelElement(count, 10).GetStackPanelOfProcessFindElement();

                        processFindElementPanel4.Children.Add(ob.CreateLabel(count, "Идентификатор"));

                        processFindElementPanel4.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);

                        checkBoxPanel.Children.Add(new CreateForm().CreateLabel(count, "checkbox"));

                        checkBoxPanel.Children.Add(new CreateForm().CreateCheckBox());

                        ComboBoxElementSe obj = new ComboBoxElementSe();


                        var texb = new StackPanelElement(count, 10).GetProcessInsertValueToTextBox();

                        texb.Children.Add(ob.CreateLabel(count, "Сравнить"));

                        texb.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);

                        ((StackPanel)row)?.Children.Add(processFindElementPanel4);

                        ((StackPanel)row)?.Children.Add(checkBoxPanel);

                        ((StackPanel)row)?.Children.Add(obj.cmb);

                        ((StackPanel)row)?.Children.Add(texb);
                        break;
                    case "Получить значение \n атрибута css":

                        var processFindElementPanel5 = new StackPanelElement(count, 10).GetStackPanelOfProcessFindElement();

                        processFindElementPanel5.Children.Add(ob.CreateLabel(count, "Идентификатор"));

                        processFindElementPanel5.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);

                        checkBoxPanel.Children.Add(new CreateForm().CreateLabel(count, "checkbox"));

                        checkBoxPanel.Children.Add(new CreateForm().CreateCheckBox());

                        ComboBoxAttrCss obj1 = new ComboBoxAttrCss();


                        var texb1 = new StackPanelElement(count, 10).GetProcessInsertValueToTextBox();

                        texb1.Children.Add(ob.CreateLabel(count, "Сравнить"));

                        texb1.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);

                        ((StackPanel)row)?.Children.Add(processFindElementPanel5);

                        ((StackPanel)row)?.Children.Add(checkBoxPanel);

                        ((StackPanel)row)?.Children.Add(obj1.cmbcss);

                        ((StackPanel)row)?.Children.Add(texb1);
                        break;
                    case "Проверка URL \n страницы":
                        var texb2 = new StackPanelElement(count, 10).GetProcessInsertValueToTextBox();

                        texb2.Children.Add(ob.CreateLabel(count, "checkURL"));

                        texb2.Children.Add(new TextBoxElement(count, 80.0, 30.0).GetTextBox);

                        ((StackPanel)row)?.Children.Add(texb2);
                        break;
                    default:

                        MessageBox.Show("notfind");

                        break;
                }
            };

        }
    }
}
