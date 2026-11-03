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

namespace DiaryApp.Windows.Films
{
    /// <summary>
    /// Логика взаимодействия для AddAndEditFilmWindow.xaml
    /// </summary>
    public partial class AddAndEditFilmWindow : Window
    {
        public bool flag = true;
        public AddAndEditFilmWindow()
        {
            InitializeComponent();

            if (flag)
            {
                Title = "ADDDDDD";
            }

        }

        private void butAddOrSave_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                butAddOrSave.Content = "SAVEEE";
            }
        }

        private void butCancel_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
