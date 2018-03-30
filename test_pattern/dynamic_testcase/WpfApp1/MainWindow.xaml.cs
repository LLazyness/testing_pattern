using System.Windows;
using System.Windows.Controls;
using WpfApp1.FillMainform;
using System;
using System.Windows.Media;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WpfApp1
{
    /// <inheritdoc cref="" />
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
            MainPanel.MainBlockPanel = MainBlock;
            var countOfTestcase = (short)MainBlock.Children.Count; // кол-во тест кейсов
            ICreateForm item = new CreateForm();
            ButtonDelete del = new ButtonDelete();
            var textbox = new TestCaseTextBox();
            var butt = new ButtonOfTestCase();
            var button1 = butt.TestCaseButton(countOfTestcase, MainBlock);
            var url = textbox.CreateUrl(countOfTestcase);
            
            var navStackPanel = item.CreateRowTestCase(countOfTestcase, 120.0);
            var rowsTestcase = item.CreateRowTestCase(countOfTestcase, 401.0);
            var rowTestCase = item.CreateRowTestCase(countOfTestcase, 400.0);
            var countOfRows = rowTestCase.Children.Count;
            var combobox = item.CreateComboBox((short)countOfRows, 135.0, 30.0);
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

            testcase.Children.Add(del.DeleteTestCase(countOfTestcase));
            var border = new Border
            {
                Child = testcase,
                BorderThickness = new Thickness(),
                Background = Brushes.CadetBlue,
                Name = "border"+countOfTestcase
            };
            MainBlock.Children.Add(border);
            
        }

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Execute_OnClick(object sender, RoutedEventArgs e)
        {
            var countOftestcase = MainBlock.Children.Count;
            
            for (int i = 0; i < countOftestcase; i++)
            {
                var rows = LogicalTreeHelper.FindLogicalNode(MainBlock, "rows" + i);
                var countOfRow = ((StackPanel) rows).Children.Count;
                for (var j = 0; j < countOfRow; j++)
                {
                    var currentAction = LogicalTreeHelper.FindLogicalNode(rows, "ComboBox" + j);
                    if ((currentAction as ComboBox)?.SelectedItem == "Найти элемент")
                    {
                        var urlElement = LogicalTreeHelper.FindLogicalNode(MainBlock, "url" + i);

                        var urlContent = (urlElement as TextBox)?.Text;

                        var idElement = LogicalTreeHelper.FindLogicalNode(rows, "id");

                        var idContent = (idElement as TextBox)?.Text;

                        var chrome = new ChromeDriver();
                        if (String.IsNullOrEmpty(urlContent)) urlContent = "http://google.com";
                        chrome.Navigate().GoToUrl(urlContent);
                        if ( String.IsNullOrEmpty(idContent)) idContent = "lst-ib";
                       
                        var query = chrome.FindElement(By.Id(idContent));
                        query.SendKeys("Фуряева Марина");
                        query.Submit();
                        

                    }

                }
            }
        }
    }
}
