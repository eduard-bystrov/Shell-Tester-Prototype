namespace UserInterface
{
	partial class CreateNewProblem
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
			this.StartTestingButton = new System.Windows.Forms.Button();
			this.testerData = new System.Windows.Forms.GroupBox();
			this.choicePathToProgramLabel = new System.Windows.Forms.Label();
			this.choicePathToTestsetLabel = new System.Windows.Forms.Label();
			this.choicePathToProgramButton = new System.Windows.Forms.Button();
			this.choicePathToTestsetButton = new System.Windows.Forms.Button();
			this.choicePathToProgramBox = new System.Windows.Forms.TextBox();
			this.choicePathToTestsetBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.testerData.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// StartTestingButton
			// 
			this.StartTestingButton.Location = new System.Drawing.Point(120, 310);
			this.StartTestingButton.Name = "StartTestingButton";
			this.StartTestingButton.Size = new System.Drawing.Size(130, 22);
			this.StartTestingButton.TabIndex = 5;
			this.StartTestingButton.Text = "Сгенерировать пакет";
			this.StartTestingButton.UseVisualStyleBackColor = true;
			// 
			// testerData
			// 
			this.testerData.Controls.Add(this.choicePathToProgramLabel);
			this.testerData.Controls.Add(this.choicePathToTestsetLabel);
			this.testerData.Controls.Add(this.choicePathToProgramButton);
			this.testerData.Controls.Add(this.choicePathToTestsetButton);
			this.testerData.Controls.Add(this.choicePathToProgramBox);
			this.testerData.Controls.Add(this.choicePathToTestsetBox);
			this.testerData.Location = new System.Drawing.Point(12, 12);
			this.testerData.Name = "testerData";
			this.testerData.Size = new System.Drawing.Size(352, 110);
			this.testerData.TabIndex = 4;
			this.testerData.TabStop = false;
			this.testerData.Text = "Входные данные";
			// 
			// choicePathToProgramLabel
			// 
			this.choicePathToProgramLabel.AutoSize = true;
			this.choicePathToProgramLabel.Location = new System.Drawing.Point(6, 57);
			this.choicePathToProgramLabel.Name = "choicePathToProgramLabel";
			this.choicePathToProgramLabel.Size = new System.Drawing.Size(66, 13);
			this.choicePathToProgramLabel.TabIndex = 10;
			this.choicePathToProgramLabel.Text = "Программа";
			// 
			// choicePathToTestsetLabel
			// 
			this.choicePathToTestsetLabel.AutoSize = true;
			this.choicePathToTestsetLabel.Location = new System.Drawing.Point(6, 18);
			this.choicePathToTestsetLabel.Name = "choicePathToTestsetLabel";
			this.choicePathToTestsetLabel.Size = new System.Drawing.Size(89, 13);
			this.choicePathToTestsetLabel.TabIndex = 3;
			this.choicePathToTestsetLabel.Text = "Тестовый пакет";
			// 
			// choicePathToProgramButton
			// 
			this.choicePathToProgramButton.Location = new System.Drawing.Point(279, 70);
			this.choicePathToProgramButton.Name = "choicePathToProgramButton";
			this.choicePathToProgramButton.Size = new System.Drawing.Size(63, 23);
			this.choicePathToProgramButton.TabIndex = 9;
			this.choicePathToProgramButton.Text = "Выбрать";
			this.choicePathToProgramButton.UseVisualStyleBackColor = true;
			// 
			// choicePathToTestsetButton
			// 
			this.choicePathToTestsetButton.Location = new System.Drawing.Point(279, 31);
			this.choicePathToTestsetButton.Name = "choicePathToTestsetButton";
			this.choicePathToTestsetButton.Size = new System.Drawing.Size(63, 23);
			this.choicePathToTestsetButton.TabIndex = 8;
			this.choicePathToTestsetButton.Text = "Выбрать";
			this.choicePathToTestsetButton.UseVisualStyleBackColor = true;
			// 
			// choicePathToProgramBox
			// 
			this.choicePathToProgramBox.Location = new System.Drawing.Point(6, 73);
			this.choicePathToProgramBox.Name = "choicePathToProgramBox";
			this.choicePathToProgramBox.ReadOnly = true;
			this.choicePathToProgramBox.Size = new System.Drawing.Size(267, 20);
			this.choicePathToProgramBox.TabIndex = 7;
			this.choicePathToProgramBox.Text = "Путь к программе";
			// 
			// choicePathToTestsetBox
			// 
			this.choicePathToTestsetBox.Location = new System.Drawing.Point(6, 34);
			this.choicePathToTestsetBox.Name = "choicePathToTestsetBox";
			this.choicePathToTestsetBox.ReadOnly = true;
			this.choicePathToTestsetBox.Size = new System.Drawing.Size(267, 20);
			this.choicePathToTestsetBox.TabIndex = 6;
			this.choicePathToTestsetBox.Text = "Путь к тестам";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 176);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ограничения";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Время выполнения ms";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Память MB";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(336, 20);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 34);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(336, 20);
			this.textBox2.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Особые ограничения";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(279, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(63, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Выбрать";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 112);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(267, 20);
			this.textBox3.TabIndex = 13;
			this.textBox3.Text = "Путь к файлу";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(9, 138);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(179, 17);
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "Видимость результатов теста";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// CreateNewProblem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 346);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.StartTestingButton);
			this.Controls.Add(this.testerData);
			this.Name = "CreateNewProblem";
			this.Text = "Создание новой задачи";
			this.testerData.ResumeLayout(false);
			this.testerData.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button StartTestingButton;
		private System.Windows.Forms.GroupBox testerData;
		private System.Windows.Forms.Label choicePathToProgramLabel;
		private System.Windows.Forms.Label choicePathToTestsetLabel;
		private System.Windows.Forms.Button choicePathToProgramButton;
		private System.Windows.Forms.Button choicePathToTestsetButton;
		private System.Windows.Forms.TextBox choicePathToProgramBox;
		private System.Windows.Forms.TextBox choicePathToTestsetBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
	}
}