using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace WpfApp1.FillMainform
{
    class TestCaseTextBox
    {
        public TextBox CreateUrl(short count)
        {
            var url = new TextBox
            {
                Width = 80,
                Height = 30,
                Name = "url"
            };
            // url.Margin = new System.Windows.Thickness(0, 5, 5, 5);
            return url;
        }

        public TextBox CreateId(short count)
        {
            TextBox id = new TextBox
            {
                Width = 80,
                Height = 30,
                Name = "id"
            };
            //id.Margin = new System.Windows.Thickness(0, 5, 5, 5);
            return id;
        }
    }
}
