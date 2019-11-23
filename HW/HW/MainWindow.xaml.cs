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
            browserWB.Navigate(new Uri(urlTB.Text, UriKind.RelativeOrAbsolute));
        }

        private void AddBtnClick(object sender, RoutedEventArgs e)
        {
            //Пытался сделать независимую вкладку, типо 2разных сайта, не смог склонировать объект.
            //как в структуре obj1 = obj2 и они 2 разных объекта.
            tabControl.Items.Add(new TabItem
            {
                Header = new TextBlock { Text = "Вкладка" },
                Content = tabSP
            });
        }
    }
}
