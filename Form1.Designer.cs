namespace SLVP_PeerToPeer_FilesAndStreams_CountingIfStatements
{
    partial class IfLineFinderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Dgv = new DataGridView();
            LblDgv = new Label();
            TbFile = new TextBox();
            LblFile = new Label();
            BtnFile = new Button();
            LblCount = new Label();
            LblCountText = new Label();
            ChbDebug = new CheckBox();
            ChbSaveFile = new CheckBox();
            LblSaveFile = new Label();
            TbSaveFile = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Dgv).BeginInit();
            SuspendLayout();
            // 
            // Dgv
            // 
            Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv.Location = new Point(222, 39);
            Dgv.Name = "Dgv";
            Dgv.ReadOnly = true;
            Dgv.RowHeadersVisible = false;
            Dgv.RowTemplate.Height = 25;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.Size = new Size(363, 389);
            Dgv.TabIndex = 0;
            // 
            // LblDgv
            // 
            LblDgv.AutoSize = true;
            LblDgv.Location = new Point(222, 21);
            LblDgv.Name = "LblDgv";
            LblDgv.Size = new Size(168, 15);
            LblDgv.TabIndex = 1;
            LblDgv.Text = "Lines containing if statements:";
            // 
            // TbFile
            // 
            TbFile.Location = new Point(17, 39);
            TbFile.Name = "TbFile";
            TbFile.Size = new Size(100, 23);
            TbFile.TabIndex = 2;
            // 
            // LblFile
            // 
            LblFile.AutoSize = true;
            LblFile.Location = new Point(15, 21);
            LblFile.Name = "LblFile";
            LblFile.Size = new Size(113, 15);
            LblFile.TabIndex = 3;
            LblFile.Text = "Enter a file to check:";
            // 
            // BtnFile
            // 
            BtnFile.Location = new Point(15, 68);
            BtnFile.Name = "BtnFile";
            BtnFile.Size = new Size(75, 23);
            BtnFile.TabIndex = 4;
            BtnFile.Text = "Check";
            BtnFile.UseVisualStyleBackColor = true;
            BtnFile.Click += BtnFile_Click;
            // 
            // LblCount
            // 
            LblCount.AutoSize = true;
            LblCount.Location = new Point(615, 39);
            LblCount.Name = "LblCount";
            LblCount.Size = new Size(43, 15);
            LblCount.TabIndex = 5;
            LblCount.Text = "Count:";
            // 
            // LblCountText
            // 
            LblCountText.AutoSize = true;
            LblCountText.Location = new Point(664, 39);
            LblCountText.Name = "LblCountText";
            LblCountText.Size = new Size(13, 15);
            LblCountText.TabIndex = 6;
            LblCountText.Text = "0";
            // 
            // ChbDebug
            // 
            ChbDebug.AutoSize = true;
            ChbDebug.Location = new Point(17, 123);
            ChbDebug.Name = "ChbDebug";
            ChbDebug.Size = new Size(137, 19);
            ChbDebug.TabIndex = 9;
            ChbDebug.Text = "Show result in debug";
            ChbDebug.UseVisualStyleBackColor = true;
            ChbDebug.CheckedChanged += ChbDebug_CheckedChanged;
            // 
            // ChbSaveFile
            // 
            ChbSaveFile.AutoSize = true;
            ChbSaveFile.Location = new Point(17, 159);
            ChbSaveFile.Name = "ChbSaveFile";
            ChbSaveFile.Size = new Size(115, 19);
            ChbSaveFile.TabIndex = 10;
            ChbSaveFile.Text = "Save result to file";
            ChbSaveFile.UseVisualStyleBackColor = true;
            ChbSaveFile.CheckedChanged += ChbSaveFile_CheckedChanged;
            // 
            // LblSaveFile
            // 
            LblSaveFile.AutoSize = true;
            LblSaveFile.Location = new Point(15, 187);
            LblSaveFile.Name = "LblSaveFile";
            LblSaveFile.Size = new Size(34, 15);
            LblSaveFile.TabIndex = 11;
            LblSaveFile.Text = "Path:";
            // 
            // TbSaveFile
            // 
            TbSaveFile.Location = new Point(52, 184);
            TbSaveFile.Name = "TbSaveFile";
            TbSaveFile.Size = new Size(100, 23);
            TbSaveFile.TabIndex = 12;
            // 
            // IfLineFinderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 450);
            Controls.Add(TbSaveFile);
            Controls.Add(LblSaveFile);
            Controls.Add(ChbSaveFile);
            Controls.Add(ChbDebug);
            Controls.Add(LblCountText);
            Controls.Add(LblCount);
            Controls.Add(BtnFile);
            Controls.Add(LblFile);
            Controls.Add(TbFile);
            Controls.Add(LblDgv);
            Controls.Add(Dgv);
            Name = "IfLineFinderForm";
            Text = "IfLineFinder";
            ((System.ComponentModel.ISupportInitialize)Dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Dgv;
        private Label LblDgv;
        private TextBox TbFile;
        private Label LblFile;
        private Button BtnFile;
        private Label LblCount;
        private Label LblCountText;
        private CheckBox ChbDebug;
        private CheckBox ChbSaveFile;
        private Label LblSaveFile;
        private TextBox TbSaveFile;
    }
}