using DiaryApp.Data.Films;
using DiaryApp.Models;
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
        public string filmName;
        public string directorFilm;
        public DateOnly? startFilm;
        public DateOnly? finishFilm;
        public string statusFilm;
        public float gradeFilm;
        public string noteFilm;

        private FilmsRepository filmsRepository;

        public AddAndEditFilmWindow(bool NewFilm)
        {
            InitializeComponent();
            filmsRepository = new FilmsRepository();


            if (NewFilm)
            {
                Title = "Добавление нового фильма";
                butAddOrSave.Content = "Добавить";
            }

        }

        private void butAddOrSave_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
            statusFilm = SelectedStatus(statusFilm);

            if (string.IsNullOrEmpty(filmName))
            {
                MessageBox.Show("Введите название фильма");
                return;
            }
            
            if (startFilm == null)
            {
                MessageBox.Show("Введите начало просмотра фильма");
                return;
            }

            if (startFilm > finishFilm)
            {
                MessageBox.Show("Начало не может быть больше конца");
                return;
            }

            if (statusFilm == "Undefinded")
            {
                MessageBox.Show("Выберите статус фильма");
                return;
            }

            if (gradeFilm < 0)
            {
                MessageBox.Show("Введите оценку фильма");
                return;
            }

            var film = new Film
            {
                name_film = filmName,
                director = directorFilm,
                start = startFilm,
                finish = finishFilm,
                status = statusFilm,
                grade = gradeFilm,
                note = noteFilm,
            };

            try
            {
                bool result = filmsRepository.AddFilm(film);

                if (result)
                {
                    MessageBox.Show("Новый фильм успешно добавлен");
                    this.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Не удалось добавить фильм - {ex.Message}");
            }


            

        }

        private void butCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            filmName = txtNameFilm.Text;
            directorFilm = txtDirectorFilm.Text;
            if (dateStartFilm.SelectedDate.HasValue)
                startFilm = DateOnly.FromDateTime(dateStartFilm.SelectedDate.Value);
            else
                startFilm = null;

            if (dateFinishFilm.SelectedDate.HasValue)
                finishFilm = DateOnly.FromDateTime(dateFinishFilm.SelectedDate.Value);
            else
                finishFilm = null;

            if (cmbStatusFilm.SelectedItem is ComboBoxItem selectedLayout)
            {
                statusFilm = selectedLayout.Content.ToString();
            }
            else
            {
                statusFilm = cmbStatusFilm.Text;
            }
            gradeFilm = (float)slidGradeFilm.Value;
            noteFilm = txtNoteFilm.Text;

        }



        private string SelectedStatus(string status)
        {
            switch (status)
            {
                case "В процессе":
                    return "active";
                case "Брошен":
                    return "droped";
                case "Завершен":
                    return "finished";
                default:
                    return "Undefinded";
            }

        }



        private void Window_Closed(object sender, EventArgs e)
        {
            FilmsWindow filmWindow = new FilmsWindow();
            filmWindow.Show();
        }




    }



}
