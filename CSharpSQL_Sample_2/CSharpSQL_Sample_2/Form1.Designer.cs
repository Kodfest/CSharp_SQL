namespace CSharpSQL_Sample_2
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.singinBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTbox = new System.Windows.Forms.TextBox();
            this.signupBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTbox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(80, 159);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(122, 23);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // singinBtn
            // 
            this.singinBtn.Location = new System.Drawing.Point(143, 72);
            this.singinBtn.Name = "singinBtn";
            this.singinBtn.Size = new System.Drawing.Size(58, 23);
            this.singinBtn.TabIndex = 14;
            this.singinBtn.Text = "Sign In";
            this.singinBtn.UseVisualStyleBackColor = true;
            this.singinBtn.Click += new System.EventHandler(this.singinBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(79, 130);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(122, 23);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 47);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTbox
            // 
            this.passwordTbox.Location = new System.Drawing.Point(79, 44);
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.Size = new System.Drawing.Size(122, 20);
            this.passwordTbox.TabIndex = 11;
            // 
            // signupBtn
            // 
            this.signupBtn.Location = new System.Drawing.Point(79, 72);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(58, 23);
            this.signupBtn.TabIndex = 10;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(10, 18);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "User Name:";
            // 
            // userNameTbox
            // 
            this.userNameTbox.Location = new System.Drawing.Point(79, 15);
            this.userNameTbox.Name = "userNameTbox";
            this.userNameTbox.Size = new System.Drawing.Size(122, 20);
            this.userNameTbox.TabIndex = 8;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(79, 101);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 23);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.singinBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTbox);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button singinBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTbox;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTbox;
        private System.Windows.Forms.Button exitBtn;
    }
}

