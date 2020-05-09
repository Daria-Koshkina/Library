namespace LibraryApp
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.RadioButton();
            this.guest = new System.Windows.Forms.RadioButton();
            this.registrate = new System.Windows.Forms.Button();
            this.back_to_authorizatione = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.ForeColor = System.Drawing.SystemColors.GrayText;
            this.login.Location = new System.Drawing.Point(300, 185);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(230, 20);
            this.login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(301, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your login";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(315, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "REGISTRATION\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(301, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter your password";
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.password.Location = new System.Drawing.Point(300, 235);
            this.password.MaxLength = 20;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(230, 20);
            this.password.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(297, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter your name";
            // 
            // name
            // 
            this.name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.name.Location = new System.Drawing.Point(300, 132);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(230, 20);
            this.name.TabIndex = 6;
            // 
            // admin
            // 
            this.admin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin.AutoSize = true;
            this.admin.Checked = true;
            this.admin.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admin.ForeColor = System.Drawing.Color.SaddleBrown;
            this.admin.Location = new System.Drawing.Point(301, 269);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(72, 25);
            this.admin.TabIndex = 8;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // guest
            // 
            this.guest.AutoSize = true;
            this.guest.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guest.ForeColor = System.Drawing.Color.SaddleBrown;
            this.guest.Location = new System.Drawing.Point(462, 269);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(68, 25);
            this.guest.TabIndex = 9;
            this.guest.Text = "Guest";
            this.guest.UseVisualStyleBackColor = true;
            // 
            // registrate
            // 
            this.registrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registrate.BackColor = System.Drawing.Color.SandyBrown;
            this.registrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.registrate.Location = new System.Drawing.Point(573, 358);
            this.registrate.Name = "registrate";
            this.registrate.Size = new System.Drawing.Size(99, 40);
            this.registrate.TabIndex = 10;
            this.registrate.Text = "Register";
            this.registrate.UseVisualStyleBackColor = false;
            this.registrate.Click += new System.EventHandler(this.registrate_Click);
            // 
            // back_to_authorizatione
            // 
            this.back_to_authorizatione.BackColor = System.Drawing.Color.SandyBrown;
            this.back_to_authorizatione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_to_authorizatione.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_to_authorizatione.ForeColor = System.Drawing.Color.SaddleBrown;
            this.back_to_authorizatione.Location = new System.Drawing.Point(460, 358);
            this.back_to_authorizatione.Name = "back_to_authorizatione";
            this.back_to_authorizatione.Size = new System.Drawing.Size(100, 40);
            this.back_to_authorizatione.TabIndex = 11;
            this.back_to_authorizatione.Text = "Back";
            this.back_to_authorizatione.UseVisualStyleBackColor = false;
            this.back_to_authorizatione.Click += new System.EventHandler(this.back_to_authorizatione_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 500);
            this.panel1.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(154)))), ((int)(((byte)(102)))));
            this.panel7.Location = new System.Drawing.Point(99, 108);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(29, 27);
            this.panel7.TabIndex = 3;
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
            this.panel2.Location = new System.Drawing.Point(117, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 45);
            this.panel2.TabIndex = 24;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back_to_authorizatione);
            this.Controls.Add(this.name);
            this.Controls.Add(this.registrate);
            this.Controls.Add(this.guest);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "RegistrationForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.RadioButton guest;
        private System.Windows.Forms.Button registrate;
        private System.Windows.Forms.Button back_to_authorizatione;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}

