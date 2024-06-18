namespace OOP_25
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoFilmsDataSet = new OOP_25.VideoFilmsDataSet();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxDirector = new System.Windows.Forms.ComboBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.buttonLoadMovies = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.moviesTableAdapter = new OOP_25.VideoFilmsDataSetTableAdapters.MoviesTableAdapter();
            this.buttonReportByDirector = new System.Windows.Forms.Button();
            this.buttonReportByGenre = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoFilmsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(14, 342);
            this.dataGridViewMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.RowHeadersWidth = 51;
            this.dataGridViewMovies.RowTemplate.Height = 24;
            this.dataGridViewMovies.Size = new System.Drawing.Size(829, 255);
            this.dataGridViewMovies.TabIndex = 0;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(890, 305);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.Size = new System.Drawing.Size(530, 292);
            this.dataGridViewReport.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.Location = new System.Drawing.Point(195, 76);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(628, 35);
            this.textBoxTitle.TabIndex = 2;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.videoFilmsDataSet;
            // 
            // videoFilmsDataSet
            // 
            this.videoFilmsDataSet.DataSetName = "VideoFilmsDataSet";
            this.videoFilmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(179, 284);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(644, 35);
            this.textBoxYear.TabIndex = 3;
            // 
            // comboBoxDirector
            // 
            this.comboBoxDirector.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDirector.FormattingEnabled = true;
            this.comboBoxDirector.Location = new System.Drawing.Point(179, 149);
            this.comboBoxDirector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDirector.Name = "comboBoxDirector";
            this.comboBoxDirector.Size = new System.Drawing.Size(644, 35);
            this.comboBoxDirector.TabIndex = 4;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(179, 218);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(644, 35);
            this.comboBoxGenre.TabIndex = 5;
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchTitle.Location = new System.Drawing.Point(899, 76);
            this.textBoxSearchTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(527, 35);
            this.textBoxSearchTitle.TabIndex = 6;
            // 
            // buttonLoadMovies
            // 
            this.buttonLoadMovies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadMovies.Location = new System.Drawing.Point(277, 625);
            this.buttonLoadMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoadMovies.Name = "buttonLoadMovies";
            this.buttonLoadMovies.Size = new System.Drawing.Size(300, 41);
            this.buttonLoadMovies.TabIndex = 7;
            this.buttonLoadMovies.Text = "Завантажити фільми";
            this.buttonLoadMovies.UseVisualStyleBackColor = true;
            this.buttonLoadMovies.Click += new System.EventHandler(this.buttonLoadMovies_Click);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddMovie.Location = new System.Drawing.Point(631, 21);
            this.buttonAddMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(192, 41);
            this.buttonAddMovie.TabIndex = 8;
            this.buttonAddMovie.Text = "Додати фільм";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonReportByDirector
            // 
            this.buttonReportByDirector.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReportByDirector.Location = new System.Drawing.Point(1195, 625);
            this.buttonReportByDirector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReportByDirector.Name = "buttonReportByDirector";
            this.buttonReportByDirector.Size = new System.Drawing.Size(225, 41);
            this.buttonReportByDirector.TabIndex = 9;
            this.buttonReportByDirector.Text = "Звіт за режисером";
            this.buttonReportByDirector.UseVisualStyleBackColor = true;
            this.buttonReportByDirector.Click += new System.EventHandler(this.buttonReportByDirector_Click);
            // 
            // buttonReportByGenre
            // 
            this.buttonReportByGenre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReportByGenre.Location = new System.Drawing.Point(890, 625);
            this.buttonReportByGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReportByGenre.Name = "buttonReportByGenre";
            this.buttonReportByGenre.Size = new System.Drawing.Size(225, 41);
            this.buttonReportByGenre.TabIndex = 10;
            this.buttonReportByGenre.Text = "Звіт за жанром";
            this.buttonReportByGenre.UseVisualStyleBackColor = true;
            this.buttonReportByGenre.Click += new System.EventHandler(this.buttonReportByGenre_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(901, 134);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(530, 41);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Почати пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Назва фільму:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Рік випуску:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Режисер:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Жанр:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1109, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Пошук";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1117, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = " Звіти";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(607, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Введіть дані, щоб додати фільм до бази даних: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1443, 680);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReportByGenre);
            this.Controls.Add(this.buttonReportByDirector);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.buttonLoadMovies);
            this.Controls.Add(this.textBoxSearchTitle);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.comboBoxDirector);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.dataGridViewMovies);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "OOP_25";
            this.Load += new System.EventHandler(this.Video_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoFilmsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.ComboBox comboBoxDirector;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.Button buttonLoadMovies;
        private System.Windows.Forms.Button buttonAddMovie;
        private VideoFilmsDataSet videoFilmsDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private VideoFilmsDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.Button buttonReportByDirector;
        private System.Windows.Forms.Button buttonReportByGenre;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

