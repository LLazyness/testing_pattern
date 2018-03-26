﻿using System.Windows.Controls;
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
            var itemBorder = new Border();
            
            itemBorder.BorderBrush = Brushes.Red;
            itemBorder.BorderThickness = new Thickness(2);
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
            itemDockPanel.Uid = dPanel.set_id(itemDockPanel, id).Uid;
            
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

        public StackPanel CreateTestCase(short countOftestCase)
        {
            TestCase testCase = new TestCase(countOftestCase);
            var panel = testCase.GetTestcase;
            return panel;
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
                Name = name + count
            };
            if (name == "labelUrl")
                label.Content = "Глобальный URL";
            if (name == "labelId")
                label.Content = "Глобальный ID";
            label.HorizontalAlignment = HorizontalAlignment.Right;
            label.Foreground = (Brush)_bc.ConvertFrom("#11110f");
            return label;
        }
    }
}
