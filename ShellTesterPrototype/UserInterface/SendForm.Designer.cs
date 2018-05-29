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
			this.extraBox = new System.Windows.Forms.TextBox();
			this.extraLabel = new System.Windows.Forms.Label();
			this.testResultBox = new System.Windows.Forms.TextBox();
			this.scoreBox = new System.Windows.Forms.TextBox();
			this.testResultLabel = new System.Windows.Forms.Label();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.yearsBox = new System.Windows.Forms.ComboBox();
			this.semesterBox = new System.Windows.Forms.TextBox();
			this.semesterLabel = new System.Windows.Forms.Label();
			this.yearsLabel = new System.Windows.Forms.Label();
			this.fullnameBox = new System.Windows.Forms.TextBox();
			this.groupBox = new System.Windows.Forms.TextBox();
			this.groupLabel = new System.Windows.Forms.Label();
			this.fullnameLabel = new System.Windows.Forms.Label();
			this.SendButton = new System.Windows.Forms.Button();
			this.dbCheckBox = new System.Windows.Forms.CheckBox();
			this.choicePathToProgramLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.mailBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.subjectVariantBox = new System.Windows.Forms.TextBox();
			this.subjectVariantLabel = new System.Windows.Forms.Label();
			this.subjectTaskBox = new System.Windows.Forms.TextBox();
			this.subjectTaskLabel = new System.Windows.Forms.Label();
			this.subjectNameBox = new System.Windows.Forms.TextBox();
			this.subjectNameLabel = new System.Windows.Forms.Label();
			this.personalData.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// personalData
			// 
			this.personalData.Controls.Add(this.extraBox);
			this.personalData.Controls.Add(this.extraLabel);
			this.personalData.Controls.Add(this.testResultBox);
			this.personalData.Controls.Add(this.scoreBox);
			this.personalData.Controls.Add(this.testResultLabel);
			this.personalData.Controls.Add(this.scoreLabel);
			this.personalData.Controls.Add(this.yearsBox);
			this.personalData.Controls.Add(this.semesterBox);
			this.personalData.Controls.Add(this.semesterLabel);
			this.personalData.Controls.Add(this.yearsLabel);
			this.personalData.Controls.Add(this.fullnameBox);
			this.personalData.Controls.Add(this.groupBox);
			this.personalData.Controls.Add(this.groupLabel);
			this.personalData.Controls.Add(this.fullnameLabel);
			this.personalData.Location = new System.Drawing.Point(12, 12);
			this.personalData.Name = "personalData";
			this.personalData.Size = new System.Drawing.Size(446, 132);
			this.personalData.TabIndex = 6;
			this.personalData.TabStop = false;
			this.personalData.Text = "Персональные данные";
			// 
			// extraBox
			// 
			this.extraBox.Location = new System.Drawing.Point(116, 100);
			this.extraBox.Name = "extraBox";
			this.extraBox.Size = new System.Drawing.Size(319, 20);
			this.extraBox.TabIndex = 16;
			// 
			// extra
			// 
			this.extraLabel.AutoSize = true;
			this.extraLabel.Location = new System.Drawing.Point(10, 103);
			this.extraLabel.Name = "extra";
			this.extraLabel.Size = new System.Drawing.Size(87, 13);
			this.extraLabel.TabIndex = 15;
			this.extraLabel.Text = "Дополнительно";
			this.extraLabel.Click += new System.EventHandler(this.extra_Click);
			// 
			// testResultBox
			// 
			this.testResultBox.CausesValidation = false;
			this.testResultBox.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.testResultBox.Location = new System.Drawing.Point(116, 76);
			this.testResultBox.Name = "testResultBox";
			this.testResultBox.ReadOnly = true;
			this.testResultBox.Size = new System.Drawing.Size(73, 20);
			this.testResultBox.TabIndex = 14;
			// 
			// scoreBox
			// 
			this.scoreBox.Location = new System.Drawing.Point(285, 76);
			this.scoreBox.Name = "scoreBox";
			this.scoreBox.Size = new System.Drawing.Size(82, 20);
			this.scoreBox.TabIndex = 13;
			// 
			// testResultLabel
			// 
			this.testResultLabel.AutoSize = true;
			this.testResultLabel.Location = new System.Drawing.Point(10, 79);
			this.testResultLabel.Name = "testResultLabel";
			this.testResultLabel.Size = new System.Drawing.Size(100, 13);
			this.testResultLabel.TabIndex = 12;
			this.testResultLabel.Text = "Тестов пройденно";
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.Location = new System.Drawing.Point(195, 79);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(84, 13);
			this.scoreLabel.TabIndex = 11;
			this.scoreLabel.Text = "Итоговый балл";
			// 
			// yearsBox
			// 
			this.yearsBox.FormattingEnabled = true;
			this.yearsBox.Location = new System.Drawing.Point(222, 45);
			this.yearsBox.Name = "yearsBox";
			this.yearsBox.Size = new System.Drawing.Size(77, 21);
			this.yearsBox.TabIndex = 10;
			// 
			// semesterBox
			// 
			this.semesterBox.Location = new System.Drawing.Point(362, 47);
			this.semesterBox.Name = "semesterBox";
			this.semesterBox.Size = new System.Drawing.Size(73, 20);
			this.semesterBox.TabIndex = 9;
			// 
			// semesterLabel
			// 
			this.semesterLabel.AutoSize = true;
			this.semesterLabel.Location = new System.Drawing.Point(305, 50);
			this.semesterLabel.Name = "semesterLabel";
			this.semesterLabel.Size = new System.Drawing.Size(51, 13);
			this.semesterLabel.TabIndex = 8;
			this.semesterLabel.Text = "Семестр";
			// 
			// yearsLabel
			// 
			this.yearsLabel.AutoSize = true;
			this.yearsLabel.Location = new System.Drawing.Point(142, 49);
			this.yearsLabel.Name = "yearsLabel";
			this.yearsLabel.Size = new System.Drawing.Size(74, 13);
			this.yearsLabel.TabIndex = 6;
			this.yearsLabel.Text = "Год обучения";
			this.yearsLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// fullnameBox
			// 
			this.fullnameBox.Location = new System.Drawing.Point(58, 19);
			this.fullnameBox.Name = "fullnameBox";
			this.fullnameBox.Size = new System.Drawing.Size(377, 20);
			this.fullnameBox.TabIndex = 5;
			this.fullnameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
			// 
			// groupBox
			// 
			this.groupBox.Location = new System.Drawing.Point(58, 47);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(78, 20);
			this.groupBox.TabIndex = 3;
			// 
			// groupLabel
			// 
			this.groupLabel.AutoSize = true;
			this.groupLabel.Location = new System.Drawing.Point(10, 50);
			this.groupLabel.Name = "groupLabel";
			this.groupLabel.Size = new System.Drawing.Size(42, 13);
			this.groupLabel.TabIndex = 1;
			this.groupLabel.Text = "Группа";
			this.groupLabel.Click += new System.EventHandler(this.surnameLabel_Click);
			// 
			// fullnameLabel
			// 
			this.fullnameLabel.AutoSize = true;
			this.fullnameLabel.Location = new System.Drawing.Point(10, 23);
			this.fullnameLabel.Name = "fullnameLabel";
			this.fullnameLabel.Size = new System.Drawing.Size(34, 13);
			this.fullnameLabel.TabIndex = 0;
			this.fullnameLabel.Text = "ФИО";
			// 
			// SendButton
			// 
			this.SendButton.Location = new System.Drawing.Point(196, 309);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(69, 23);
			this.SendButton.TabIndex = 9;
			this.SendButton.Text = "Отправить";
			this.SendButton.UseVisualStyleBackColor = true;
			this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
			// 
			// dbCheckBox
			// 
			this.dbCheckBox.AutoSize = true;
			this.dbCheckBox.Location = new System.Drawing.Point(178, 289);
			this.dbCheckBox.Name = "dbCheckBox";
			this.dbCheckBox.Size = new System.Drawing.Size(15, 14);
			this.dbCheckBox.TabIndex = 13;
			this.dbCheckBox.UseVisualStyleBackColor = true;
			// 
			// choicePathToProgramLabel
			// 
			this.choicePathToProgramLabel.AutoSize = true;
			this.choicePathToProgramLabel.Location = new System.Drawing.Point(22, 289);
			this.choicePathToProgramLabel.Name = "choicePathToProgramLabel";
			this.choicePathToProgramLabel.Size = new System.Drawing.Size(150, 13);
			this.choicePathToProgramLabel.TabIndex = 12;
			this.choicePathToProgramLabel.Text = "Сохранить результаты в БД";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 266);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(168, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Отправить результаты на почту";
			// 
			// mailBox
			// 
			this.mailBox.Location = new System.Drawing.Point(196, 263);
			this.mailBox.Name = "mailBox";
			this.mailBox.Size = new System.Drawing.Size(251, 20);
			this.mailBox.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.subjectVariantBox);
			this.groupBox1.Controls.Add(this.subjectVariantLabel);
			this.groupBox1.Controls.Add(this.subjectTaskBox);
			this.groupBox1.Controls.Add(this.subjectTaskLabel);
			this.groupBox1.Controls.Add(this.subjectNameBox);
			this.groupBox1.Controls.Add(this.subjectNameLabel);
			this.groupBox1.Location = new System.Drawing.Point(12, 150);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(446, 104);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Предмет";
			// 
			// subjectVariantBox
			// 
			this.subjectVariantBox.Location = new System.Drawing.Point(73, 71);
			this.subjectVariantBox.Name = "subjectVariantBox";
			this.subjectVariantBox.Size = new System.Drawing.Size(362, 20);
			this.subjectVariantBox.TabIndex = 9;
			this.subjectVariantBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label7
			// 
			this.subjectVariantLabel.AutoSize = true;
			this.subjectVariantLabel.Location = new System.Drawing.Point(10, 75);
			this.subjectVariantLabel.Name = "label7";
			this.subjectVariantLabel.Size = new System.Drawing.Size(49, 13);
			this.subjectVariantLabel.TabIndex = 8;
			this.subjectVariantLabel.Text = "Вариант";
			// 
			// subjectTaskBox
			// 
			this.subjectTaskBox.Location = new System.Drawing.Point(73, 45);
			this.subjectTaskBox.Name = "subjectTaskBox";
			this.subjectTaskBox.Size = new System.Drawing.Size(362, 20);
			this.subjectTaskBox.TabIndex = 7;
			this.subjectTaskBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label6
			// 
			this.subjectTaskLabel.AutoSize = true;
			this.subjectTaskLabel.Location = new System.Drawing.Point(10, 48);
			this.subjectTaskLabel.Name = "label6";
			this.subjectTaskLabel.Size = new System.Drawing.Size(50, 13);
			this.subjectTaskLabel.TabIndex = 6;
			this.subjectTaskLabel.Text = "Задание";
			// 
			// subjectNameBox
			// 
			this.subjectNameBox.Location = new System.Drawing.Point(73, 19);
			this.subjectNameBox.Name = "subjectNameBox";
			this.subjectNameBox.Size = new System.Drawing.Size(362, 20);
			this.subjectNameBox.TabIndex = 5;
			this.subjectNameBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// label12
			// 
			this.subjectNameLabel.AutoSize = true;
			this.subjectNameLabel.Location = new System.Drawing.Point(10, 23);
			this.subjectNameLabel.Name = "label12";
			this.subjectNameLabel.Size = new System.Drawing.Size(57, 13);
			this.subjectNameLabel.TabIndex = 0;
			this.subjectNameLabel.Text = "Название";
			// 
			// SendForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 339);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.mailBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dbCheckBox);
			this.Controls.Add(this.choicePathToProgramLabel);
			this.Controls.Add(this.personalData);
			this.Controls.Add(this.SendButton);
			this.Name = "SendForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Отправка результатов";
			this.personalData.ResumeLayout(false);
			this.personalData.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox personalData;
		private System.Windows.Forms.TextBox fullnameBox;
		private System.Windows.Forms.TextBox groupBox;
		private System.Windows.Forms.Label groupLabel;
		private System.Windows.Forms.Label fullnameLabel;
		private System.Windows.Forms.Button SendButton;
		private System.Windows.Forms.TextBox scoreBox;
		private System.Windows.Forms.Label testResultLabel;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.ComboBox yearsBox;
		private System.Windows.Forms.TextBox semesterBox;
		private System.Windows.Forms.Label semesterLabel;
		private System.Windows.Forms.Label yearsLabel;
		private System.Windows.Forms.CheckBox dbCheckBox;
		private System.Windows.Forms.Label choicePathToProgramLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox testResultBox;
		private System.Windows.Forms.TextBox mailBox;
		private System.Windows.Forms.Label extraLabel;
		private System.Windows.Forms.TextBox extraBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox subjectNameBox;
		private System.Windows.Forms.Label subjectNameLabel;
		private System.Windows.Forms.TextBox subjectVariantBox;
		private System.Windows.Forms.Label subjectVariantLabel;
		private System.Windows.Forms.TextBox subjectTaskBox;
		private System.Windows.Forms.Label subjectTaskLabel;
	}
}