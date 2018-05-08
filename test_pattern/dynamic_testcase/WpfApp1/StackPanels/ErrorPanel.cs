using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1.StackPanels
{
    internal class ErrorPanel:IResult
    {
        private readonly StackPanel _errorPanel = new StackPanel();
        public StackPanel CreateStackPanel()
        {
            _errorPanel.Width = 40;
            _errorPanel.Height = 40;
            _errorPanel.Background = new ImageBrush(new BitmapImage(
                new Uri("pack://application:,,,/WpfApp1;component/picture/icons8-cancel-40.png")));
            _errorPanel.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            return _errorPanel;
        }

    }
}
