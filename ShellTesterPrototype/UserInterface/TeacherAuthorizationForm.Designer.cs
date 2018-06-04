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
			this.KeyLabel = new System.Windows.Forms.Label();
			this.KeyBox = new System.Windows.Forms.TextBox();
			this.SendButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// KeyLabel
			// 
			this.KeyLabel.AutoSize = true;
			this.KeyLabel.Location = new System.Drawing.Point(12, 21);
			this.KeyLabel.Name = "KeyLabel";
			this.KeyLabel.Size = new System.Drawing.Size(33, 13);
			this.KeyLabel.TabIndex = 14;
			this.KeyLabel.Text = "Ключ";
			// 
			// KeyBox
			// 
			this.KeyBox.Location = new System.Drawing.Point(74, 18);
			this.KeyBox.Name = "KeyBox";
			this.KeyBox.PasswordChar = '*';
			this.KeyBox.Size = new System.Drawing.Size(270, 20);
			this.KeyBox.TabIndex = 15;
			// 
			// SendButton
			// 
			this.SendButton.Location = new System.Drawing.Point(149, 44);
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
			this.ClientSize = new System.Drawing.Size(358, 78);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.KeyLabel);
			this.Controls.Add(this.KeyBox);
			this.Name = "TeacherAuthorizationForm";
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label KeyLabel;
		private System.Windows.Forms.TextBox KeyBox;
		private System.Windows.Forms.Button SendButton;
	}
}