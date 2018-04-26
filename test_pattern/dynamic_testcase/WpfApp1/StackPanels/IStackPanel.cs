using System.Windows.Controls;

namespace WpfApp1.StackPanels
{
    internal interface IStackPanel
    {
      StackPanel CreateStackPanel();

      void AddChildren();
    }
}
