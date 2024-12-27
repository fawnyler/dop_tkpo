using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace MVCLab6
{
    public partial class Form1 : Form, IMovieObserver // Form1 наследует IMovieObserver
    {
        private readonly MovieController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new MovieController();
            InitializeMovieList();

            // Создаем модель и добавляем Form1 как наблюдателя
            var model = new MovieModel();
            model.AddObserver(this); 
        }

        private void InitializeMovieList()
        {
            // Инициализация списка фильмов через контроллер
            var movies = controller.GetMovies();
            foreach (var movie in movies)
            {
                movieComboBox.Items.Add(movie);
            }
            movieComboBox.SelectedIndex = 0; 
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            // Проверка выбора языка
            if (!englishRadioButton.Checked && !russianRadioButton.Checked)
            {
                MessageBox.Show("Выберите язык перед отображением субтитров.", "Язык не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMovie = movieComboBox.SelectedItem.ToString();
            string language = englishRadioButton.Checked ? "en" : "ru";

            // Отображение информации о фильме
            movieInfoTextBox.Text = controller.GetMovieDescription(selectedMovie);

            // Отображение субтитров
            subtitlesTextBox.Text = controller.GetSubtitles(selectedMovie, language);
        }

        // Реализуем метод обновления из интерфейса IMovieObserver
        public new void Update()  
        {
            MessageBox.Show("Модель была обновлена!");
        }
    }
}
