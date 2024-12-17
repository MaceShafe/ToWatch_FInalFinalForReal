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
            btnEditGenreList = new Button();
            btnSave = new Button();
            dataGridViewMovies = new DataGridView();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieBindingSource = new BindingSource(components);
            genreBindingSource = new BindingSource(components);
            genrePickBox = new ComboBox();
            label1 = new Label();
            debugText = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnEditGenreList
            // 
            btnEditGenreList.Location = new Point(625, 79);
            btnEditGenreList.Name = "btnEditGenreList";
            btnEditGenreList.Size = new Size(190, 41);
            btnEditGenreList.TabIndex = 1;
            btnEditGenreList.Text = "Edit Genres";
            btnEditGenreList.UseVisualStyleBackColor = true;
            btnEditGenreList.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(677, 512);
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
            dataGridViewMovies.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, ratingDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, priorityIdDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, genresDataGridViewTextBoxColumn });
            dataGridViewMovies.DataSource = movieBindingSource;
            dataGridViewMovies.Location = new Point(12, 137);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowHeadersWidth = 51;
            dataGridViewMovies.Size = new Size(803, 339);
            dataGridViewMovies.TabIndex = 3;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 125;
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
            ratingDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn.HeaderText = "status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
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
            priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // genresDataGridViewTextBoxColumn
            // 
            genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            genresDataGridViewTextBoxColumn.MinimumWidth = 6;
            genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            genresDataGridViewTextBoxColumn.Width = 125;
            // 
            // movieBindingSource
            // 
            movieBindingSource.DataSource = typeof(Models.Movie);
            // 
            // genreBindingSource
            // 
            genreBindingSource.DataSource = typeof(Models.Genre);
            // 
            // genrePickBox
            // 
            genrePickBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genrePickBox.FormattingEnabled = true;
            genrePickBox.Location = new Point(625, 40);
            genrePickBox.Name = "genrePickBox";
            genrePickBox.RightToLeft = RightToLeft.No;
            genrePickBox.Size = new Size(190, 28);
            genrePickBox.TabIndex = 4;
            genrePickBox.DropDown += genrePickBox_DropDown;
            genrePickBox.SelectedIndexChanged += genrePickBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(625, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 5;
            label1.Text = "Genres:";
            // 
            // debugText
            // 
            debugText.AutoSize = true;
            debugText.Location = new Point(24, 100);
            debugText.Name = "debugText";
            debugText.Size = new Size(79, 20);
            debugText.TabIndex = 6;
            debugText.Text = "debugText";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 561);
            Controls.Add(debugText);
            Controls.Add(label1);
            Controls.Add(genrePickBox);
            Controls.Add(dataGridViewMovies);
            Controls.Add(btnSave);
            Controls.Add(btnEditGenreList);
            Name = "MainForm";
            Text = "MovieList";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditGenreList;
        private Button btnSave;
        private DataGridView dataGridViewMovies;
        private BindingSource movieBindingSource;
        private BindingSource genreBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private ComboBox genrePickBox;
        private Label label1;
        private Label debugText;
    }
}
