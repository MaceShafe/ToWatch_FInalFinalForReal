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
            btnAdd = new Button();
            btnEdit = new Button();
            dataGridViewMovies = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieBindingSource = new BindingSource(components);
            genreBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 37);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Movie";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(156, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 37);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Movie";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.AutoGenerateColumns = false;
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, ratingDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, priorityIdDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, userIDDataGridViewTextBoxColumn, userDataGridViewTextBoxColumn, genresDataGridViewTextBoxColumn });
            dataGridViewMovies.DataSource = movieBindingSource;
            dataGridViewMovies.Location = new Point(12, 78);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowHeadersWidth = 51;
            dataGridViewMovies.Size = new Size(776, 360);
            dataGridViewMovies.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
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
            // userIDDataGridViewTextBoxColumn
            // 
            userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            userIDDataGridViewTextBoxColumn.Visible = false;
            userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.HeaderText = "User";
            userDataGridViewTextBoxColumn.MinimumWidth = 6;
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            userDataGridViewTextBoxColumn.Visible = false;
            userDataGridViewTextBoxColumn.Width = 125;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(637, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(dataGridViewMovies);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "MainForm";
            Text = "MovieList";
            Load += MovieList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Button btnEdit;
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
        private ComboBox comboBox1;
    }
}
