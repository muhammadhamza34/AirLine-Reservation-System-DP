namespace AirLineTicketReservationSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginbtn = new System.Windows.Forms.Button();
            this.unametbox = new System.Windows.Forms.TextBox();
            this.pwtbox = new System.Windows.Forms.TextBox();
            this.unamelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginbtn.Location = new System.Drawing.Point(142, 188);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(100, 33);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // unametbox
            // 
            this.unametbox.Location = new System.Drawing.Point(116, 84);
            this.unametbox.Name = "unametbox";
            this.unametbox.Size = new System.Drawing.Size(153, 21);
            this.unametbox.TabIndex = 1;
            this.unametbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pwtbox
            // 
            this.pwtbox.Location = new System.Drawing.Point(116, 123);
            this.pwtbox.Name = "pwtbox";
            this.pwtbox.PasswordChar = '*';
            this.pwtbox.Size = new System.Drawing.Size(153, 21);
            this.pwtbox.TabIndex = 2;
            // 
            // unamelbl
            // 
            this.unamelbl.AutoSize = true;
            this.unamelbl.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unamelbl.Location = new System.Drawing.Point(50, 87);
            this.unamelbl.Name = "unamelbl";
            this.unamelbl.Size = new System.Drawing.Size(42, 14);
            this.unamelbl.TabIndex = 4;
            this.unamelbl.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(17, 286);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 6;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 321);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unamelbl);
            this.Controls.Add(this.pwtbox);
            this.Controls.Add(this.unametbox);
            this.Controls.Add(this.loginbtn);
            this.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox unametbox;
        private System.Windows.Forms.TextBox pwtbox;
        private System.Windows.Forms.Label unamelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Backbtn;
    }
}