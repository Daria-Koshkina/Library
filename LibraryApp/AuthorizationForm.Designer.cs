namespace LibraryApp
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.password.Location = new System.Drawing.Point(296, 195);
            this.password.MaxLength = 20;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(230, 20);
            this.password.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(296, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter your password";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(297, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "WELCOME BACK!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(296, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter your login";
            // 
            // login
            // 
            this.login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login.ForeColor = System.Drawing.SystemColors.GrayText;
            this.login.Location = new System.Drawing.Point(296, 138);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(230, 20);
            this.login.TabIndex = 10;
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.SandyBrown;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_in.ForeColor = System.Drawing.Color.SaddleBrown;
            this.log_in.Location = new System.Drawing.Point(296, 240);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(230, 37);
            this.log_in.TabIndex = 19;
            this.log_in.Text = "LOG IN";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.SandyBrown;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register.ForeColor = System.Drawing.Color.SaddleBrown;
            this.register.Location = new System.Drawing.Point(296, 292);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(230, 40);
            this.register.TabIndex = 20;
            this.register.Text = "REGISTRATION";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.SandyBrown;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.exitButton.Location = new System.Drawing.Point(370, 356);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 36);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 500);
            this.panel1.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Peru;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(70, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 27);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Peru;
            this.panel6.Location = new System.Drawing.Point(31, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(29, 27);
            this.panel6.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(97)))), ((int)(((byte)(36)))));
            this.panel4.Location = new System.Drawing.Point(40, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 27);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Sienna;
            this.panel3.Location = new System.Drawing.Point(13, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 27);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 76);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Location = new System.Drawing.Point(133, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 45);
            this.panel2.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(154)))), ((int)(((byte)(102)))));
            this.panel7.Location = new System.Drawing.Point(99, 108);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(29, 27);
            this.panel7.TabIndex = 3;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.register);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "AuthorizationForm";
            this.Text = "Authorization";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}