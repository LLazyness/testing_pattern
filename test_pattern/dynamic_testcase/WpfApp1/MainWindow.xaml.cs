using System.Windows;
using System.Windows.Controls;
using WpfApp1.FillMainform;
using System;
using System.Windows.Media;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WpfApp1.StackPanels;


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
            MainPanel.MainBlockPanel = MainBlock;
            var testcase = new TestCase().CreateStackPanel();
            var border = new Border
            {
                Child = testcase,
                BorderThickness = new Thickness(),
                Background = Brushes.CadetBlue,
                Name = "border"+ testcase.Uid,
                HorizontalAlignment = HorizontalAlignment.Left
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
                        IResult successResult = new SuccessPanel();

                        var urlElement = LogicalTreeHelper.FindLogicalNode(MainBlock, "url" + i);

                        var urlContent = (urlElement as TextBox)?.Text;

                        var idElement = LogicalTreeHelper.FindLogicalNode(rows, "id");

                        var idContent = (idElement as TextBox)?.Text;

                        var chrome = new ChromeDriver();

                        StackPanel currentRow = (StackPanel)LogicalTreeHelper.FindLogicalNode(rows, "row" + j);
                        var countrow = currentRow.Children.Count;

                        StackPanel currentStatus = (StackPanel)currentRow.Children[countrow - 1];
                        if (currentStatus.Name == "Success" || currentStatus.Name == "Error")
                            currentRow.Children.RemoveAt(countrow - 1);
                        if (string.IsNullOrEmpty(urlContent)) urlContent = "http://google.com";
                        if (string.IsNullOrEmpty(idContent)) idContent = "lst-ib";
                        try
                        {
                            chrome.Navigate().GoToUrl(urlContent);
                        }
                        catch
                        {
                            
                            chrome.Quit();

                        }

                        
                        try
                        {
                            var query = chrome.FindElement(By.Id(idContent));
                            query.SendKeys("Фуряева Марина");
                            query.Submit();
                            chrome.Quit();
                            var successPanel = successResult.CreateStackPanel();
                            currentRow.Children.Add(successPanel);
                        }
                        catch
                        {
                            chrome.Quit();
                            IResult errorResult = new ErrorPanel();
                            var errorPanel = errorResult.CreateStackPanel();
                            currentRow.Children.Add(errorPanel);
                        }


                    }

                }
            }
        }
    }
}
