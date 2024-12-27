using System.Collections.Generic;

namespace MVCLab6
{
    public class MovieController
    {
        private readonly MovieModel model;

        public MovieController()
        {
            model = new MovieModel();
        }

        // ��������� ������ �������
        public List<string> GetMovies()
        {
            var movies = model.GetMovies();
            var movieList = new List<string>();
            foreach (var movie in movies)
            {
                movieList.Add(movie.Name);
            }
            return movieList;
        }

        // ��������� �������� ������
        public string GetMovieDescription(string movieName)
        {
            var movie = model.FindMovie(movieName);
            return movie?.Description ?? "���������� ����������.";
        }

        // ��������� ���������
        public string GetSubtitles(string movieName, string language)
        {
            var subtitles = model.GetSubtitles(movieName, language);
            return subtitles?.GetContent() ?? "�������� �� �������.";
        }
    }
}
