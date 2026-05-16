namespace Project
{
    partial class splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Mycar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myprogress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).BeginInit();
            this.SuspendLayout();
            // 
            // myprogress
            // 
            this.myprogress.Controls.Add(this.Mycar);
            this.myprogress.FillColor = System.Drawing.Color.White;
            this.myprogress.FillThickness = 20;
            this.myprogress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.myprogress.ForeColor = System.Drawing.Color.White;
            this.myprogress.Location = new System.Drawing.Point(311, 75);
            this.myprogress.Minimum = 0;
            this.myprogress.Name = "myprogress";
            this.myprogress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.myprogress.ProgressColor2 = System.Drawing.Color.SeaGreen;
            this.myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myprogress.Size = new System.Drawing.Size(432, 432);
            this.myprogress.TabIndex = 0;
            this.myprogress.Text = "guna2CircleProgressBar1";
            this.myprogress.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // Mycar
            // 
            this.Mycar.BackColor = System.Drawing.Color.Transparent;
            this.Mycar.Image = ((System.Drawing.Image)(resources.GetObject("Mycar.Image")));
            this.Mycar.ImageRotate = 0F;
            this.Mycar.Location = new System.Drawing.Point(71, 136);
            this.Mycar.Name = "Mycar";
            this.Mycar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Mycar.Size = new System.Drawing.Size(262, 160);
            this.Mycar.TabIndex = 0;
            this.Mycar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1112, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myprogress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.splash_Load);
            this.myprogress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar myprogress;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Mycar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

