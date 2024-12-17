using ToWatch_FInalFinalForReal.UI;
using Microsoft.EntityFrameworkCore;
using ToWatch_FInalFinalForReal.Data;
using System.ComponentModel;
using ToWatch_FInalFinalForReal.Models;
using System.Linq;



namespace ToWatch_FInalFinalForReal
{
    public partial class MainForm : Form
    {


        private MoviesContext? dbContext;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            MoviesContext? moviesContext = this.dbContext;
            if (moviesContext == null)
            {
                this.dbContext = new MoviesContext();
                moviesContext = this.dbContext;
            }
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Movies.Load();
            this.movieBindingSource.DataSource = dbContext.Movies.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewMovieForm newMoviesForm = new();
            newMoviesForm.StartPosition = FormStartPosition.CenterParent;
            newMoviesForm.ShowDialog();
        }



        private void genrePickBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void genrePickBox_DropDown(object sender, EventArgs e)
        {
            int genreNum = dbContext.Genres.Count();
            var allgenres = dbContext.Genres.ToList();

            debugText.Text = allgenres.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewMovies.Refresh();
        }
    }
}

