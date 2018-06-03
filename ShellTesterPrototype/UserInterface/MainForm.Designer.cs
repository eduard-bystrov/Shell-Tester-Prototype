using System.Reflection;

namespace UserInterface
{
	partial class MainForm
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.choicePathToProgramButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.choiceTestsetButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TimelimitBox = new System.Windows.Forms.TextBox();
			this.MemorylimitBox = new System.Windows.Forms.TextBox();
			this.StartTestingButton = new System.Windows.Forms.Button();
			this.PathToTestsetBox = new System.Windows.Forms.TextBox();
			this.choicePathToProgramLabel = new System.Windows.Forms.Label();
			this.PathToProgramBox = new System.Windows.Forms.TextBox();
			this.choicePathToTestsetLabel = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ResultTestRunBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.SendResultButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.choiceTryBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.AboutToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(897, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "MenuStrip";
			// 
			// SettingsToolStripMenuItem
			// 
			this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
			this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.SettingsToolStripMenuItem.Text = "Настройки";
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.AboutToolStripMenuItem.Text = "Справка";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.choicePathToProgramButton);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.choiceTestsetButton);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.StartTestingButton);
			this.panel1.Controls.Add(this.PathToTestsetBox);
			this.panel1.Controls.Add(this.choicePathToProgramLabel);
			this.panel1.Controls.Add(this.PathToProgramBox);
			this.panel1.Controls.Add(this.choicePathToTestsetLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(274, 546);
			this.panel1.TabIndex = 4;
			// 
			// choicePathToProgramButton
			// 
			this.choicePathToProgramButton.Location = new System.Drawing.Point(191, 218);
			this.choicePathToProgramButton.Name = "choicePathToProgramButton";
			this.choicePathToProgramButton.Size = new System.Drawing.Size(69, 20);
			this.choicePathToProgramButton.TabIndex = 17;
			this.choicePathToProgramButton.Text = "Выбрать";
			this.choicePathToProgramButton.UseVisualStyleBackColor = true;
			this.choicePathToProgramButton.Click += new System.EventHandler(this.ChoicePathToProgramButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(91, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Проверка работы";
			// 
			// choiceTestsetButton
			// 
			this.choiceTestsetButton.Location = new System.Drawing.Point(191, 60);
			this.choiceTestsetButton.Name = "choiceTestsetButton";
			this.choiceTestsetButton.Size = new System.Drawing.Size(69, 20);
			this.choiceTestsetButton.TabIndex = 11;
			this.choiceTestsetButton.Text = "Выбрать";
			this.choiceTestsetButton.UseVisualStyleBackColor = true;
			this.choiceTestsetButton.Click += new System.EventHandler(this.ChoiceTestsetButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TimelimitBox);
			this.groupBox1.Controls.Add(this.MemorylimitBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(254, 112);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ограничения";
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
			// TimelimitBox
			// 
			this.TimelimitBox.Location = new System.Drawing.Point(6, 73);
			this.TimelimitBox.Name = "TimelimitBox";
			this.TimelimitBox.ReadOnly = true;
			this.TimelimitBox.Size = new System.Drawing.Size(242, 20);
			this.TimelimitBox.TabIndex = 7;
			// 
			// MemorylimitBox
			// 
			this.MemorylimitBox.Location = new System.Drawing.Point(6, 34);
			this.MemorylimitBox.Name = "MemorylimitBox";
			this.MemorylimitBox.ReadOnly = true;
			this.MemorylimitBox.Size = new System.Drawing.Size(242, 20);
			this.MemorylimitBox.TabIndex = 6;
			// 
			// StartTestingButton
			// 
			this.StartTestingButton.Location = new System.Drawing.Point(58, 244);
			this.StartTestingButton.Name = "StartTestingButton";
			this.StartTestingButton.Size = new System.Drawing.Size(130, 22);
			this.StartTestingButton.TabIndex = 11;
			this.StartTestingButton.Text = "Запуск";
			this.StartTestingButton.UseVisualStyleBackColor = true;
			this.StartTestingButton.Click += new System.EventHandler(this.StartTestingButton_Click);
			// 
			// PathToTestsetBox
			// 
			this.PathToTestsetBox.Location = new System.Drawing.Point(18, 61);
			this.PathToTestsetBox.Name = "PathToTestsetBox";
			this.PathToTestsetBox.Size = new System.Drawing.Size(170, 20);
			this.PathToTestsetBox.TabIndex = 13;
			// 
			// choicePathToProgramLabel
			// 
			this.choicePathToProgramLabel.AutoSize = true;
			this.choicePathToProgramLabel.Location = new System.Drawing.Point(15, 202);
			this.choicePathToProgramLabel.Name = "choicePathToProgramLabel";
			this.choicePathToProgramLabel.Size = new System.Drawing.Size(66, 13);
			this.choicePathToProgramLabel.TabIndex = 16;
			this.choicePathToProgramLabel.Text = "Программа";
			// 
			// PathToProgramBox
			// 
			this.PathToProgramBox.Location = new System.Drawing.Point(18, 218);
			this.PathToProgramBox.Name = "PathToProgramBox";
			this.PathToProgramBox.Size = new System.Drawing.Size(170, 20);
			this.PathToProgramBox.TabIndex = 15;
			// 
			// choicePathToTestsetLabel
			// 
			this.choicePathToTestsetLabel.AutoSize = true;
			this.choicePathToTestsetLabel.Location = new System.Drawing.Point(18, 45);
			this.choicePathToTestsetLabel.Name = "choicePathToTestsetLabel";
			this.choicePathToTestsetLabel.Size = new System.Drawing.Size(89, 13);
			this.choicePathToTestsetLabel.TabIndex = 12;
			this.choicePathToTestsetLabel.Text = "Тестовый пакет";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.ResultTestRunBox);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.SendResultButton);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.choiceTryBox);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(274, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(623, 546);
			this.panel2.TabIndex = 5;
			// 
			// ResultTestRunBox
			// 
			this.ResultTestRunBox.Location = new System.Drawing.Point(125, 124);
			this.ResultTestRunBox.Name = "ResultTestRunBox";
			this.ResultTestRunBox.ReadOnly = true;
			this.ResultTestRunBox.Size = new System.Drawing.Size(107, 20);
			this.ResultTestRunBox.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Пройденные тесты";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(18, 160);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(585, 346);
			this.dataGridView1.TabIndex = 13;
			// 
			// SendResultButton
			// 
			this.SendResultButton.Location = new System.Drawing.Point(258, 512);
			this.SendResultButton.Name = "SendResultButton";
			this.SendResultButton.Size = new System.Drawing.Size(130, 22);
			this.SendResultButton.TabIndex = 12;
			this.SendResultButton.Text = "Отправить результат";
			this.SendResultButton.UseVisualStyleBackColor = true;
			this.SendResultButton.Click += new System.EventHandler(this.SendResultButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(237, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(126, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Информация о запуске";
			// 
			// choiceTryBox
			// 
			this.choiceTryBox.FormattingEnabled = true;
			this.choiceTryBox.Location = new System.Drawing.Point(107, 54);
			this.choiceTryBox.Name = "choiceTryBox";
			this.choiceTryBox.Size = new System.Drawing.Size(486, 21);
			this.choiceTryBox.TabIndex = 2;
			this.choiceTryBox.SelectedIndexChanged += new System.EventHandler(this.ChoiceTryBox_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Выбор попытки";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(237, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Результаты тестирования";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 570);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "Тестировщик программ-решений ";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	
		#endregion
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;

		private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TimelimitBox;
		private System.Windows.Forms.TextBox MemorylimitBox;
		private System.Windows.Forms.Button StartTestingButton;
		private System.Windows.Forms.TextBox PathToTestsetBox;
		private System.Windows.Forms.Label choicePathToProgramLabel;
		private System.Windows.Forms.TextBox PathToProgramBox;
		private System.Windows.Forms.Label choicePathToTestsetLabel;
		private System.Windows.Forms.Button choiceTestsetButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button choicePathToProgramButton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button SendResultButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox choiceTryBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ResultTestRunBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

