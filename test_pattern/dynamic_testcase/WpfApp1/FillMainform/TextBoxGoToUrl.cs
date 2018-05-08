using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.FillMainform
{
    class TextBoxGoToUrl
    {
        TextBox urlTextBox = new TextBox();

        public TextBox CreateUrlTextBox()
        {
            urlTextBox.Name = "urltextBox";
            urlTextBox.Width = 80;
            urlTextBox.Height = 20;
            urlTextBox.Margin = new Thickness(5, 5, 5, 5);
            urlTextBox.VerticalAlignment = VerticalAlignment.Bottom;
            return urlTextBox;
        }
    }
}
