using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.StackPanels;

namespace WpfApp1.FillMainform
{
    internal class ButtonDelete:Id
    {
        private readonly Button _button = new Button();

        

        public Button DeleteTestCase(short count)
        {
            var bitimg = new BitmapImage();

            var id = GetId();
            AddId(GetId());
            bitimg.BeginInit();

            bitimg.UriSource = new Uri("pack://application:,,,/WpfApp1;component/picture/cancel (1).ico", UriKind.RelativeOrAbsolute);

            bitimg.EndInit();

            var img = new Image
            {
                Stretch = Stretch.Fill,
                Source = bitimg
            };
            
            // Set Button.Content

            _button.Content = img;
            
            // Set Button.Background

            _button.Background = new ImageBrush(bitimg);

            _button.HorizontalAlignment = HorizontalAlignment.Right;

            _button.Margin = new Thickness(650,10,0,0);

            _button.VerticalAlignment = VerticalAlignment.Top;

            _button.Width = 20;

            _button.Height = 20;

            _button.Name = "deleteTestcase" + id;
            _button.Uid = id.ToString();



            _button.Click += (sender, args) =>
            {
               var mainblock = (StackPanel)((Border)((StackPanel)_button.Parent).Parent).Parent;
                var border = LogicalTreeHelper.FindLogicalNode(mainblock, "border" + id); 
              ((StackPanel)((Border)((StackPanel)_button.Parent).Parent).Parent).Children.Remove((UIElement) border);
                DropId(id);
            };

            return _button;
        }
    }
}
