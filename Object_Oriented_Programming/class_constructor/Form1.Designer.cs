
namespace Object_Oriented_Programming
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
            this.btncinameseat_1 = new System.Windows.Forms.Button();
            this.btncinemaseat_2 = new System.Windows.Forms.Button();
            this.txtsalon = new System.Windows.Forms.TextBox();
            this.txtseat = new System.Windows.Forms.TextBox();
            this.txtticket = new System.Windows.Forms.TextBox();
            this.txtemptyseat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncinema_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncinameseat_1
            // 
            this.btncinameseat_1.Location = new System.Drawing.Point(435, 32);
            this.btncinameseat_1.Name = "btncinameseat_1";
            this.btncinameseat_1.Size = new System.Drawing.Size(148, 56);
            this.btncinameseat_1.TabIndex = 0;
            this.btncinameseat_1.Text = "Cinema Seat 1";
            this.btncinameseat_1.UseVisualStyleBackColor = true;
            this.btncinameseat_1.Click += new System.EventHandler(this.btncinameseat_1_Click);
            // 
            // btncinemaseat_2
            // 
            this.btncinemaseat_2.Location = new System.Drawing.Point(435, 94);
            this.btncinemaseat_2.Name = "btncinemaseat_2";
            this.btncinemaseat_2.Size = new System.Drawing.Size(148, 56);
            this.btncinemaseat_2.TabIndex = 0;
            this.btncinemaseat_2.Text = "Cinema Seat 2";
            this.btncinemaseat_2.UseVisualStyleBackColor = true;
            this.btncinemaseat_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsalon
            // 
            this.txtsalon.Location = new System.Drawing.Point(229, 94);
            this.txtsalon.Name = "txtsalon";
            this.txtsalon.Size = new System.Drawing.Size(137, 22);
            this.txtsalon.TabIndex = 1;
            // 
            // txtseat
            // 
            this.txtseat.Location = new System.Drawing.Point(229, 49);
            this.txtseat.Name = "txtseat";
            this.txtseat.Size = new System.Drawing.Size(137, 22);
            this.txtseat.TabIndex = 1;
            // 
            // txtticket
            // 
            this.txtticket.Location = new System.Drawing.Point(229, 190);
            this.txtticket.Name = "txtticket";
            this.txtticket.Size = new System.Drawing.Size(137, 22);
            this.txtticket.TabIndex = 1;
            // 
            // txtemptyseat
            // 
            this.txtemptyseat.Location = new System.Drawing.Point(229, 142);
            this.txtemptyseat.Name = "txtemptyseat";
            this.txtemptyseat.Size = new System.Drawing.Size(137, 22);
            this.txtemptyseat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "SalonNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empty Seat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ticket";
            // 
            // btncinema_3
            // 
            this.btncinema_3.Location = new System.Drawing.Point(435, 164);
            this.btncinema_3.Name = "btncinema_3";
            this.btncinema_3.Size = new System.Drawing.Size(143, 48);
            this.btncinema_3.TabIndex = 6;
            this.btncinema_3.Text = "Cinema Seat 3";
            this.btncinema_3.UseVisualStyleBackColor = true;
            this.btncinema_3.Click += new System.EventHandler(this.btncinema_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncinema_3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemptyseat);
            this.Controls.Add(this.txtticket);
            this.Controls.Add(this.txtseat);
            this.Controls.Add(this.txtsalon);
            this.Controls.Add(this.btncinemaseat_2);
            this.Controls.Add(this.btncinameseat_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncinameseat_1;
        private System.Windows.Forms.Button btncinemaseat_2;
        private System.Windows.Forms.TextBox txtsalon;
        private System.Windows.Forms.TextBox txtseat;
        private System.Windows.Forms.TextBox txtticket;
        private System.Windows.Forms.TextBox txtemptyseat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncinema_3;
    }
}

