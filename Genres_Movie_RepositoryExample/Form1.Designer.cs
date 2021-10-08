
namespace Genres_Movie_RepositoryExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreateGenres = new System.Windows.Forms.Button();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.grpGenreUpdate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.grpGenresCreate = new System.Windows.Forms.GroupBox();
            this.txtGenresCreateDescription = new System.Windows.Forms.TextBox();
            this.txtGenresCreatName = new System.Windows.Forms.TextBox();
            this.txtGenresCreateId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeleteDescription = new System.Windows.Forms.TextBox();
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.grpMovieUpdate = new System.Windows.Forms.GroupBox();
            this.txtUpdateMovieContent = new System.Windows.Forms.TextBox();
            this.txtUpdateMovieTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateMovieId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnupdateMovie = new System.Windows.Forms.Button();
            this.grpMovieCreate = new System.Windows.Forms.GroupBox();
            this.txtMovieCreateContent = new System.Windows.Forms.TextBox();
            this.txtMovieCreateTitle = new System.Windows.Forms.TextBox();
            this.txtMovieCreateId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnmovieCreate = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpGenreUpdate.SuspendLayout();
            this.grpGenresCreate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpMovieUpdate.SuspendLayout();
            this.grpMovieCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCreateGenres
            // 
            this.btnCreateGenres.Location = new System.Drawing.Point(51, 127);
            this.btnCreateGenres.Name = "btnCreateGenres";
            this.btnCreateGenres.Size = new System.Drawing.Size(129, 42);
            this.btnCreateGenres.TabIndex = 1;
            this.btnCreateGenres.Text = "Create Genres ";
            this.btnCreateGenres.UseVisualStyleBackColor = true;
            this.btnCreateGenres.Click += new System.EventHandler(this.btnCreateGenres_Click);
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Location = new System.Drawing.Point(64, 147);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(129, 42);
            this.btnUpdateGenre.TabIndex = 2;
            this.btnUpdateGenre.Text = "UpdateGenres ";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // grpGenreUpdate
            // 
            this.grpGenreUpdate.Controls.Add(this.txtdescription);
            this.grpGenreUpdate.Controls.Add(this.txtname);
            this.grpGenreUpdate.Controls.Add(this.btnUpdateGenre);
            this.grpGenreUpdate.Controls.Add(this.txtId);
            this.grpGenreUpdate.Controls.Add(this.label3);
            this.grpGenreUpdate.Controls.Add(this.label2);
            this.grpGenreUpdate.Controls.Add(this.label1);
            this.grpGenreUpdate.Location = new System.Drawing.Point(-2, -1);
            this.grpGenreUpdate.Name = "grpGenreUpdate";
            this.grpGenreUpdate.Size = new System.Drawing.Size(240, 189);
            this.grpGenreUpdate.TabIndex = 3;
            this.grpGenreUpdate.TabStop = false;
            this.grpGenreUpdate.Text = "GenreUpdate ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(119, 63);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 4;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(119, 99);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(100, 22);
            this.txtdescription.TabIndex = 5;
            // 
            // grpGenresCreate
            // 
            this.grpGenresCreate.Controls.Add(this.txtGenresCreateDescription);
            this.grpGenresCreate.Controls.Add(this.txtGenresCreatName);
            this.grpGenresCreate.Controls.Add(this.txtGenresCreateId);
            this.grpGenresCreate.Controls.Add(this.btnCreateGenres);
            this.grpGenresCreate.Controls.Add(this.label4);
            this.grpGenresCreate.Controls.Add(this.label5);
            this.grpGenresCreate.Controls.Add(this.label6);
            this.grpGenresCreate.Location = new System.Drawing.Point(239, -1);
            this.grpGenresCreate.Name = "grpGenresCreate";
            this.grpGenresCreate.Size = new System.Drawing.Size(227, 189);
            this.grpGenresCreate.TabIndex = 3;
            this.grpGenresCreate.TabStop = false;
            this.grpGenresCreate.Text = "GenreCreate ";
            // 
            // txtGenresCreateDescription
            // 
            this.txtGenresCreateDescription.Location = new System.Drawing.Point(119, 99);
            this.txtGenresCreateDescription.Name = "txtGenresCreateDescription";
            this.txtGenresCreateDescription.Size = new System.Drawing.Size(100, 22);
            this.txtGenresCreateDescription.TabIndex = 5;
            // 
            // txtGenresCreatName
            // 
            this.txtGenresCreatName.Location = new System.Drawing.Point(119, 63);
            this.txtGenresCreatName.Name = "txtGenresCreatName";
            this.txtGenresCreatName.Size = new System.Drawing.Size(100, 22);
            this.txtGenresCreatName.TabIndex = 4;
            // 
            // txtGenresCreateId
            // 
            this.txtGenresCreateId.Location = new System.Drawing.Point(119, 25);
            this.txtGenresCreateId.Name = "txtGenresCreateId";
            this.txtGenresCreateId.Size = new System.Drawing.Size(100, 22);
            this.txtGenresCreateId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteGenre);
            this.groupBox1.Controls.Add(this.txtDeleteDescription);
            this.groupBox1.Controls.Add(this.txtDeleteName);
            this.groupBox1.Controls.Add(this.txtDeleteId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(464, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GenreDelete  ";
            // 
            // txtDeleteDescription
            // 
            this.txtDeleteDescription.Location = new System.Drawing.Point(119, 99);
            this.txtDeleteDescription.Name = "txtDeleteDescription";
            this.txtDeleteDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteDescription.TabIndex = 5;
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.Location = new System.Drawing.Point(119, 63);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteName.TabIndex = 4;
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(119, 25);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteId.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Id";
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(67, 127);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(118, 43);
            this.btnDeleteGenre.TabIndex = 6;
            this.btnDeleteGenre.Text = "Delete Genres ";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // grpMovieUpdate
            // 
            this.grpMovieUpdate.Controls.Add(this.btnupdateMovie);
            this.grpMovieUpdate.Controls.Add(this.txtUpdateMovieContent);
            this.grpMovieUpdate.Controls.Add(this.txtUpdateMovieTitle);
            this.grpMovieUpdate.Controls.Add(this.txtUpdateMovieId);
            this.grpMovieUpdate.Controls.Add(this.label10);
            this.grpMovieUpdate.Controls.Add(this.label11);
            this.grpMovieUpdate.Controls.Add(this.label12);
            this.grpMovieUpdate.Location = new System.Drawing.Point(947, 6);
            this.grpMovieUpdate.Name = "grpMovieUpdate";
            this.grpMovieUpdate.Size = new System.Drawing.Size(240, 196);
            this.grpMovieUpdate.TabIndex = 3;
            this.grpMovieUpdate.TabStop = false;
            this.grpMovieUpdate.Text = "MovieUpdate ";
            // 
            // txtUpdateMovieContent
            // 
            this.txtUpdateMovieContent.Location = new System.Drawing.Point(119, 99);
            this.txtUpdateMovieContent.Name = "txtUpdateMovieContent";
            this.txtUpdateMovieContent.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateMovieContent.TabIndex = 5;
            // 
            // txtUpdateMovieTitle
            // 
            this.txtUpdateMovieTitle.Location = new System.Drawing.Point(119, 63);
            this.txtUpdateMovieTitle.Name = "txtUpdateMovieTitle";
            this.txtUpdateMovieTitle.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateMovieTitle.TabIndex = 4;
            // 
            // txtUpdateMovieId
            // 
            this.txtUpdateMovieId.Location = new System.Drawing.Point(119, 25);
            this.txtUpdateMovieId.Name = "txtUpdateMovieId";
            this.txtUpdateMovieId.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateMovieId.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Content ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Id";
            // 
            // btnupdateMovie
            // 
            this.btnupdateMovie.Location = new System.Drawing.Point(56, 140);
            this.btnupdateMovie.Name = "btnupdateMovie";
            this.btnupdateMovie.Size = new System.Drawing.Size(106, 42);
            this.btnupdateMovie.TabIndex = 6;
            this.btnupdateMovie.Text = "Update Movie";
            this.btnupdateMovie.UseVisualStyleBackColor = true;
            this.btnupdateMovie.Click += new System.EventHandler(this.btnupdateMovie_Click);
            // 
            // grpMovieCreate
            // 
            this.grpMovieCreate.Controls.Add(this.btnmovieCreate);
            this.grpMovieCreate.Controls.Add(this.txtMovieCreateContent);
            this.grpMovieCreate.Controls.Add(this.txtMovieCreateTitle);
            this.grpMovieCreate.Controls.Add(this.txtMovieCreateId);
            this.grpMovieCreate.Controls.Add(this.label13);
            this.grpMovieCreate.Controls.Add(this.label14);
            this.grpMovieCreate.Controls.Add(this.label15);
            this.grpMovieCreate.Location = new System.Drawing.Point(701, 6);
            this.grpMovieCreate.Name = "grpMovieCreate";
            this.grpMovieCreate.Size = new System.Drawing.Size(240, 196);
            this.grpMovieCreate.TabIndex = 3;
            this.grpMovieCreate.TabStop = false;
            this.grpMovieCreate.Text = "MovieCreate";
            // 
            // txtMovieCreateContent
            // 
            this.txtMovieCreateContent.Location = new System.Drawing.Point(119, 99);
            this.txtMovieCreateContent.Name = "txtMovieCreateContent";
            this.txtMovieCreateContent.Size = new System.Drawing.Size(100, 22);
            this.txtMovieCreateContent.TabIndex = 5;
            // 
            // txtMovieCreateTitle
            // 
            this.txtMovieCreateTitle.Location = new System.Drawing.Point(119, 63);
            this.txtMovieCreateTitle.Name = "txtMovieCreateTitle";
            this.txtMovieCreateTitle.Size = new System.Drawing.Size(100, 22);
            this.txtMovieCreateTitle.TabIndex = 4;
            // 
            // txtMovieCreateId
            // 
            this.txtMovieCreateId.Location = new System.Drawing.Point(119, 25);
            this.txtMovieCreateId.Name = "txtMovieCreateId";
            this.txtMovieCreateId.Size = new System.Drawing.Size(100, 22);
            this.txtMovieCreateId.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Content ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Title";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Id";
            // 
            // btnmovieCreate
            // 
            this.btnmovieCreate.Location = new System.Drawing.Point(63, 140);
            this.btnmovieCreate.Name = "btnmovieCreate";
            this.btnmovieCreate.Size = new System.Drawing.Size(116, 42);
            this.btnmovieCreate.TabIndex = 6;
            this.btnmovieCreate.Text = "Create Movie";
            this.btnmovieCreate.UseVisualStyleBackColor = true;
            this.btnmovieCreate.Click += new System.EventHandler(this.btnmovieCreate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(614, 208);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(573, 263);
            this.dataGridView2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 558);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGenresCreate);
            this.Controls.Add(this.grpMovieCreate);
            this.Controls.Add(this.grpMovieUpdate);
            this.Controls.Add(this.grpGenreUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpGenreUpdate.ResumeLayout(false);
            this.grpGenreUpdate.PerformLayout();
            this.grpGenresCreate.ResumeLayout(false);
            this.grpGenresCreate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMovieUpdate.ResumeLayout(false);
            this.grpMovieUpdate.PerformLayout();
            this.grpMovieCreate.ResumeLayout(false);
            this.grpMovieCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreateGenres;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.GroupBox grpGenreUpdate;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGenresCreate;
        private System.Windows.Forms.TextBox txtGenresCreateDescription;
        private System.Windows.Forms.TextBox txtGenresCreatName;
        private System.Windows.Forms.TextBox txtGenresCreateId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.TextBox txtDeleteDescription;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpMovieUpdate;
        private System.Windows.Forms.Button btnupdateMovie;
        private System.Windows.Forms.TextBox txtUpdateMovieContent;
        private System.Windows.Forms.TextBox txtUpdateMovieTitle;
        private System.Windows.Forms.TextBox txtUpdateMovieId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpMovieCreate;
        private System.Windows.Forms.Button btnmovieCreate;
        private System.Windows.Forms.TextBox txtMovieCreateContent;
        private System.Windows.Forms.TextBox txtMovieCreateTitle;
        private System.Windows.Forms.TextBox txtMovieCreateId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

