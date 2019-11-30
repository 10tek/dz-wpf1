using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchBtnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var browser = new WebBrowser();
                browser.Navigate(urlTB.Text);
                
                tabControl.Items.Add(new TabItem
                {
                    Height = 20,
                    Width = 80,
                    Header = "Вкладка",
                    Content = (browser as WebBrowser)
                });

                urlTB.Text = "https://www.";
            }
            catch
            {
                MessageBox.Show("введите в формате https://google.com");
            }
        }
    }
}
