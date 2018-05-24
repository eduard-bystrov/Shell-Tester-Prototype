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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.StartTestingButton = new System.Windows.Forms.Button();
			this.choicePathToProgramLabel = new System.Windows.Forms.Label();
			this.choicePathToTestsetLabel = new System.Windows.Forms.Label();
			this.choicePathToProgramBox = new System.Windows.Forms.TextBox();
			this.choicePathToTestsetBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
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
			this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
			// 
			// SettingsToolStripMenuItem
			// 
			this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
			this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.SettingsToolStripMenuItem.Text = "Настройки";
			this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
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
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.StartTestingButton);
			this.panel1.Controls.Add(this.choicePathToTestsetBox);
			this.panel1.Controls.Add(this.choicePathToProgramLabel);
			this.panel1.Controls.Add(this.choicePathToProgramBox);
			this.panel1.Controls.Add(this.choicePathToTestsetLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(274, 546);
			this.panel1.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.textBox2);
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(242, 20);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 34);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(242, 20);
			this.textBox2.TabIndex = 6;
			// 
			// StartTestingButton
			// 
			this.StartTestingButton.Location = new System.Drawing.Point(58, 244);
			this.StartTestingButton.Name = "StartTestingButton";
			this.StartTestingButton.Size = new System.Drawing.Size(130, 22);
			this.StartTestingButton.TabIndex = 11;
			this.StartTestingButton.Text = "Запуск";
			this.StartTestingButton.UseVisualStyleBackColor = true;
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
			// choicePathToTestsetLabel
			// 
			this.choicePathToTestsetLabel.AutoSize = true;
			this.choicePathToTestsetLabel.Location = new System.Drawing.Point(18, 45);
			this.choicePathToTestsetLabel.Name = "choicePathToTestsetLabel";
			this.choicePathToTestsetLabel.Size = new System.Drawing.Size(89, 13);
			this.choicePathToTestsetLabel.TabIndex = 12;
			this.choicePathToTestsetLabel.Text = "Тестовый пакет";
			// 
			// choicePathToProgramBox
			// 
			this.choicePathToProgramBox.Location = new System.Drawing.Point(18, 218);
			this.choicePathToProgramBox.Name = "choicePathToProgramBox";
			this.choicePathToProgramBox.Size = new System.Drawing.Size(170, 20);
			this.choicePathToProgramBox.TabIndex = 15;
			// 
			// choicePathToTestsetBox
			// 
			this.choicePathToTestsetBox.Location = new System.Drawing.Point(18, 61);
			this.choicePathToTestsetBox.Name = "choicePathToTestsetBox";
			this.choicePathToTestsetBox.Size = new System.Drawing.Size(170, 20);
			this.choicePathToTestsetBox.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(191, 60);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(69, 20);
			this.button1.TabIndex = 11;
			this.button1.Text = "Выбрать";
			this.button1.UseVisualStyleBackColor = true;
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
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(191, 218);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(69, 20);
			this.button2.TabIndex = 17;
			this.button2.Text = "Выбрать";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.textBox3);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.comboBox1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(274, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(623, 546);
			this.panel2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(248, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Результаты тестирования";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Выбор попытки";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(125, 54);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(486, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(255, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(126, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Информация о запуске";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(258, 512);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(130, 22);
			this.button3.TabIndex = 12;
			this.button3.Text = "Отправить результат";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 160);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(575, 346);
			this.dataGridView1.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(33, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Пройденные тесты";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(143, 121);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(107, 20);
			this.textBox3.TabIndex = 16;
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
			this.Load += new System.EventHandler(this.MainForm_Load);
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button StartTestingButton;
		private System.Windows.Forms.TextBox choicePathToTestsetBox;
		private System.Windows.Forms.Label choicePathToProgramLabel;
		private System.Windows.Forms.TextBox choicePathToProgramBox;
		private System.Windows.Forms.Label choicePathToTestsetLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

