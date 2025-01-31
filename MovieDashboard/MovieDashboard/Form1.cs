using System.Linq;
using MovieService;
namespace MovieServer
{
    public partial class Dashboard : Form
    {
        private IMovieService movieService;
        public Dashboard()
        {
            InitializeComponent();
            movieService = new MovieServices();

            MovieListBox.Text = movieService.InitialLoadMovieFromFile();
            MovieListBox.Multiline = true;

        }
        private void Form1_Load(object sender, EventArgs e){}
        //Navigation
        private void BttnPrevious_Click(object sender, EventArgs e)
        {
            Movie previousMovie = movieService.Previous();
            if (previousMovie != null)
            {
                MovieListBox.Text = $"Id: {previousMovie.Id}\n" +
                                    $"Title: {previousMovie.Title}\n" +
                                    $"Director: {previousMovie.Director}\n" +
                                    $"Year: {previousMovie.Year}";
                TitleInputBox.Text = previousMovie.Title;
                IDBox.Text = previousMovie.Id.ToString();
                CastInputBox.Text = previousMovie.Director;
                DateInputBox.Text = previousMovie.Year.ToShortDateString();
            }
            else
            {
                MovieListBox.Text = "You have Reached End of List!";
            }
        }
        private void BttnNext_Click(object sender, EventArgs e)
        {
            Movie NextMovie = movieService.Next();
            if (NextMovie != null)
            {
                MovieListBox.Text = $"Title: {NextMovie.Title}\n" +
                                    $"Director: {NextMovie.Director}\n" +
                                    $"Year: {NextMovie.Year}";

                TitleInputBox.Text = NextMovie.Title;
                IDBox.Text = NextMovie.Id.ToString();
                CastInputBox.Text = NextMovie.Director;
                DateInputBox.Text = NextMovie.Year.ToShortDateString();
            }
            else
            {
                MovieListBox.Text = "You have Reached End of List!";
            }
        }
        private void BttnFirst_Click(object sender, EventArgs e)
        {
            Movie firstMovie = movieService.First();
            if (firstMovie != null)
            {
                MovieListBox.Text = $"Title: {firstMovie.Title}\n" +
                                    $"Director: {firstMovie.Director}\n" +
                                    $"Year: {firstMovie.Year}";

                TitleInputBox.Text = firstMovie.Title;
                IDBox.Text = firstMovie.Id.ToString();
                CastInputBox.Text = firstMovie.Director;
                DateInputBox.Text = firstMovie.Year.ToShortDateString();
            }
            else
            {
                MovieListBox.Text = "No movies available.";
            }
        }
        private void BttnLast_Click(object sender, EventArgs e)
        {
            Movie lastMovie = movieService.Last();
            if (lastMovie != null)
            {
                MovieListBox.Text = $"Title: {lastMovie.Title}\n" +
                                    $"Director: {lastMovie.Director}\n" +
                                    $"Year: {lastMovie.Year}";

                TitleInputBox.Text = lastMovie.Title;
                IDBox.Text = lastMovie.Id.ToString();
                CastInputBox.Text = lastMovie.Director;
                DateInputBox.Text = lastMovie.Year.ToShortDateString();
            }
            else
            {
                MovieListBox.Text = "No movies available.";
            }
        }
        //List
        private void BttnAddToList(object sender, EventArgs e)
        {
            string title = TitleInputBox.Text.Trim();
            string director = CastInputBox.Text.Trim();
            DateTime year = DateInputBox.Value;
            int id = Convert.ToInt32(IDBox.Value);

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(director))
            {
                MessageBox.Show("Title and Director cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                movieService.AddMovieToList(id, title, director, year);
                MovieListBox.Text = ($"Locally Stored Movies!");
                MovieListBox.AppendText($"{movieService.LoadLocal()}");
                IDBox.Text = id.ToString();
                MessageBox.Show("Movie Added To List! \n*Dont Forget to save the progress *", "Done");
            }
            AlertBox.Text = ("Dont forget to save.");
        }
        private void BttnUpdateList(object sender, EventArgs e)
        {
            string title = TitleInputBox.Text.Trim();
            string director = CastInputBox.Text.Trim();
            DateTime year = DateInputBox.Value;
            int id = Convert.ToInt32(IDBox.Value);
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(director))
            {
                MessageBox.Show("Title and Director cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show(movieService.UpdateMovieToList(id, title, director, year));
                MovieListBox.Text = ($"Locally Stored Movies!");
                MovieListBox.AppendText($"{movieService.LoadLocal()}");
                IDBox.Text = id.ToString();
                //MessageBox.Show("Movie Added To List! \n*Dont Forget to save the progress *", "Done");
            }
            AlertBox.Text = ("Dont forget to save.");
        }
        private void BttnClearMovieFromList(object sender, EventArgs e)
        {
            MessageBox.Show("Warning!, You are clearing temporary list only. ");
            movieService.ClearMovieFromList();
            MovieListBox.Text = movieService.LoadLocal();
            AlertBox.Text = ("You have no file in List! Add Movies to List. And Don't forget to save them!");
        }
        private void BttnLoadLocal(object sender, EventArgs e)
        {
            MovieListBox.Text = ("Movies Stored Temporarily!");
            MovieListBox.Text = movieService.LoadLocal();
            AlertBox.Text = ("The List Displays Files stored Temporarily, Save them to File Now.");
        }
        private void BttnDeleteFromList(object sender, EventArgs e)
        {
            string title = TitleInputBox.Text.Trim();
            string director = CastInputBox.Text.Trim();
            DateTime year = DateInputBox.Value;
            int id = Convert.ToInt32(IDBox.Text);

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(director))
            {
                MessageBox.Show("Title and Director cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Movie movieToDelete = new Movie(id, title, director, year);
            if (movieService.DeleteFromList(movieToDelete))
            {

                TitleInputBox.Text = "";
                IDBox.Text = "";
                CastInputBox.Text = "";
                MovieListBox.Text = movieService.LoadLocal();
                MessageBox.Show("Movie Deleted From List! \n*Don't Forget to save the progress*", "Done");
                AlertBox.Text = "Add and Save.";

            }
            else
            {
                MessageBox.Show("Movie not found in the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //File
        private void BttnSaveListToFile(object sender, EventArgs e)
        {
            if(movieService.SaveMovieListToFile())
            {
                MessageBox.Show("You are saving temporary stored Movie List to File. ");
                MovieListBox.Text = movieService.LoadMovieFromFile();
                AlertBox.Text = ("You have successfully saved it to File! Add Now Read Later!.");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        private void BttnClearMovieFromFile(object sender, EventArgs e)
        {
            MessageBox.Show("Warning!, You are clearing File's Content only. ");
            movieService.ClearMovieFromFile();
            MovieListBox.Text = movieService.LoadMovieFromFile();
            AlertBox.Text = ("You have no file in File! Add and save.");
        }
        private void BttnLoadFromFile(object sender, EventArgs e)
        {
            MovieListBox.Text = ("Movies Stored in File !");
            MovieListBox.Text = movieService.LoadMovieFromFile();
        }
    }
}
