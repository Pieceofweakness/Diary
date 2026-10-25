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
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void booksBut_Click(object sender, RoutedEventArgs e)
        {
            BooksWindow booksWindow = new BooksWindow();
            booksWindow.Show();
            this.Hide();
        }

        private void filmsBut_Click(object sender, RoutedEventArgs e)
        {
            FilmsWindow filmsWindow = new FilmsWindow();
            filmsWindow.Show();
            this.Hide();
        }

        private void gamesBut_Click(object sender, RoutedEventArgs e)
        {
            GamesWindow gamesWindow = new GamesWindow();
            gamesWindow.Show();
            this.Hide();
        }
    }
}
