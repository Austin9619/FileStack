namespace FileStack
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.folderButton = new System.Windows.Forms.Button();
            this.selectedPath = new System.Windows.Forms.TextBox();
            this.selectedPathText = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.txtFilesButton = new System.Windows.Forms.RadioButton();
            this.imageFiles = new System.Windows.Forms.RadioButton();
            this.audioFilesButton = new System.Windows.Forms.RadioButton();
            this.compressedFilesButton = new System.Windows.Forms.RadioButton();
            this.codingFilesButton = new System.Windows.Forms.RadioButton();
            this.otherFilesButton = new System.Windows.Forms.RadioButton();
            this.sortFilesButton = new System.Windows.Forms.Button();
            this.videoFilesButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // folderButton
            // 
            this.folderButton.AccessibleName = "dialogButton";
            this.folderButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.folderButton.BackColor = System.Drawing.Color.Green;
            this.folderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.folderButton.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderButton.ForeColor = System.Drawing.Color.White;
            this.folderButton.Location = new System.Drawing.Point(425, 33);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(72, 33);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "...";
            this.folderButton.UseVisualStyleBackColor = false;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // selectedPath
            // 
            this.selectedPath.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPath.Location = new System.Drawing.Point(95, 33);
            this.selectedPath.Name = "selectedPath";
            this.selectedPath.Size = new System.Drawing.Size(324, 33);
            this.selectedPath.TabIndex = 1;
            // 
            // selectedPathText
            // 
            this.selectedPathText.AutoSize = true;
            this.selectedPathText.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPathText.ForeColor = System.Drawing.Color.White;
            this.selectedPathText.Location = new System.Drawing.Point(12, 33);
            this.selectedPathText.Name = "selectedPathText";
            this.selectedPathText.Size = new System.Drawing.Size(77, 25);
            this.selectedPathText.TabIndex = 2;
            this.selectedPathText.Text = "Path:";
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel.ForeColor = System.Drawing.Color.White;
            this.sortLabel.Location = new System.Drawing.Point(515, 36);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(116, 25);
            this.sortLabel.TabIndex = 3;
            this.sortLabel.Text = "Sort By:";
            // 
            // filesListBox
            // 
            this.filesListBox.BackColor = System.Drawing.Color.Green;
            this.filesListBox.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesListBox.ForeColor = System.Drawing.Color.White;
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 25;
            this.filesListBox.Location = new System.Drawing.Point(12, 72);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(480, 354);
            this.filesListBox.TabIndex = 4;
            // 
            // txtFilesButton
            // 
            this.txtFilesButton.AutoSize = true;
            this.txtFilesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.txtFilesButton.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilesButton.ForeColor = System.Drawing.Color.White;
            this.txtFilesButton.Location = new System.Drawing.Point(520, 72);
            this.txtFilesButton.Name = "txtFilesButton";
            this.txtFilesButton.Size = new System.Drawing.Size(160, 29);
            this.txtFilesButton.TabIndex = 5;
            this.txtFilesButton.TabStop = true;
            this.txtFilesButton.Text = "Text Files";
            this.txtFilesButton.UseVisualStyleBackColor = true;
            // 
            // imageFiles
            // 
            this.imageFiles.AutoSize = true;
            this.imageFiles.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageFiles.ForeColor = System.Drawing.Color.White;
            this.imageFiles.Location = new System.Drawing.Point(520, 107);
            this.imageFiles.Name = "imageFiles";
            this.imageFiles.Size = new System.Drawing.Size(173, 29);
            this.imageFiles.TabIndex = 6;
            this.imageFiles.TabStop = true;
            this.imageFiles.Text = "Image Files";
            this.imageFiles.UseVisualStyleBackColor = true;
            // 
            // audioFilesButton
            // 
            this.audioFilesButton.AutoSize = true;
            this.audioFilesButton.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioFilesButton.ForeColor = System.Drawing.Color.White;
            this.audioFilesButton.Location = new System.Drawing.Point(520, 177);
            this.audioFilesButton.Name = "audioFilesButton";
            this.audioFilesButton.Size = new System.Drawing.Size(173, 29);
            this.audioFilesButton.TabIndex = 7;
            this.audioFilesButton.TabStop = true;
            this.audioFilesButton.Text = "Audio Files";
            this.audioFilesButton.UseVisualStyleBackColor = true;
            // 
            // compressedFilesButton
            // 
            this.compressedFilesButton.AutoSize = true;
            this.compressedFilesButton.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressedFilesButton.ForeColor = System.Drawing.Color.White;
            this.compressedFilesButton.Location = new System.Drawing.Point(520, 212);
            this.compressedFilesButton.Name = "compressedFilesButton";
            this.compressedFilesButton.Size = new System.Drawing.Size(238, 29);
            this.compressedFilesButton.TabIndex = 8;
            this.compressedFilesButton.TabStop = true;
            this.compressedFilesButton.Text = "Compressed Files";
            this.compressedFilesButton.UseVisualStyleBackColor = true;
            // 
            // codingFilesButton
            // 
            this.codingFilesButton.AutoSize = true;
            this.codingFilesButton.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codingFilesButton.ForeColor = System.Drawing.Color.White;
            this.codingFilesButton.Location = new System.Drawing.Point(520, 247);
            this.codingFilesButton.Name = "codingFilesButton";
            this.codingFilesButton.Size = new System.Drawing.Size(160, 29);
            this.codingFilesButton.TabIndex = 9;
            this.codingFilesButton.TabStop = true;
            this.codingFilesButton.Text = "Code Files";
            this.codingFilesButton.UseVisualStyleBackColor = true;
            // 
            // otherFilesButton
            // 
            this.otherFilesButton.AutoSize = true;
            this.otherFilesButton.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherFilesButton.ForeColor = System.Drawing.Color.White;
            this.otherFilesButton.Location = new System.Drawing.Point(520, 282);
            this.otherFilesButton.Name = "otherFilesButton";
            this.otherFilesButton.Size = new System.Drawing.Size(173, 29);
            this.otherFilesButton.TabIndex = 10;
            this.otherFilesButton.TabStop = true;
            this.otherFilesButton.Text = "Other Files";
            this.otherFilesButton.UseVisualStyleBackColor = true;
            // 
            // sortFilesButton
            // 
            this.sortFilesButton.BackColor = System.Drawing.Color.Green;
            this.sortFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortFilesButton.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortFilesButton.ForeColor = System.Drawing.Color.White;
            this.sortFilesButton.Location = new System.Drawing.Point(550, 330);
            this.sortFilesButton.Name = "sortFilesButton";
            this.sortFilesButton.Size = new System.Drawing.Size(172, 50);
            this.sortFilesButton.TabIndex = 11;
            this.sortFilesButton.Text = "Sort Files";
            this.sortFilesButton.UseVisualStyleBackColor = false;
            this.sortFilesButton.Click += new System.EventHandler(this.sortFilesButton_Click);
            // 
            // videoFilesButton
            // 
            this.videoFilesButton.AutoSize = true;
            this.videoFilesButton.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoFilesButton.ForeColor = System.Drawing.Color.White;
            this.videoFilesButton.Location = new System.Drawing.Point(520, 142);
            this.videoFilesButton.Name = "videoFilesButton";
            this.videoFilesButton.Size = new System.Drawing.Size(173, 29);
            this.videoFilesButton.TabIndex = 12;
            this.videoFilesButton.TabStop = true;
            this.videoFilesButton.Text = "Video Files";
            this.videoFilesButton.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoFilesButton);
            this.Controls.Add(this.sortFilesButton);
            this.Controls.Add(this.otherFilesButton);
            this.Controls.Add(this.codingFilesButton);
            this.Controls.Add(this.compressedFilesButton);
            this.Controls.Add(this.audioFilesButton);
            this.Controls.Add(this.imageFiles);
            this.Controls.Add(this.txtFilesButton);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.selectedPathText);
            this.Controls.Add(this.selectedPath);
            this.Controls.Add(this.folderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "FileStack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TextBox selectedPath;
        private System.Windows.Forms.Label selectedPathText;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.RadioButton txtFilesButton;
        private System.Windows.Forms.RadioButton imageFiles;
        private System.Windows.Forms.RadioButton audioFilesButton;
        private System.Windows.Forms.RadioButton compressedFilesButton;
        private System.Windows.Forms.RadioButton codingFilesButton;
        private System.Windows.Forms.RadioButton otherFilesButton;
        private System.Windows.Forms.Button sortFilesButton;
        private System.Windows.Forms.RadioButton videoFilesButton;
    }
}

