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
			this.personalData.SuspendLayout();
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
			this.personalData.Location = new System.Drawing.Point(12, 12);
			this.personalData.Name = "personalData";
			this.personalData.Size = new System.Drawing.Size(294, 110);
			this.personalData.TabIndex = 0;
			this.personalData.TabStop = false;
			this.personalData.Text = "Персональные данные";
			this.personalData.Enter += new System.EventHandler(this.PersonalData_Enter);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(72, 20);
			this.nameBox.Name = "nameBox";
			this.nameBox.Text = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(218, 20);
			this.nameBox.TabIndex = 5;
			// 
			// groupBox
			// 
			this.groupBox.Location = new System.Drawing.Point(72, 67);
			this.groupBox.Name = "groupBox";
			this.groupBox.Text = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(218, 20);
			this.groupBox.TabIndex = 4;
			// 
			// groupTextBox
			// 
			this.surnameBox.Location = new System.Drawing.Point(72, 43);
			this.surnameBox.Name = "surnameBox";
			this.surnameBox.Text = "surnameBox";
			this.surnameBox.Size = new System.Drawing.Size(218, 20);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.personalData);
			this.Name = "MainForm";
			this.Text = $"Тестировщик программ-решений {Assembly.GetExecutingAssembly().GetName().Version}";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.personalData.ResumeLayout(false);
			this.personalData.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox personalData;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label groupLabel;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox groupBox;
		private System.Windows.Forms.TextBox surnameBox;
	}
}

