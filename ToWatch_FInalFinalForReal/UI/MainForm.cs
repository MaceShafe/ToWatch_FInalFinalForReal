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
            this.dbContext.Genres.Load();
            this.movieBindingSource.DataSource = dbContext.Movies.Local.ToBindingList();
            this.genreBindingSource.DataSource = dbContext.Genres.Local.ToBindingList();


        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;

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

        private void dataGridViewGenres_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
                {
                var genre = (Genre)this.dataGridViewGenres.CurrentRow.DataBoundItem;
                if (genre != null)
                    {
                        this.dbContext.Entry(genre).Collection(e => e.Movies).Load();
                    }
                }
            }
        }
}

