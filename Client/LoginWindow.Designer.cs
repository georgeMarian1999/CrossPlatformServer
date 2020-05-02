namespace Client
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.LoginBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.LoginImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBttn
            // 
            this.LoginBttn.Location = new System.Drawing.Point(306, 323);
            this.LoginBttn.Name = "LoginBttn";
            this.LoginBttn.Size = new System.Drawing.Size(163, 35);
            this.LoginBttn.TabIndex = 0;
            this.LoginBttn.Text = "Login";
            this.LoginBttn.UseVisualStyleBackColor = true;
            this.LoginBttn.Click += new System.EventHandler(this.loginBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(306, 214);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(163, 20);
            this.User.TabIndex = 3;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(306, 263);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(163, 20);
            this.Pass.TabIndex = 4;
            this.Pass.UseSystemPasswordChar = true;
            this.Pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginImage
            // 
            this.LoginImage.Image = ((System.Drawing.Image)(resources.GetObject("LoginImage.Image")));
            this.LoginImage.Location = new System.Drawing.Point(306, 21);
            this.LoginImage.Name = "LoginImage";
            this.LoginImage.Size = new System.Drawing.Size(163, 148);
            this.LoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoginImage.TabIndex = 5;
            this.LoginImage.TabStop = false;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginImage);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBttn);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            ((System.ComponentModel.ISupportInitialize)(this.LoginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.PictureBox LoginImage;
    }
}