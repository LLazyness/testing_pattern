using System.Windows;
using System.Windows.Controls;
using WpfApp1.FillMainform;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            


        }

        private void Add_test_case_click(object sender, RoutedEventArgs e)
        {
            // ReSharper disable once ObjectCreationAsStatement
            
            var countOfTestcase = (short)MainBlock.Children.Count; // кол-во тест кейсов
            ICreateForm item = new CreateForm();
            var textbox = new TestCaseTextBox();
            var butt = new ButtonOfTestCase();
            var button1 = butt.TestCaseButton(countOfTestcase, MainBlock);
            var url = textbox.CreateUrl(countOfTestcase);
            var combobox = item.CreateComboBox(countOfTestcase, 135.0, 30.0);
            var navStackPanel = item.CreateRowTestCase(countOfTestcase, 120.0);
            var rowsTestcase = item.CreateRowTestCase(countOfTestcase, 401.0);
            var rowTestCase = item.CreateRowTestCase(countOfTestcase, 400.0);
            var id = textbox.CreateId(countOfTestcase);
            rowTestCase.VerticalAlignment = VerticalAlignment.Center;
            var testcase = item.CreateTestCase(countOfTestcase);
            var labelUrl = item.CreateLabel(countOfTestcase, "labelUrl");
            var labelId = item.CreateLabel(countOfTestcase, "labelId");
            


            navStackPanel.Orientation = Orientation.Vertical;
            navStackPanel.VerticalAlignment = VerticalAlignment.Center;
            navStackPanel.Margin = new Thickness(10, 10, 10, 10);
            navStackPanel.Children.Add(button1);
            navStackPanel.Children.Add(labelUrl);
            navStackPanel.Children.Add(url);
            navStackPanel.Children.Add(labelId);
            navStackPanel.Children.Add(id);
            navStackPanel.Name = "nav";
            testcase.Children.Add(navStackPanel);
            

            rowTestCase.Children.Add(combobox);
            rowsTestcase.Children.Add(rowTestCase);
            testcase.Children.Add(rowsTestcase);
            MainBlock.Children.Add(testcase);
            
        }

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
