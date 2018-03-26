using System.Windows.Controls;

namespace WpfApp1.FillMainform
{
    internal interface ICreateForm
    {
        ComboBox CreateComboBox(short count, double width, double height);
        Label CreateLabel();
        DockPanel CreateDocPanel(DockPanel mainDockPanel, int id);
        Border CreateBorder();
        StackPanel CreateStackPanel();
        StackPanel CreateTestCase(short countOftestCase);
        StackPanel CreateRowTestCase(short countOfRows, double width);
        Button CreateButton(short countOfButton);
        Label CreateLabel (short count, string label);
    }
}
