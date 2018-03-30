using System.Windows.Controls;

namespace WpfApp1.FillMainform
{
    internal class TestCaseTextBox
    {
        public TextBox CreateUrl(short count)
        {
            var url = new TextBox
            {
                Width = 80,
                Height = 30,
                Name = "url"+count
            };
            // url.Margin = new System.Windows.Thickness(0, 5, 5, 5);
            return url;
        }

        public TextBox CreateId(short count)
        {
            var id = new TextBox
            {
                Width = 80,
                Height = 30,
                Name = "id"+count
            };
            //id.Margin = new System.Windows.Thickness(0, 5, 5, 5);
            return id;
        }
    }
}
