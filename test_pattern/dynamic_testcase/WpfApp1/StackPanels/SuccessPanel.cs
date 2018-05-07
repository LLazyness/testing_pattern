using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1.StackPanels
{
    internal class SuccessPanel:IResult
    {
        private readonly StackPanel _successPanel = new StackPanel();
        public StackPanel CreateStackPanel()
        {
            _successPanel.Width = 40;
            _successPanel.Height = 40;
            _successPanel.Background = new ImageBrush(new BitmapImage(
                new Uri("pack://application:,,,/WpfApp1;component/picture/icons8-ok-40.png")));
            //AddChildren();
            return _successPanel;
        }

        
    }
}
