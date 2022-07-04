namespace HotelLinq
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
            this.components = new System.ComponentModel.Container();
            this.lbChoose = new System.Windows.Forms.Label();
            this.btnArabic = new System.Windows.Forms.Button();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbChoose
            // 
            this.lbChoose.AutoSize = true;
            this.lbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lbChoose.Location = new System.Drawing.Point(371, 215);
            this.lbChoose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChoose.Name = "lbChoose";
            this.lbChoose.Size = new System.Drawing.Size(190, 31);
            this.lbChoose.TabIndex = 8;
            this.lbChoose.Text = "Fashion 2022";
            this.lbChoose.Click += new System.EventHandler(this.lbChoose_Click);
            // 
            // btnArabic
            // 
            this.btnArabic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnArabic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArabic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnArabic.FlatAppearance.BorderSize = 3;
            this.btnArabic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnArabic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArabic.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArabic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnArabic.Location = new System.Drawing.Point(377, 343);
            this.btnArabic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArabic.Name = "btnArabic";
            this.btnArabic.Size = new System.Drawing.Size(179, 64);
            this.btnArabic.TabIndex = 6;
            this.btnArabic.Text = "Enter";
            this.btnArabic.UseVisualStyleBackColor = false;
            this.btnArabic.Click += new System.EventHandler(this.BtnArabic_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lb_welcome.Location = new System.Drawing.Point(269, 121);
            this.lb_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(446, 39);
            this.lb_welcome.TabIndex = 5;
            this.lb_welcome.Text = "Welcome To Fashion Stores";
            this.lb_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1020, 554);
            this.Controls.Add(this.lbChoose);
            this.Controls.Add(this.btnArabic);
            this.Controls.Add(this.lb_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChoose;
        private System.Windows.Forms.Button btnArabic;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
    }
}

