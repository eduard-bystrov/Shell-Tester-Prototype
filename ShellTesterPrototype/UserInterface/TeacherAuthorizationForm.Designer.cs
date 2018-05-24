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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.choicePathToTestsetLabel = new System.Windows.Forms.Label();
			this.choicePathToTestsetBox = new System.Windows.Forms.TextBox();
			this.choicePathToProgramButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Пароль";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(74, 44);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(270, 20);
			this.textBox1.TabIndex = 17;
			// 
			// choicePathToTestsetLabel
			// 
			this.choicePathToTestsetLabel.AutoSize = true;
			this.choicePathToTestsetLabel.Location = new System.Drawing.Point(12, 21);
			this.choicePathToTestsetLabel.Name = "choicePathToTestsetLabel";
			this.choicePathToTestsetLabel.Size = new System.Drawing.Size(38, 13);
			this.choicePathToTestsetLabel.TabIndex = 14;
			this.choicePathToTestsetLabel.Text = "Логин";
			// 
			// choicePathToTestsetBox
			// 
			this.choicePathToTestsetBox.Location = new System.Drawing.Point(74, 18);
			this.choicePathToTestsetBox.Name = "choicePathToTestsetBox";
			this.choicePathToTestsetBox.Size = new System.Drawing.Size(270, 20);
			this.choicePathToTestsetBox.TabIndex = 15;
			// 
			// choicePathToProgramButton
			// 
			this.choicePathToProgramButton.Location = new System.Drawing.Point(151, 70);
			this.choicePathToProgramButton.Name = "choicePathToProgramButton";
			this.choicePathToProgramButton.Size = new System.Drawing.Size(69, 23);
			this.choicePathToProgramButton.TabIndex = 18;
			this.choicePathToProgramButton.Text = "Отправить";
			this.choicePathToProgramButton.UseVisualStyleBackColor = true;
			// 
			// TeacherAuthorizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 112);
			this.Controls.Add(this.choicePathToProgramButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.choicePathToTestsetLabel);
			this.Controls.Add(this.choicePathToTestsetBox);
			this.Name = "TeacherAuthorizationForm";
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label choicePathToTestsetLabel;
		private System.Windows.Forms.TextBox choicePathToTestsetBox;
		private System.Windows.Forms.Button choicePathToProgramButton;
	}
}