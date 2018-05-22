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
			this.personalData = new System.Windows.Forms.GroupBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.groupBox = new System.Windows.Forms.TextBox();
			this.surnameBox = new System.Windows.Forms.TextBox();
			this.groupLabel = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.testerData = new System.Windows.Forms.GroupBox();
			this.choicePathToProgramLabel = new System.Windows.Forms.Label();
			this.choicePathToTestsetLabel = new System.Windows.Forms.Label();
			this.choicePathToProgramButton = new System.Windows.Forms.Button();
			this.choicePathToTestsetButton = new System.Windows.Forms.Button();
			this.choicePathToProgramBox = new System.Windows.Forms.TextBox();
			this.choicePathToTestsetBox = new System.Windows.Forms.TextBox();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.CreateProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.StartTestingButton = new System.Windows.Forms.Button();
			this.personalData.SuspendLayout();
			this.testerData.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// personalData
			// 
			this.personalData.Controls.Add(this.nameBox);
			this.personalData.Controls.Add(this.groupBox);
			this.personalData.Controls.Add(this.surnameBox);
			this.personalData.Controls.Add(this.groupLabel);
			this.personalData.Controls.Add(this.surnameLabel);
			this.personalData.Controls.Add(this.nameLabel);
			this.personalData.Location = new System.Drawing.Point(12, 27);
			this.personalData.Name = "personalData";
			this.personalData.Size = new System.Drawing.Size(352, 110);
			this.personalData.TabIndex = 0;
			this.personalData.TabStop = false;
			this.personalData.Text = "Персональные данные";
			this.personalData.Enter += new System.EventHandler(this.PersonalData_Enter);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(72, 20);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(270, 20);
			this.nameBox.TabIndex = 5;
			// 
			// groupBox
			// 
			this.groupBox.Location = new System.Drawing.Point(72, 67);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(270, 20);
			this.groupBox.TabIndex = 4;
			// 
			// surnameBox
			// 
			this.surnameBox.Location = new System.Drawing.Point(72, 43);
			this.surnameBox.Name = "surnameBox";
			this.surnameBox.Size = new System.Drawing.Size(270, 20);
			this.surnameBox.TabIndex = 3;
			// 
			// groupLabel
			// 
			this.groupLabel.AutoSize = true;
			this.groupLabel.Location = new System.Drawing.Point(10, 70);
			this.groupLabel.Name = "groupLabel";
			this.groupLabel.Size = new System.Drawing.Size(42, 13);
			this.groupLabel.TabIndex = 2;
			this.groupLabel.Text = "Группа";
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(10, 46);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(56, 13);
			this.surnameLabel.TabIndex = 1;
			this.surnameLabel.Text = "Фамилия";
			this.surnameLabel.Click += new System.EventHandler(this.SurnameLable_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(10, 23);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(29, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Имя";
			this.nameLabel.Click += new System.EventHandler(this.NameLabel_Click);
			// 
			// testerData
			// 
			this.testerData.Controls.Add(this.choicePathToProgramLabel);
			this.testerData.Controls.Add(this.choicePathToTestsetLabel);
			this.testerData.Controls.Add(this.choicePathToProgramButton);
			this.testerData.Controls.Add(this.choicePathToTestsetButton);
			this.testerData.Controls.Add(this.choicePathToProgramBox);
			this.testerData.Controls.Add(this.choicePathToTestsetBox);
			this.testerData.Location = new System.Drawing.Point(12, 143);
			this.testerData.Name = "testerData";
			this.testerData.Size = new System.Drawing.Size(352, 110);
			this.testerData.TabIndex = 1;
			this.testerData.TabStop = false;
			this.testerData.Text = "Проверка работы";
			// 
			// choicePathToProgramLabel
			// 
			this.choicePathToProgramLabel.AutoSize = true;
			this.choicePathToProgramLabel.Location = new System.Drawing.Point(6, 57);
			this.choicePathToProgramLabel.Name = "choicePathToProgramLabel";
			this.choicePathToProgramLabel.Size = new System.Drawing.Size(143, 13);
			this.choicePathToProgramLabel.TabIndex = 10;
			this.choicePathToProgramLabel.Text = "Введите путь к программе";
			// 
			// choicePathToTestsetLabel
			// 
			this.choicePathToTestsetLabel.AutoSize = true;
			this.choicePathToTestsetLabel.Location = new System.Drawing.Point(6, 18);
			this.choicePathToTestsetLabel.Name = "choicePathToTestsetLabel";
			this.choicePathToTestsetLabel.Size = new System.Drawing.Size(177, 13);
			this.choicePathToTestsetLabel.TabIndex = 3;
			this.choicePathToTestsetLabel.Text = "Введите путь к тестовому набору";
			// 
			// choicePathToProgramButton
			// 
			this.choicePathToProgramButton.Location = new System.Drawing.Point(279, 70);
			this.choicePathToProgramButton.Name = "choicePathToProgramButton";
			this.choicePathToProgramButton.Size = new System.Drawing.Size(63, 23);
			this.choicePathToProgramButton.TabIndex = 9;
			this.choicePathToProgramButton.Text = "Выбрать";
			this.choicePathToProgramButton.UseVisualStyleBackColor = true;
			this.choicePathToProgramButton.Click += new System.EventHandler(this.ChoicePathToProgramButton_Click);
			// 
			// choicePathToTestsetButton
			// 
			this.choicePathToTestsetButton.Location = new System.Drawing.Point(279, 31);
			this.choicePathToTestsetButton.Name = "choicePathToTestsetButton";
			this.choicePathToTestsetButton.Size = new System.Drawing.Size(63, 23);
			this.choicePathToTestsetButton.TabIndex = 8;
			this.choicePathToTestsetButton.Text = "Выбрать";
			this.choicePathToTestsetButton.UseVisualStyleBackColor = true;
			this.choicePathToTestsetButton.Click += new System.EventHandler(this.ChoicePathToTestsetButton_Click);
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
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProblemToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.AboutToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(374, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "MenuStrip";
			this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
			// 
			// CreateProblemToolStripMenuItem
			// 
			this.CreateProblemToolStripMenuItem.Name = "CreateProblemToolStripMenuItem";
			this.CreateProblemToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
			this.CreateProblemToolStripMenuItem.Text = "Создание задачи";
			// 
			// SettingsToolStripMenuItem
			// 
			this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
			this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.SettingsToolStripMenuItem.Text = "Настройки";
			// 
			// справкаToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.AboutToolStripMenuItem.Text = "Справка";
			// 
			// StartTestingButton
			// 
			this.StartTestingButton.Location = new System.Drawing.Point(112, 259);
			this.StartTestingButton.Name = "StartTestingButton";
			this.StartTestingButton.Size = new System.Drawing.Size(130, 22);
			this.StartTestingButton.TabIndex = 3;
			this.StartTestingButton.Text = "Начать тестирование";
			this.StartTestingButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 296);
			this.Controls.Add(this.StartTestingButton);
			this.Controls.Add(this.testerData);
			this.Controls.Add(this.personalData);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "Тестировщик программ-решений ";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.personalData.ResumeLayout(false);
			this.personalData.PerformLayout();
			this.testerData.ResumeLayout(false);
			this.testerData.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	
		#endregion

		private System.Windows.Forms.GroupBox personalData;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label groupLabel;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox groupBox;
		private System.Windows.Forms.TextBox surnameBox;
		private System.Windows.Forms.GroupBox testerData;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;

		private System.Windows.Forms.TextBox choicePathToProgramBox;
		private System.Windows.Forms.TextBox choicePathToTestsetBox
			;
		private System.Windows.Forms.Button choicePathToProgramButton;
		private System.Windows.Forms.Button choicePathToTestsetButton;
		private System.Windows.Forms.Label choicePathToTestsetLabel;
		private System.Windows.Forms.Label choicePathToProgramLabel;


		private System.Windows.Forms.Button StartTestingButton;
		private System.Windows.Forms.ToolStripMenuItem CreateProblemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
	}
}

