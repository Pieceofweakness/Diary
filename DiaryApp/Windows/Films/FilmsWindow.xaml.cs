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
using DiaryApp.Models;
using DiaryApp.Data;
using DiaryApp.Data.Films;
using DiaryApp.Windows;
using System.Collections.ObjectModel;
using DiaryApp.Windows.Films;

namespace DiaryApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для FilmsWindow.xaml
    /// </summary>
    public partial class FilmsWindow : Window
    {
        private FilmsRepository filmsRepository;
        private ObservableCollection<Film> films;
        public FilmsWindow()
        {
            InitializeComponent();
            filmsRepository = new FilmsRepository();
            films = new ObservableCollection<Film>(filmsRepository.GetAllFilms());

            FilmsGrid.ItemsSource = films;

        }
        private void Window_Closed(object sender, EventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
        }

        private void butAddNewFilm_Click(object sender, RoutedEventArgs e)
        {
            
            AddAndEditFilmWindow addNewFilm = new AddAndEditFilmWindow(true);
            addNewFilm.Show();
            this.Hide();
        }

        private void butEditFilm_Click(object sender, RoutedEventArgs e)
        {
            Film film = new Film();
            film.id_film = 5;
            film.name_film = "test123";
            film.director = "test123";
            film.start = new DateOnly(1999, 01, 01);
            film.finish = new DateOnly(2000, 01, 01);
            film.status = "droped";
            film.grade = 1.234f;
            film.note = "shit";

            try
            {
                filmsRepository.UpdateFilm(film);

                var updatedList = filmsRepository.GetAllFilms();
                films.Clear();

                foreach(var i in updatedList)
                {
                    films.Add(i);
                }

                MessageBox.Show("Фильм изменен");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void butDeleteFilm_Click(object sender, RoutedEventArgs e)
        {
            if (FilmsGrid.SelectedItem is Film selectedFilm)
            {
                var acceptWindow = MessageBox.Show($"Вы уверены в удалении фильма {selectedFilm.name_film}?","Подтверждение: ", MessageBoxButton.YesNo);

                if (acceptWindow == MessageBoxResult.Yes)
                {
                    try
                    {
                        bool success = filmsRepository.DeleteFilm(selectedFilm);
                        if (success)
                        {
                            films.Remove(selectedFilm);
                            MessageBox.Show($"Фильм {selectedFilm.name_film} успешно удален");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Не удалось удалить фильм, причина - {ex.Message}");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Сначала выберите фильм для удаления");
            }
        }

    }
}
