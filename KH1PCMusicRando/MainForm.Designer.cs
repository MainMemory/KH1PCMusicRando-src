
namespace KH1PCMusicRando
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
			System.Windows.Forms.MenuStrip menuStrip1;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.GroupBox groupBox1;
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.extractedGamesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customMusicFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categorizeSongsCheckBox = new System.Windows.Forms.CheckBox();
			this.dmcaSafeCheckBox = new System.Windows.Forms.CheckBox();
			this.includeCustomCheckBox = new System.Windows.Forms.CheckBox();
			this.includeBBSCheckBox = new System.Windows.Forms.CheckBox();
			this.includeReCoMCheckBox = new System.Windows.Forms.CheckBox();
			this.includeKH2CheckBox = new System.Windows.Forms.CheckBox();
			this.includeKH1CheckBox = new System.Windows.Forms.CheckBox();
			this.seedTextBox = new System.Windows.Forms.TextBox();
			this.randomizeButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.includeDDDCheckBox = new System.Windows.Forms.CheckBox();
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			label1 = new System.Windows.Forms.Label();
			groupBox1 = new System.Windows.Forms.GroupBox();
			menuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new System.Drawing.Size(304, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractedGamesFolderToolStripMenuItem,
            this.customMusicFolderToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// extractedGamesFolderToolStripMenuItem
			// 
			this.extractedGamesFolderToolStripMenuItem.Name = "extractedGamesFolderToolStripMenuItem";
			this.extractedGamesFolderToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.extractedGamesFolderToolStripMenuItem.Text = "Locate &Extracted Games Folder...";
			this.extractedGamesFolderToolStripMenuItem.Click += new System.EventHandler(this.extractedGamesFolderToolStripMenuItem_Click);
			// 
			// customMusicFolderToolStripMenuItem
			// 
			this.customMusicFolderToolStripMenuItem.Name = "customMusicFolderToolStripMenuItem";
			this.customMusicFolderToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.customMusicFolderToolStripMenuItem.Text = "Locate &Custom Music Folder...";
			this.customMusicFolderToolStripMenuItem.Click += new System.EventHandler(this.customMusicFolderToolStripMenuItem_Click);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(12, 30);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(35, 13);
			label1.TabIndex = 1;
			label1.Text = "Seed:";
			// 
			// groupBox1
			// 
			groupBox1.AutoSize = true;
			groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			groupBox1.Controls.Add(this.flowLayoutPanel1);
			groupBox1.Location = new System.Drawing.Point(12, 53);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
			groupBox1.Size = new System.Drawing.Size(151, 216);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Music Options";
			// 
			// categorizeSongsCheckBox
			// 
			this.categorizeSongsCheckBox.AutoSize = true;
			this.categorizeSongsCheckBox.Location = new System.Drawing.Point(3, 164);
			this.categorizeSongsCheckBox.Name = "categorizeSongsCheckBox";
			this.categorizeSongsCheckBox.Size = new System.Drawing.Size(109, 17);
			this.categorizeSongsCheckBox.TabIndex = 5;
			this.categorizeSongsCheckBox.Text = "Categorize Songs";
			this.categorizeSongsCheckBox.UseVisualStyleBackColor = true;
			// 
			// dmcaSafeCheckBox
			// 
			this.dmcaSafeCheckBox.AutoSize = true;
			this.dmcaSafeCheckBox.Location = new System.Drawing.Point(3, 141);
			this.dmcaSafeCheckBox.Name = "dmcaSafeCheckBox";
			this.dmcaSafeCheckBox.Size = new System.Drawing.Size(82, 17);
			this.dmcaSafeCheckBox.TabIndex = 4;
			this.dmcaSafeCheckBox.Text = "DMCA Safe";
			this.dmcaSafeCheckBox.UseVisualStyleBackColor = true;
			// 
			// includeCustomCheckBox
			// 
			this.includeCustomCheckBox.AutoSize = true;
			this.includeCustomCheckBox.Location = new System.Drawing.Point(3, 118);
			this.includeCustomCheckBox.Name = "includeCustomCheckBox";
			this.includeCustomCheckBox.Size = new System.Drawing.Size(132, 17);
			this.includeCustomCheckBox.TabIndex = 4;
			this.includeCustomCheckBox.Text = "Include Custom Songs";
			this.includeCustomCheckBox.UseVisualStyleBackColor = true;
			// 
			// includeBBSCheckBox
			// 
			this.includeBBSCheckBox.AutoSize = true;
			this.includeBBSCheckBox.Location = new System.Drawing.Point(3, 72);
			this.includeBBSCheckBox.Name = "includeBBSCheckBox";
			this.includeBBSCheckBox.Size = new System.Drawing.Size(118, 17);
			this.includeBBSCheckBox.TabIndex = 3;
			this.includeBBSCheckBox.Text = "Include BBS Songs";
			this.includeBBSCheckBox.UseVisualStyleBackColor = true;
			// 
			// includeReCoMCheckBox
			// 
			this.includeReCoMCheckBox.AutoSize = true;
			this.includeReCoMCheckBox.Location = new System.Drawing.Point(3, 49);
			this.includeReCoMCheckBox.Name = "includeReCoMCheckBox";
			this.includeReCoMCheckBox.Size = new System.Drawing.Size(136, 17);
			this.includeReCoMCheckBox.TabIndex = 2;
			this.includeReCoMCheckBox.Text = "Include Re:CoM Songs";
			this.includeReCoMCheckBox.UseVisualStyleBackColor = true;
			// 
			// includeKH2CheckBox
			// 
			this.includeKH2CheckBox.AutoSize = true;
			this.includeKH2CheckBox.Location = new System.Drawing.Point(3, 26);
			this.includeKH2CheckBox.Name = "includeKH2CheckBox";
			this.includeKH2CheckBox.Size = new System.Drawing.Size(118, 17);
			this.includeKH2CheckBox.TabIndex = 1;
			this.includeKH2CheckBox.Text = "Include KH2 Songs";
			this.includeKH2CheckBox.UseVisualStyleBackColor = true;
			// 
			// includeKH1CheckBox
			// 
			this.includeKH1CheckBox.AutoSize = true;
			this.includeKH1CheckBox.Location = new System.Drawing.Point(3, 3);
			this.includeKH1CheckBox.Name = "includeKH1CheckBox";
			this.includeKH1CheckBox.Size = new System.Drawing.Size(118, 17);
			this.includeKH1CheckBox.TabIndex = 0;
			this.includeKH1CheckBox.Text = "Include KH1 Songs";
			this.includeKH1CheckBox.UseVisualStyleBackColor = true;
			// 
			// seedTextBox
			// 
			this.seedTextBox.Location = new System.Drawing.Point(53, 27);
			this.seedTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this.seedTextBox.Name = "seedTextBox";
			this.seedTextBox.Size = new System.Drawing.Size(223, 20);
			this.seedTextBox.TabIndex = 2;
			// 
			// randomizeButton
			// 
			this.randomizeButton.AutoSize = true;
			this.randomizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.randomizeButton.Location = new System.Drawing.Point(12, 275);
			this.randomizeButton.Name = "randomizeButton";
			this.randomizeButton.Size = new System.Drawing.Size(188, 47);
			this.randomizeButton.TabIndex = 4;
			this.randomizeButton.Text = "Randomize";
			this.randomizeButton.UseVisualStyleBackColor = true;
			this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.includeKH1CheckBox);
			this.flowLayoutPanel1.Controls.Add(this.includeKH2CheckBox);
			this.flowLayoutPanel1.Controls.Add(this.includeReCoMCheckBox);
			this.flowLayoutPanel1.Controls.Add(this.includeBBSCheckBox);
			this.flowLayoutPanel1.Controls.Add(this.includeDDDCheckBox);
			this.flowLayoutPanel1.Controls.Add(this.includeCustomCheckBox);
			this.flowLayoutPanel1.Controls.Add(this.dmcaSafeCheckBox);
			this.flowLayoutPanel1.Controls.Add(this.categorizeSongsCheckBox);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(142, 184);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// includeDDDCheckBox
			// 
			this.includeDDDCheckBox.AutoSize = true;
			this.includeDDDCheckBox.Location = new System.Drawing.Point(3, 95);
			this.includeDDDCheckBox.Name = "includeDDDCheckBox";
			this.includeDDDCheckBox.Size = new System.Drawing.Size(121, 17);
			this.includeDDDCheckBox.TabIndex = 6;
			this.includeDDDCheckBox.Text = "Include DDD Songs";
			this.includeDDDCheckBox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AcceptButton = this.randomizeButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(304, 332);
			this.Controls.Add(this.randomizeButton);
			this.Controls.Add(groupBox1);
			this.Controls.Add(this.seedTextBox);
			this.Controls.Add(label1);
			this.Controls.Add(menuStrip1);
			this.MainMenuStrip = menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "KH1 PC Music Randomizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem extractedGamesFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customMusicFolderToolStripMenuItem;
		private System.Windows.Forms.TextBox seedTextBox;
		private System.Windows.Forms.CheckBox includeKH1CheckBox;
		private System.Windows.Forms.CheckBox includeKH2CheckBox;
		private System.Windows.Forms.CheckBox includeReCoMCheckBox;
		private System.Windows.Forms.CheckBox includeBBSCheckBox;
		private System.Windows.Forms.CheckBox includeCustomCheckBox;
		private System.Windows.Forms.CheckBox dmcaSafeCheckBox;
		private System.Windows.Forms.CheckBox categorizeSongsCheckBox;
		private System.Windows.Forms.Button randomizeButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.CheckBox includeDDDCheckBox;
	}
}

