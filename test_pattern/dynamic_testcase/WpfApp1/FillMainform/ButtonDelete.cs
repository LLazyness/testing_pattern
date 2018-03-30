using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1.FillMainform
{
    internal class ButtonDelete
    {
        private readonly Button _button = new Button();

        

        public Button DeleteTestCase(short count)
        {
            var bitimg = new BitmapImage();

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

            _button.Margin = new Thickness(370,10,0,0);

            _button.VerticalAlignment = VerticalAlignment.Top;

            _button.Width = 20;

            _button.Height = 20;

            _button.Name = "deleteTestcase" + count;



            _button.Click += (sender, args) =>
            {
               var mainblock = (StackPanel)((Border)((StackPanel)_button.Parent).Parent).Parent;
                var border = LogicalTreeHelper.FindLogicalNode(mainblock, "border" + count);
              ((StackPanel)((Border)((StackPanel)_button.Parent).Parent).Parent).Children.Remove((UIElement) border);
            };

            return _button;
        }
    }
}
