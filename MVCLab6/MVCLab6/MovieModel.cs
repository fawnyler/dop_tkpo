using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MVCLab6
{
    public class MovieModel : Observable
    {
        private readonly List<Movie> movies;

        public MovieModel()
        {
            movies = new List<Movie>
            {
                new Movie("Inception", "Начало: Захватывающий триллер, снятый Кристофером Ноланом."),
                new Movie("The Matrix", "Матрица: Хакер обнаруживает антиутопическое будущее."),
                new Movie("Interstellar", "Интерстеллар: Драма о космических исследованиях.")
            };
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public Movie FindMovie(string name)
        {
            return movies.Find(m => m.Name == name);
        }

        public Subtitle GetSubtitles(string movieName, string language)
        {
            string filePath = $@"D:\tkpo\MVCLab6\MVCLab6\Subtitles\{movieName}_{language}.txt";
            if (File.Exists(filePath))
            {
                return new Subtitle(language, filePath);
            }
            return null;
        }

        public void NotifyModelUpdate()
        {
            NotifyObservers(); 
        }
    }

    // Класс для фильма
    public class Movie
    {
        public string Name { get; }
        public string Description { get; }

        public Movie(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

    // Класс для субтитров
    public class Subtitle
    {
        public string Language { get; }
        public string FilePath { get; }

        public Subtitle(string language, string filePath)
        {
            Language = language;
            FilePath = filePath;
        }

        public string GetContent()
        {
            return File.ReadAllText(FilePath, Encoding.UTF8);
        }
    }
}
