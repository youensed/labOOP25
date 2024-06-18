using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOP_25
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\VideoFilms.accdb";
            connection = new OleDbConnection(connectionString);
            Directors();
            Geners();
            Films();
        }

        private void Video_Load(object sender, EventArgs e)
        {
            this.moviesTableAdapter.Fill(this.videoFilmsDataSet.Movies);
        }

        private void Films()
        {
            string query = "SELECT Movies.MovieID, Movies.Title, Movies.ReleaseYear, Directors.Name as Director, Genres.GenreName as Genre " +
                           "FROM ((Movies " +
                           "INNER JOIN Directors ON Movies.DirectorID = Directors.DirectorID) " +
                           "INNER JOIN Genres ON Movies.GenreID = Genres.GenreID)";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewMovies.DataSource = table;
        }

        private void Directors()
        {
            string query = "SELECT DirectorID, Name FROM Directors";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxDirector.DataSource = table;
            comboBoxDirector.DisplayMember = "Name";
            comboBoxDirector.ValueMember = "DirectorID";
        }

        private void Geners()
        {
            string query = "SELECT GenreID, GenreName FROM Genres";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxGenre.DataSource = table;
            comboBoxGenre.DisplayMember = "GenreName";
            comboBoxGenre.ValueMember = "GenreID";
        }

        private bool CounterOfMovies(string title)
        {
            string query = "SELECT COUNT(*) FROM Movies WHERE Title = @Title";
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Title", title);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }

        private void Add(string title, int year, int directorId, int genreId)
        {
            try
            {
                string query = "INSERT INTO Movies (Title, ReleaseYear, DirectorID, GenreID) VALUES (@Title, @Year, @DirectorID, @GenreID)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@DirectorID", directorId);
                    command.Parameters.AddWithValue("@GenreID", genreId);

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    command.ExecuteNonQuery();
                    connection.Close();

                    Films();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void FirstReport()
        {
            string query = "SELECT Directors.Name, COUNT(Movies.MovieID) AS MovieCount " +
                           "FROM Movies " +
                           "INNER JOIN Directors ON Movies.DirectorID = Directors.DirectorID " +
                           "GROUP BY Directors.Name";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewReport.DataSource = table;
        }

        private void SecondReport()
        {
            string query = "SELECT Genres.GenreName, COUNT(Movies.MovieID) AS MovieCount " +
                           "FROM Movies " +
                           "INNER JOIN Genres ON Movies.GenreID = Genres.GenreID " +
                           "GROUP BY Genres.GenreName";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewReport.DataSource = table;
        }

        private void Search(string title)
        {
            string query = "SELECT Movies.MovieID, Movies.Title, Movies.ReleaseYear, Directors.Name as Director, Genres.GenreName as Genre " +
                                   "FROM ((Movies " +
                                   "INNER JOIN Directors ON Movies.DirectorID = Directors.DirectorID) " +
                                   "INNER JOIN Genres ON Movies.GenreID = Genres.GenreID) " +
                                   "WHERE Movies.Title LIKE @Title";

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Title", "%" + title + "%");

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewMovies.DataSource = table;
            }
        }

        private void buttonLoadMovies_Click(object sender, EventArgs e)
        {
            Films();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
            string.IsNullOrWhiteSpace(textBoxYear.Text) ||
            comboBoxDirector.SelectedValue == null ||
            comboBoxGenre.SelectedValue == null)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля перед додаванням фільму.");
                return;
            }

            if (int.TryParse(textBoxYear.Text, out int year) &&
                int.TryParse(comboBoxDirector.SelectedValue.ToString(), out int directorId) &&
                int.TryParse(comboBoxGenre.SelectedValue.ToString(), out int genreId))
            {
                string title = textBoxTitle.Text;

                if (CounterOfMovies(title))
                {
                    MessageBox.Show("Фільм з таким заголовком вже існує.");
                    return;
                }

                Add(title, year, directorId, genreId);
            }
            else
            {
                MessageBox.Show("Перевірте правильність введених даних.");
            }
        }

        private void buttonReportByDirector_Click(object sender, EventArgs e)
        {
            FirstReport();
        }

        private void buttonReportByGenre_Click(object sender, EventArgs e)
        {
            SecondReport();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string title = textBoxSearchTitle.Text;
            Search(title);
        }
    }
}
