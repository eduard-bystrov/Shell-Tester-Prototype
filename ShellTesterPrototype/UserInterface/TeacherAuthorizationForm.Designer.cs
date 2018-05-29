namespace UserInterface
{
	partial class TeacherAuthorizationForm
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
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginLabel = new System.Windows.Forms.Label();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.SendButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 47);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(45, 13);
			this.passwordLabel.TabIndex = 16;
			this.passwordLabel.Text = "Пароль";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(74, 44);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(270, 20);
			this.passwordBox.TabIndex = 17;
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(12, 21);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(38, 13);
			this.loginLabel.TabIndex = 14;
			this.loginLabel.Text = "Логин";
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(74, 18);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(270, 20);
			this.loginBox.TabIndex = 15;
			// 
			// SendButton
			// 
			this.SendButton.Location = new System.Drawing.Point(151, 70);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(69, 23);
			this.SendButton.TabIndex = 18;
			this.SendButton.Text = "Отправить";
			this.SendButton.UseVisualStyleBackColor = true;
			this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
			// 
			// TeacherAuthorizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 110);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.loginLabel);
			this.Controls.Add(this.loginBox);
			this.Name = "TeacherAuthorizationForm";
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.Button SendButton;
	}
}