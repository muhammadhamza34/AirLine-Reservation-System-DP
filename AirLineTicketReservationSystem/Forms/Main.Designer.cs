namespace AirLineTicketReservationSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Customerbtn = new System.Windows.Forms.Button();
            this.administratorbtn = new System.Windows.Forms.Button();
            this.enteraslbl = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, -83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // welcomelbl
            // 
            this.welcomelbl.Font = new System.Drawing.Font("Maiandra GD", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.ForeColor = System.Drawing.Color.Indigo;
            this.welcomelbl.Location = new System.Drawing.Point(148, 189);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(425, 85);
            this.welcomelbl.TabIndex = 1;
            this.welcomelbl.Text = "WELCOME!";
            this.welcomelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomelbl.Click += new System.EventHandler(this.welcomelbl_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 120;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Customerbtn
            // 
            this.Customerbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Customerbtn.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerbtn.Location = new System.Drawing.Point(259, 124);
            this.Customerbtn.Name = "Customerbtn";
            this.Customerbtn.Size = new System.Drawing.Size(202, 54);
            this.Customerbtn.TabIndex = 2;
            this.Customerbtn.Text = "Customer";
            this.Customerbtn.UseVisualStyleBackColor = false;
            this.Customerbtn.Click += new System.EventHandler(this.Customerbtn_Click);
            // 
            // administratorbtn
            // 
            this.administratorbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.administratorbtn.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorbtn.Location = new System.Drawing.Point(259, 192);
            this.administratorbtn.Name = "administratorbtn";
            this.administratorbtn.Size = new System.Drawing.Size(202, 54);
            this.administratorbtn.TabIndex = 3;
            this.administratorbtn.Text = "Administrator";
            this.administratorbtn.UseVisualStyleBackColor = false;
            this.administratorbtn.Click += new System.EventHandler(this.administratorbtn_Click);
            // 
            // enteraslbl
            // 
            this.enteraslbl.AutoSize = true;
            this.enteraslbl.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteraslbl.Location = new System.Drawing.Point(311, 81);
            this.enteraslbl.Name = "enteraslbl";
            this.enteraslbl.Size = new System.Drawing.Size(98, 29);
            this.enteraslbl.TabIndex = 4;
            this.enteraslbl.Text = "Enter As";
            this.enteraslbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.exitbtn.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(617, 294);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(79, 33);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 339);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.enteraslbl);
            this.Controls.Add(this.administratorbtn);
            this.Controls.Add(this.Customerbtn);
            this.Controls.Add(this.welcomelbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M&H Airline";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button Customerbtn;
        private System.Windows.Forms.Button administratorbtn;
        private System.Windows.Forms.Label enteraslbl;
        private System.Windows.Forms.Button exitbtn;
    }
}

