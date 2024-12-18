namespace ToWatch_FInalFinalForReal
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSave = new Button();
            dataGridViewMovies = new DataGridView();
            moviesBindingSource = new BindingSource(components);
            genreBindingSource = new BindingSource(components);
            movieBindingSource = new BindingSource(components);
            dataGridViewGenres = new DataGridView();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MovieID = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GenreId = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(689, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 37);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.AutoGenerateColumns = false;
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, MovieID, descriptionDataGridViewTextBoxColumn, ratingDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, priorityIdDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, GenreId, Genre });
            dataGridViewMovies.DataSource = moviesBindingSource;
            dataGridViewMovies.Location = new Point(12, 12);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowHeadersWidth = 51;
            dataGridViewMovies.Size = new Size(570, 339);
            dataGridViewMovies.TabIndex = 3;
            // 
            // moviesBindingSource
            // 
            moviesBindingSource.DataMember = "Movies";
            moviesBindingSource.DataSource = genreBindingSource;
            // 
            // genreBindingSource
            // 
            genreBindingSource.DataSource = typeof(Models.Genre);
            // 
            // movieBindingSource
            // 
            movieBindingSource.DataSource = typeof(Models.Movie);
            // 
            // dataGridViewGenres
            // 
            dataGridViewGenres.AutoGenerateColumns = false;
            dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenres.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, nameDataGridViewTextBoxColumn });
            dataGridViewGenres.DataSource = genreBindingSource;
            dataGridViewGenres.Location = new Point(598, 12);
            dataGridViewGenres.Name = "dataGridViewGenres";
            dataGridViewGenres.RowHeadersWidth = 51;
            dataGridViewGenres.Size = new Size(239, 339);
            dataGridViewGenres.TabIndex = 7;
            dataGridViewGenres.SelectionChanged += dataGridViewGenres_SelectionChanged;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // MovieID
            // 
            MovieID.DataPropertyName = "MovieID";
            MovieID.HeaderText = "ID";
            MovieID.MinimumWidth = 6;
            MovieID.Name = "MovieID";
            MovieID.ReadOnly = true;
            MovieID.Width = 60;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            ratingDataGridViewTextBoxColumn.Width = 80;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn.HeaderText = "status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ToolTipText = "0 - Havent Watched | 1 -Planning To Watch | 2 - Watched | 3 - Plan to Rewatch";
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityIdDataGridViewTextBoxColumn
            // 
            priorityIdDataGridViewTextBoxColumn.DataPropertyName = "PriorityId";
            priorityIdDataGridViewTextBoxColumn.HeaderText = "PriorityId";
            priorityIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            priorityIdDataGridViewTextBoxColumn.Name = "priorityIdDataGridViewTextBoxColumn";
            priorityIdDataGridViewTextBoxColumn.Visible = false;
            priorityIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            priorityDataGridViewTextBoxColumn.MinimumWidth = 6;
            priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            priorityDataGridViewTextBoxColumn.Visible = false;
            priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // GenreId
            // 
            GenreId.DataPropertyName = "GenreId";
            GenreId.HeaderText = "GenreId";
            GenreId.MinimumWidth = 6;
            GenreId.Name = "GenreId";
            GenreId.Visible = false;
            GenreId.Width = 80;
            // 
            // Genre
            // 
            Genre.DataPropertyName = "Genre";
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.Visible = false;
            Genre.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "GenreID";
            dataGridViewTextBoxColumn2.HeaderText = "ID";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Genre";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 405);
            Controls.Add(dataGridViewGenres);
            Controls.Add(dataGridViewMovies);
            Controls.Add(btnSave);
            Name = "MainForm";
            Text = "MovieList";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private DataGridView dataGridViewMovies;
        private BindingSource movieBindingSource;
        private BindingSource genreBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridView dataGridViewGenres;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private BindingSource moviesBindingSource;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MovieID;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn GenreId;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}
