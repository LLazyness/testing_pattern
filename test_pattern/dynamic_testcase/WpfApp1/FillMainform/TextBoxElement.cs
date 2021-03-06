﻿using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.FillMainform
{
    internal class TextBoxElement
    {
        
        public TextBox GetTextBox { get; } = new TextBox();

        public TextBoxElement(short count, double width, double height)
        {
            GetTextBox.Width = width;
            GetTextBox.Name = "id";
            GetTextBox.Height = height;
            GetTextBox.Margin = new Thickness(5,5,5,5);
            GetTextBox.VerticalAlignment = VerticalAlignment.Center;
            GetTextBox.FontSize = 14;
        }
    }
}
