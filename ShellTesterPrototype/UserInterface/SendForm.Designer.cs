namespace UserInterface
{
	partial class SendForm
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
			this.personalData = new System.Windows.Forms.GroupBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.surnameBox = new System.Windows.Forms.TextBox();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.testerData = new System.Windows.Forms.GroupBox();
			this.choicePathToProgramLabel = new System.Windows.Forms.Label();
			this.choicePathToTestsetLabel = new System.Windows.Forms.Label();
			this.choicePathToProgramButton = new System.Windows.Forms.Button();
			this.choicePathToTestsetBox = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.personalData.SuspendLayout();
			this.testerData.SuspendLayout();
			this.SuspendLayout();
			// 
			// personalData
			// 
			this.personalData.Controls.Add(this.nameBox);
			this.personalData.Controls.Add(this.surnameBox);
			this.personalData.Controls.Add(this.surnameLabel);
			this.personalData.Controls.Add(this.nameLabel);
			this.personalData.Location = new System.Drawing.Point(12, 12);
			this.personalData.Name = "personalData";
			this.personalData.Size = new System.Drawing.Size(352, 79);
			this.personalData.TabIndex = 6;
			this.personalData.TabStop = false;
			this.personalData.Text = "Персональные данные";
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(72, 20);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(270, 20);
			this.nameBox.TabIndex = 5;
			// 
			// surnameBox
			// 
			this.surnameBox.Location = new System.Drawing.Point(72, 43);
			this.surnameBox.Name = "surnameBox";
			this.surnameBox.Size = new System.Drawing.Size(270, 20);
			this.surnameBox.TabIndex = 3;
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(10, 46);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(42, 13);
			this.surnameLabel.TabIndex = 1;
			this.surnameLabel.Text = "Группа";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(10, 23);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(34, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "ФИО";
			// 
			// testerData
			// 
			this.testerData.Controls.Add(this.label2);
			this.testerData.Controls.Add(this.textBox2);
			this.testerData.Controls.Add(this.label1);
			this.testerData.Controls.Add(this.textBox1);
			this.testerData.Controls.Add(this.checkBox1);
			this.testerData.Controls.Add(this.choicePathToProgramLabel);
			this.testerData.Controls.Add(this.choicePathToTestsetLabel);
			this.testerData.Controls.Add(this.choicePathToTestsetBox);
			this.testerData.Location = new System.Drawing.Point(12, 97);
			this.testerData.Name = "testerData";
			this.testerData.Size = new System.Drawing.Size(352, 137);
			this.testerData.TabIndex = 5;
			this.testerData.TabStop = false;
			this.testerData.Text = "Почтовая информация";
			// 
			// choicePathToProgramLabel
			// 
			this.choicePathToProgramLabel.AutoSize = true;
			this.choicePathToProgramLabel.Location = new System.Drawing.Point(10, 107);
			this.choicePathToProgramLabel.Name = "choicePathToProgramLabel";
			this.choicePathToProgramLabel.Size = new System.Drawing.Size(151, 13);
			this.choicePathToProgramLabel.TabIndex = 10;
			this.choicePathToProgramLabel.Text = "Отправить результаты в БД";
			// 
			// choicePathToTestsetLabel
			// 
			this.choicePathToTestsetLabel.AutoSize = true;
			this.choicePathToTestsetLabel.Location = new System.Drawing.Point(10, 26);
			this.choicePathToTestsetLabel.Name = "choicePathToTestsetLabel";
			this.choicePathToTestsetLabel.Size = new System.Drawing.Size(33, 13);
			this.choicePathToTestsetLabel.TabIndex = 3;
			this.choicePathToTestsetLabel.Text = "Кому";
			// 
			// choicePathToProgramButton
			// 
			this.choicePathToProgramButton.Location = new System.Drawing.Point(148, 240);
			this.choicePathToProgramButton.Name = "choicePathToProgramButton";
			this.choicePathToProgramButton.Size = new System.Drawing.Size(69, 23);
			this.choicePathToProgramButton.TabIndex = 9;
			this.choicePathToProgramButton.Text = "Отправить";
			this.choicePathToProgramButton.UseVisualStyleBackColor = true;
			// 
			// choicePathToTestsetBox
			// 
			this.choicePathToTestsetBox.Location = new System.Drawing.Point(72, 23);
			this.choicePathToTestsetBox.Name = "choicePathToTestsetBox";
			this.choicePathToTestsetBox.Size = new System.Drawing.Size(270, 20);
			this.choicePathToTestsetBox.TabIndex = 6;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(167, 106);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(15, 14);
			this.checkBox1.TabIndex = 11;
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "От Кого";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(72, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(270, 20);
			this.textBox1.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Пароль";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(72, 75);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(270, 20);
			this.textBox2.TabIndex = 15;
			// 
			// SendForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 271);
			this.Controls.Add(this.personalData);
			this.Controls.Add(this.testerData);
			this.Controls.Add(this.choicePathToProgramButton);
			this.Name = "SendForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Отправка результатов";
			this.personalData.ResumeLayout(false);
			this.personalData.PerformLayout();
			this.testerData.ResumeLayout(false);
			this.testerData.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox personalData;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox surnameBox;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.GroupBox testerData;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label choicePathToProgramLabel;
		private System.Windows.Forms.Label choicePathToTestsetLabel;
		private System.Windows.Forms.TextBox choicePathToTestsetBox;
		private System.Windows.Forms.Button choicePathToProgramButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}