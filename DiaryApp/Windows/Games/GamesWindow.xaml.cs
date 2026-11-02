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
using System.Windows.Shapes;

namespace DiaryApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для GamesWindow.xaml
    /// </summary>
    public partial class GamesWindow : Window
    {
        public GamesWindow()
        {
            InitializeComponent();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
        }



        private void butAddNewGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void butEditGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void butDeleteGame_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
