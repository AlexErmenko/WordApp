namespace Word_Application
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
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
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1      = new System.Windows.Forms.OpenFileDialog();
			this.fontDialog1          = new System.Windows.Forms.FontDialog();
			this.tabPage2             = new System.Windows.Forms.TabPage();
			this.SearchText           = new System.Windows.Forms.TextBox();
			this.groupBox1            = new System.Windows.Forms.GroupBox();
			this.label5               = new System.Windows.Forms.Label();
			this.AligmentCbb          = new System.Windows.Forms.ComboBox();
			this.FontDoc              = new System.Windows.Forms.Button();
			this.label4               = new System.Windows.Forms.Label();
			this.SearchDoc            = new System.Windows.Forms.Button();
			this.tabPage1             = new System.Windows.Forms.TabPage();
			this.PickImage            = new System.Windows.Forms.Button();
			this.CreateTable          = new System.Windows.Forms.Button();
			this.DocumentTable        = new System.Windows.Forms.DataGridView();
			this.Col1                 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col2                 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col3                 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col4                 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col5                 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SaveDoc              = new System.Windows.Forms.Button();
			this.OpenDocument         = new System.Windows.Forms.Button();
			this.VisibleDoc           = new System.Windows.Forms.CheckBox();
			this.CreateDocument       = new System.Windows.Forms.Button();
			this.tabControl1          = new System.Windows.Forms.TabControl();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.DocumentTable)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// fontDialog1
			// 
			this.fontDialog1.ScriptsOnly = true;
			this.fontDialog1.ShowApply   = true;
			this.fontDialog1.ShowColor   = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.SearchText);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.SearchDoc);
			this.tabPage2.Location                = new System.Drawing.Point(4, 25);
			this.tabPage2.Name                    = "tabPage2";
			this.tabPage2.Padding                 = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size                    = new System.Drawing.Size(1139, 652);
			this.tabPage2.TabIndex                = 1;
			this.tabPage2.Text                    = "Работа с текстом";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// SearchText
			// 
			this.SearchText.Location = new System.Drawing.Point(147, 41);
			this.SearchText.Margin   = new System.Windows.Forms.Padding(4);
			this.SearchText.Name     = "SearchText";
			this.SearchText.Size     = new System.Drawing.Size(132, 23);
			this.SearchText.TabIndex = 50;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.AligmentCbb);
			this.groupBox1.Controls.Add(this.FontDoc);
			this.groupBox1.Dock     = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(3, 421);
			this.groupBox1.Name     = "groupBox1";
			this.groupBox1.Size     = new System.Drawing.Size(1133, 228);
			this.groupBox1.TabIndex = 49;
			this.groupBox1.TabStop  = false;
			this.groupBox1.Text     = "Форматирования текста";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 44);
			this.label5.Margin   = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name     = "label5";
			this.label5.Size     = new System.Drawing.Size(104, 17);
			this.label5.TabIndex = 52;
			this.label5.Text     = "Выровнять по ";
			// 
			// AligmentCbb
			// 
			this.AligmentCbb.DropDownStyle     = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AligmentCbb.FormattingEnabled = true;
			this.AligmentCbb.Location          = new System.Drawing.Point(155, 37);
			this.AligmentCbb.Name              = "AligmentCbb";
			this.AligmentCbb.Size              = new System.Drawing.Size(121, 24);
			this.AligmentCbb.TabIndex          = 51;
			// 
			// FontDoc
			// 
			this.FontDoc.Location                =  new System.Drawing.Point(23, 91);
			this.FontDoc.Margin                  =  new System.Windows.Forms.Padding(4);
			this.FontDoc.Name                    =  "FontDoc";
			this.FontDoc.Size                    =  new System.Drawing.Size(172, 38);
			this.FontDoc.TabIndex                =  50;
			this.FontDoc.Text                    =  "Формат шрифта";
			this.FontDoc.UseVisualStyleBackColor =  true;
			this.FontDoc.Click                   += new System.EventHandler(this.FontDoc_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 47);
			this.label4.Margin   = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name     = "label4";
			this.label4.Size     = new System.Drawing.Size(117, 17);
			this.label4.TabIndex = 43;
			this.label4.Text     = "Текс для поиска";
			// 
			// SearchDoc
			// 
			this.SearchDoc.Location                = new System.Drawing.Point(147, 133);
			this.SearchDoc.Margin                  = new System.Windows.Forms.Padding(4);
			this.SearchDoc.Name                    = "SearchDoc";
			this.SearchDoc.Size                    = new System.Drawing.Size(124, 38);
			this.SearchDoc.TabIndex                = 41;
			this.SearchDoc.Text                    = "Search";
			this.SearchDoc.UseVisualStyleBackColor = true;
			this.SearchDoc.Click +=
					new System.EventHandler(this.SearchInDocument_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
			this.tabPage1.Controls.Add(this.PickImage);
			this.tabPage1.Controls.Add(this.CreateTable);
			this.tabPage1.Controls.Add(this.DocumentTable);
			this.tabPage1.Controls.Add(this.SaveDoc);
			this.tabPage1.Controls.Add(this.OpenDocument);
			this.tabPage1.Controls.Add(this.VisibleDoc);
			this.tabPage1.Controls.Add(this.CreateDocument);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name     = "tabPage1";
			this.tabPage1.Padding  = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size     = new System.Drawing.Size(1139, 652);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text     = "Работа с документом";
			// 
			// PickImage
			// 
			this.PickImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.PickImage.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
			this.PickImage.ForeColor =
					System.Drawing.SystemColors.ControlLightLight;
			this.PickImage.Location                = new System.Drawing.Point(18, 215);
			this.PickImage.Margin                  = new System.Windows.Forms.Padding(4);
			this.PickImage.Name                    = "PickImage";
			this.PickImage.Size                    = new System.Drawing.Size(259, 38);
			this.PickImage.TabIndex                = 44;
			this.PickImage.Text                    = "Додати зображення";
			this.PickImage.UseVisualStyleBackColor = true;
			this.PickImage.Click +=
					new System.EventHandler(this.PickImage_Click);
			// 
			// CreateTable
			// 
			this.CreateTable.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.CreateTable.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
			this.CreateTable.ForeColor =
					System.Drawing.SystemColors.ControlLightLight;
			this.CreateTable.Location                = new System.Drawing.Point(329, 211);
			this.CreateTable.Name                    = "CreateTable";
			this.CreateTable.Size                    = new System.Drawing.Size(264, 42);
			this.CreateTable.TabIndex                = 43;
			this.CreateTable.Text                    = "Додати таблицю";
			this.CreateTable.UseVisualStyleBackColor = true;
			this.CreateTable.Click +=
					new System.EventHandler(this.CreateTable_Click);
			// 
			// DocumentTable
			// 
			this.DocumentTable.AllowUserToOrderColumns = true;
			this.DocumentTable.AutoSizeColumnsMode =
					System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DocumentTable.AutoSizeRowsMode =
					System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.DocumentTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.DocumentTable.ColumnHeadersBorderStyle =
					System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DocumentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms
				.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DocumentTable.ColumnHeadersVisible = false;
			this.DocumentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
												{
														this.Col1, this.Col2, this.Col3, this.Col4,
														this.Col5
												});
			this.DocumentTable.EditMode  = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.DocumentTable.GridColor = System.Drawing.SystemColors.WindowFrame;
			this.DocumentTable.Location  = new System.Drawing.Point(18, 394);
			this.DocumentTable.Margin    = new System.Windows.Forms.Padding(4);
			this.DocumentTable.Name      = "DocumentTable";
			this.DocumentTable.RowHeadersBorderStyle =
					System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DocumentTable.Size     = new System.Drawing.Size(656, 249);
			this.DocumentTable.TabIndex = 42;
			// 
			// Col1
			// 
			this.Col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Col1.HeaderText   = "Колонка № 1";
			this.Col1.Name         = "Col1";
			this.Col1.Width        = 138;
			// 
			// Col2
			// 
			this.Col2.HeaderText = "Колонка № 2";
			this.Col2.Name       = "Col2";
			// 
			// Col3
			// 
			this.Col3.HeaderText = "Колонка № 3";
			this.Col3.Name       = "Col3";
			// 
			// Col4
			// 
			this.Col4.HeaderText = "Колонка № 4";
			this.Col4.Name       = "Col4";
			// 
			// Col5
			// 
			this.Col5.HeaderText = "Колонка № 5";
			this.Col5.Name       = "Col5";
			// 
			// SaveDoc
			// 
			this.SaveDoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.SaveDoc.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
			this.SaveDoc.ForeColor =
					System.Drawing.SystemColors.ControlLightLight;
			this.SaveDoc.Location                =  new System.Drawing.Point(18, 147);
			this.SaveDoc.Margin                  =  new System.Windows.Forms.Padding(4);
			this.SaveDoc.Name                    =  "SaveDoc";
			this.SaveDoc.Size                    =  new System.Drawing.Size(218, 38);
			this.SaveDoc.TabIndex                =  41;
			this.SaveDoc.Text                    =  "Зберегти поточний документ";
			this.SaveDoc.UseVisualStyleBackColor =  true;
			this.SaveDoc.Click                   += new System.EventHandler(this.SaveDoc_Click);
			// 
			// OpenDocument
			// 
			this.OpenDocument.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.OpenDocument.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
			this.OpenDocument.ForeColor =
					System.Drawing.SystemColors.ControlLightLight;
			this.OpenDocument.Location                = new System.Drawing.Point(18, 20);
			this.OpenDocument.Margin                  = new System.Windows.Forms.Padding(4);
			this.OpenDocument.Name                    = "OpenDocument";
			this.OpenDocument.Size                    = new System.Drawing.Size(218, 38);
			this.OpenDocument.TabIndex                = 34;
			this.OpenDocument.Text                    = "Відкрити документ";
			this.OpenDocument.UseVisualStyleBackColor = true;
			this.OpenDocument.Click +=
					new System.EventHandler(this.OpenDocument_Click);
			// 
			// VisibleDoc
			// 
			this.VisibleDoc.AutoSize                = true;
			this.VisibleDoc.ForeColor               = System.Drawing.SystemColors.ControlLightLight;
			this.VisibleDoc.Location                = new System.Drawing.Point(298, 122);
			this.VisibleDoc.Name                    = "VisibleDoc";
			this.VisibleDoc.Size                    = new System.Drawing.Size(177, 21);
			this.VisibleDoc.TabIndex                = 32;
			this.VisibleDoc.Text                    = "Відображати документ";
			this.VisibleDoc.UseVisualStyleBackColor = true;
			this.VisibleDoc.CheckedChanged +=
					new System.EventHandler(this.CheckBox1_CheckedChanged);
			// 
			// CreateDocument
			// 
			this.CreateDocument.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.CreateDocument.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
			this.CreateDocument.ForeColor =
					System.Drawing.SystemColors.ControlLightLight;
			this.CreateDocument.Location                = new System.Drawing.Point(18, 81);
			this.CreateDocument.Margin                  = new System.Windows.Forms.Padding(4);
			this.CreateDocument.Name                    = "CreateDocument";
			this.CreateDocument.Size                    = new System.Drawing.Size(218, 38);
			this.CreateDocument.TabIndex                = 21;
			this.CreateDocument.Text                    = "Створити новий документ";
			this.CreateDocument.UseVisualStyleBackColor = true;
			this.CreateDocument.Click +=
					new System.EventHandler(this.CreateDocument_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock          = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location      = new System.Drawing.Point(0, 0);
			this.tabControl1.Name          = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size          = new System.Drawing.Size(1147, 681);
			this.tabControl1.TabIndex      = 0;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize          = new System.Drawing.Size(1147, 681);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
												System.Drawing.FontStyle.Regular,
												System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin          = new System.Windows.Forms.Padding(4);
			this.MaximizeBox     = false;
			this.MinimizeBox     = false;
			this.Name            = "Main";
			this.ShowIcon        = false;
			this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text            = "Демонстрационная программа для работы с Word";
			this.FormClosing +=
					new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.DocumentTable)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox SearchText;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox AligmentCbb;
		private System.Windows.Forms.Button FontDoc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button SearchDoc;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button CreateTable;
		private System.Windows.Forms.DataGridView DocumentTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
		private System.Windows.Forms.Button SaveDoc;
		private System.Windows.Forms.Button OpenDocument;
		private System.Windows.Forms.CheckBox VisibleDoc;
		private System.Windows.Forms.Button CreateDocument;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button PickImage;
	}
}