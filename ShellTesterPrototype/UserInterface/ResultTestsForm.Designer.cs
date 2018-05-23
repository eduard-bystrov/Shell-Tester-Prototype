namespace UserInterface
{
	partial class ResultTestsForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.testerData = new System.Windows.Forms.GroupBox();
			this.choicePathToProgramLabel = new System.Windows.Forms.Label();
			this.choicePathToTestsetLabel = new System.Windows.Forms.Label();
			this.choicePathToProgramButton = new System.Windows.Forms.Button();
			this.choicePathToTestsetButton = new System.Windows.Forms.Button();
			this.choicePathToTestsetBox = new System.Windows.Forms.TextBox();
			this.personalData = new System.Windows.Forms.GroupBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.surnameBox = new System.Windows.Forms.TextBox();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.testerData.SuspendLayout();
			this.personalData.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(370, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(397, 405);
			this.dataGridView1.TabIndex = 2;
			// 
			// testerData
			// 
			this.testerData.Controls.Add(this.choicePathToProgramLabel);
			this.testerData.Controls.Add(this.choicePathToTestsetLabel);
			this.testerData.Controls.Add(this.choicePathToProgramButton);
			this.testerData.Controls.Add(this.choicePathToTestsetButton);
			this.testerData.Controls.Add(this.choicePathToTestsetBox);
			this.testerData.Location = new System.Drawing.Point(12, 97);
			this.testerData.Name = "testerData";
			this.testerData.Size = new System.Drawing.Size(352, 110);
			this.testerData.TabIndex = 3;
			this.testerData.TabStop = false;
			this.testerData.Text = "Отправка результатов тестирования";
			// 
			// choicePathToProgramLabel
			// 
			this.choicePathToProgramLabel.AutoSize = true;
			this.choicePathToProgramLabel.Location = new System.Drawing.Point(6, 75);
			this.choicePathToProgramLabel.Name = "choicePathToProgramLabel";
			this.choicePathToProgramLabel.Size = new System.Drawing.Size(151, 13);
			this.choicePathToProgramLabel.TabIndex = 10;
			this.choicePathToProgramLabel.Text = "Отправить результаты в БД";
			// 
			// choicePathToTestsetLabel
			// 
			this.choicePathToTestsetLabel.AutoSize = true;
			this.choicePathToTestsetLabel.Location = new System.Drawing.Point(6, 18);
			this.choicePathToTestsetLabel.Name = "choicePathToTestsetLabel";
			this.choicePathToTestsetLabel.Size = new System.Drawing.Size(37, 13);
			this.choicePathToTestsetLabel.TabIndex = 3;
			this.choicePathToTestsetLabel.Text = "Почта";
			// 
			// choicePathToProgramButton
			// 
			this.choicePathToProgramButton.Location = new System.Drawing.Point(163, 70);
			this.choicePathToProgramButton.Name = "choicePathToProgramButton";
			this.choicePathToProgramButton.Size = new System.Drawing.Size(69, 23);
			this.choicePathToProgramButton.TabIndex = 9;
			this.choicePathToProgramButton.Text = "Отправить";
			this.choicePathToProgramButton.UseVisualStyleBackColor = true;
			// 
			// choicePathToTestsetButton
			// 
			this.choicePathToTestsetButton.Location = new System.Drawing.Point(273, 31);
			this.choicePathToTestsetButton.Name = "choicePathToTestsetButton";
			this.choicePathToTestsetButton.Size = new System.Drawing.Size(73, 23);
			this.choicePathToTestsetButton.TabIndex = 8;
			this.choicePathToTestsetButton.Text = "Отправить";
			this.choicePathToTestsetButton.UseVisualStyleBackColor = true;
			// 
			// choicePathToTestsetBox
			// 
			this.choicePathToTestsetBox.Location = new System.Drawing.Point(6, 34);
			this.choicePathToTestsetBox.Name = "choicePathToTestsetBox";
			this.choicePathToTestsetBox.ReadOnly = true;
			this.choicePathToTestsetBox.Size = new System.Drawing.Size(261, 20);
			this.choicePathToTestsetBox.TabIndex = 6;
			this.choicePathToTestsetBox.Text = "Введите почту";
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
			this.personalData.TabIndex = 4;
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
			// ResultTestsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 441);
			this.Controls.Add(this.personalData);
			this.Controls.Add(this.testerData);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ResultTestsForm";
			this.Text = "Результаты тестирования";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.testerData.ResumeLayout(false);
			this.testerData.PerformLayout();
			this.personalData.ResumeLayout(false);
			this.personalData.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox testerData;
		private System.Windows.Forms.Label choicePathToProgramLabel;
		private System.Windows.Forms.Label choicePathToTestsetLabel;
		private System.Windows.Forms.Button choicePathToProgramButton;
		private System.Windows.Forms.Button choicePathToTestsetButton;
		private System.Windows.Forms.TextBox choicePathToTestsetBox;
		private System.Windows.Forms.GroupBox personalData;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox surnameBox;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label nameLabel;
	}
}