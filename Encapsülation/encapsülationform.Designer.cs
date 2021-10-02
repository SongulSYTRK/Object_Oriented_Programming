
namespace Object_Oriented_Programming.Encapsülation
{
    partial class encapsülation
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
            this.btncinema = new System.Windows.Forms.Button();
            this.txtseat = new System.Windows.Forms.TextBox();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncinema
            // 
            this.btncinema.Location = new System.Drawing.Point(249, 191);
            this.btncinema.Name = "btncinema";
            this.btncinema.Size = new System.Drawing.Size(123, 93);
            this.btncinema.TabIndex = 0;
            this.btncinema.Text = "Cinema ";
            this.btncinema.UseVisualStyleBackColor = true;
            this.btncinema.Click += new System.EventHandler(this.btncinema_Click);
            // 
            // txtseat
            // 
            this.txtseat.Location = new System.Drawing.Point(286, 118);
            this.txtseat.Name = "txtseat";
            this.txtseat.Size = new System.Drawing.Size(117, 22);
            this.txtseat.TabIndex = 1;
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(286, 63);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(117, 22);
            this.txtmoney.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seat ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ticket Money ";
            // 
            // encapsülation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.txtseat);
            this.Controls.Add(this.btncinema);
            this.Name = "encapsülation";
            this.Text = "encapsülation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncinema;
        private System.Windows.Forms.TextBox txtseat;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}