using ToWatch_FInalFinalForReal.UI;
using Microsoft.EntityFrameworkCore;
using ToWatch_FInalFinalForReal.Data;



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

            this.dbContext = new ();

            // Uncomment the line below to start fresh with a new database.
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Movies.Load();

            //this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
        }


        private void MovieList_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewMovieForm newMoviesForm = new();
            newMoviesForm.StartPosition = FormStartPosition.CenterParent;
            newMoviesForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
