
namespace BuyMovieTicket_Cinema
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.grpmovieInformation = new System.Windows.Forms.GroupBox();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Movie = new System.Windows.Forms.Label();
            this.cmbmovie = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCustomerInformation.SuspendLayout();
            this.grpmovieInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader7});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(732, 279);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Full Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Movie";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salon";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Genre";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ucret";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hour";
            this.columnHeader6.Width = 59;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Vision Tarihi";
            this.columnHeader8.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Purchase Date";
            this.columnHeader7.Width = 116;
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.label3);
            this.grpCustomerInformation.Controls.Add(this.label2);
            this.grpCustomerInformation.Controls.Add(this.txtLastName);
            this.grpCustomerInformation.Controls.Add(this.txtfirstName);
            this.grpCustomerInformation.Location = new System.Drawing.Point(13, 13);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(246, 124);
            this.grpCustomerInformation.TabIndex = 3;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(80, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Location = new System.Drawing.Point(80, 30);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(100, 22);
            this.txtfirstName.TabIndex = 0;
            // 
            // grpmovieInformation
            // 
            this.grpmovieInformation.Controls.Add(this.cmbSalon);
            this.grpmovieInformation.Controls.Add(this.label1);
            this.grpmovieInformation.Controls.Add(this.Movie);
            this.grpmovieInformation.Controls.Add(this.cmbmovie);
            this.grpmovieInformation.Location = new System.Drawing.Point(333, 23);
            this.grpmovieInformation.Name = "grpmovieInformation";
            this.grpmovieInformation.Size = new System.Drawing.Size(236, 114);
            this.grpmovieInformation.TabIndex = 4;
            this.grpmovieInformation.TabStop = false;
            this.grpmovieInformation.Text = "Movie Information";
            // 
            // cmbSalon
            // 
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(73, 62);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(121, 24);
            this.cmbSalon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salon";
            // 
            // Movie
            // 
            this.Movie.AutoSize = true;
            this.Movie.Location = new System.Drawing.Point(12, 23);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(45, 17);
            this.Movie.TabIndex = 1;
            this.Movie.Text = "Movie";
            // 
            // cmbmovie
            // 
            this.cmbmovie.FormattingEnabled = true;
            this.cmbmovie.Location = new System.Drawing.Point(73, 20);
            this.cmbmovie.Name = "cmbmovie";
            this.cmbmovie.Size = new System.Drawing.Size(121, 24);
            this.cmbmovie.TabIndex = 0;
            this.cmbmovie.SelectedIndexChanged += new System.EventHandler(this.cmbmovie_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 82);
            this.button1.TabIndex = 5;
            this.button1.Text = "BuyTicket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firstname ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lastname ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpmovieInformation);
            this.Controls.Add(this.grpCustomerInformation);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.grpmovieInformation.ResumeLayout(false);
            this.grpmovieInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.GroupBox grpmovieInformation;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Movie;
        private System.Windows.Forms.ComboBox cmbmovie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

