using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1.FillMainform
{
    class CreateForm: Window, ICreateForm
    {
        readonly BrushConverter _bc = new BrushConverter();
        StackPanel _panel = new StackPanel();
        public ComboBox CreateComboBox(short count, double width, double height)
        {
            var itemComboBox = new ComboBoxElement(count,width,height);
            return itemComboBox.GetComboBox;

        }

        public Label CreateLabel()
        {
            var itemLabel = new Label
            {
                Width = 60,
                Height = 45,
                Content = "2"
            };
            DockPanel.SetDock(itemLabel, Dock.Left);
            itemLabel.HorizontalAlignment = HorizontalAlignment.Left;
           
            return itemLabel;
            
        }

        public Border CreateBorder()
        {
            var itemBorder = new Border
            {
                BorderBrush = Brushes.Red,
                BorderThickness = new Thickness(2)
            };

            return itemBorder;
        }
        
        public DockPanel CreateDocPanel(DockPanel mainDockPanel, int id)
        {
            var itemDockPanel = new DockPanel
            {
                Width = mainDockPanel.Width,
                Height = mainDockPanel.Height,
                HorizontalAlignment = mainDockPanel.HorizontalAlignment,
                VerticalAlignment = mainDockPanel.VerticalAlignment,
                Margin = mainDockPanel.Margin
            };


            var dPanel = new SetName<DockPanel>();
            itemDockPanel.Uid = dPanel.Set_id(itemDockPanel, id).Uid;
            
            return itemDockPanel;
        }

        
        public StackPanel CreateStackPanel()
        {
            var stackpanel = new StackPanel();
            var border = CreateBorder();
            var button = new Button
            {
                Height = 30,
                Width = 50
            };
            border.Child = button;
            stackpanel.Width = 600;
            stackpanel.HorizontalAlignment = HorizontalAlignment.Right;
            stackpanel.VerticalAlignment = VerticalAlignment.Center;
            stackpanel.Children.Add(border);
            
            return stackpanel;
        }

        
        public StackPanel CreateRowTestCase(short countOfRows, double width)
        {
            var row = new StackPanelElement(countOfRows, width);
            _panel = row.GetRowTestCase;
            _panel.Margin = new Thickness(10, 10, 10, 10);
            return _panel;
        }
        public Button CreateButton(short countOfButton) 
        {
            var button = new Button
            {
                Width = 80,
                Height = 35,
                Margin = new Thickness(10, 10, 10, 10),
                Background = (Brush) _bc.ConvertFrom("#fcfcfc"),
                Content = "Действие"
            };

            return button;
        }        
        public Label CreateLabel(short count, string name)
        {
            var label = new Label
            {
                Width = 120,
                Height = 25,
            };
            switch (name)
            {
                case "labelUrl":
                    label.Content = "Глобальный URL";
                    break;
                case "labelId":
                    label.Content = "Глобальный ID";
                    break;
                case "Идентификатор":
                    label.Content = "Идентификатор";
                    label.Width = 100;
                    break;
                case "insertedValue":
                    label.Content = "Вводимое значение";
                    label.Width = 120;
                    break;
                case "checkbox":
                    label.Content = "Глобальный \n идентификатор";
                    label.Width = 100;
                    label.Height = 40;
                    label.VerticalAlignment = VerticalAlignment.Bottom;
                    break;
                case "URL":
                    label.Content = "URL";
                    label.Width = 50;
                    label.Height = 40;
                    label.VerticalAlignment = VerticalAlignment.Bottom;
                    break;
                case "Сравнить":
                    label.Content = "Сравниваемое \n значение";
                    label.Width = 100;
                    label.Height = 40;
                    label.VerticalAlignment = VerticalAlignment.Bottom;
                    break;
                case "click":
                    label.Content = "Идентификатор\n элемента";
                    label.Width = 120;
                    label.Height = 40;
                    break;

                case "checkURL":
                    label.Content = "Сравниваемый\n адрес";
                    label.Height = 40;

                    break;
            }

            label.HorizontalAlignment = HorizontalAlignment.Right;
            label.Foreground = (Brush)_bc.ConvertFrom("#ffffff");
            return label;
        }

        public CheckBox CreateCheckBox()
        {
            var checkbox = new CheckBox
            {
                Width = 30,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Bottom,
                //Margin = new Thickness(0,0,0,0)
            };
            checkbox.Click += (sender, args) =>
            {
                var panelFindElement = ((StackPanel) ((StackPanel) checkbox.Parent).Parent).Children[1];

                var textbox = ((StackPanel) panelFindElement).Children[1];

                if ( (bool) checkbox.IsChecked)
                {
                    var testcase = ((StackPanel) ((StackPanel) ((StackPanel) checkbox.Parent).Parent).Parent).Parent;

                    var testcaseUid = ((StackPanel)testcase).Uid;

                    var globalId = LogicalTreeHelper.FindLogicalNode((StackPanel) testcase, "id"+testcaseUid);



                    ((TextBox) textbox).Text = ((TextBox) globalId)?.Text;
                }
                else
                {
                    ((TextBox) textbox).Text = "";
                }
            };
            return checkbox;
        }
    }
}
