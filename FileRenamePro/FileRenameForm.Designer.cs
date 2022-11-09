
namespace FileRenamePro
{
    partial class FileRenameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileRenameForm));
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbInsertPre = new System.Windows.Forms.RadioButton();
            this.rbInsertEnd = new System.Windows.Forms.RadioButton();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.btnOnbellekTemizle = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.HorizontalScrollbar = true;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.ScrollAlwaysVisible = true;
            this.listBoxFiles.Size = new System.Drawing.Size(560, 95);
            this.listBoxFiles.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFileName.Location = new System.Drawing.Point(125, 185);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(447, 25);
            this.txtFileName.TabIndex = 3;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText.Location = new System.Drawing.Point(12, 188);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(107, 17);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Eklenecek İfade:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(416, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // rbInsertPre
            // 
            this.rbInsertPre.AutoSize = true;
            this.rbInsertPre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbInsertPre.Location = new System.Drawing.Point(125, 220);
            this.rbInsertPre.Name = "rbInsertPre";
            this.rbInsertPre.Size = new System.Drawing.Size(91, 21);
            this.rbInsertPre.TabIndex = 6;
            this.rbInsertPre.TabStop = true;
            this.rbInsertPre.Text = "Önüne Ekle";
            this.rbInsertPre.UseVisualStyleBackColor = true;
            // 
            // rbInsertEnd
            // 
            this.rbInsertEnd.AutoSize = true;
            this.rbInsertEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbInsertEnd.Location = new System.Drawing.Point(476, 220);
            this.rbInsertEnd.Name = "rbInsertEnd";
            this.rbInsertEnd.Size = new System.Drawing.Size(96, 21);
            this.rbInsertEnd.TabIndex = 6;
            this.rbInsertEnd.TabStop = true;
            this.rbInsertEnd.Text = "Sonuna Ekle";
            this.rbInsertEnd.UseVisualStyleBackColor = true;
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFileDialog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileDialog.ForeColor = System.Drawing.Color.White;
            this.btnFileDialog.Location = new System.Drawing.Point(497, 113);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(75, 48);
            this.btnFileDialog.TabIndex = 7;
            this.btnFileDialog.Text = "Gözat";
            this.btnFileDialog.UseVisualStyleBackColor = false;
            this.btnFileDialog.Click += new System.EventHandler(this.BtnFileDialog_Click);
            // 
            // btnOnbellekTemizle
            // 
            this.btnOnbellekTemizle.BackColor = System.Drawing.Color.Crimson;
            this.btnOnbellekTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnbellekTemizle.ForeColor = System.Drawing.Color.White;
            this.btnOnbellekTemizle.Location = new System.Drawing.Point(12, 111);
            this.btnOnbellekTemizle.Name = "btnOnbellekTemizle";
            this.btnOnbellekTemizle.Size = new System.Drawing.Size(75, 48);
            this.btnOnbellekTemizle.TabIndex = 8;
            this.btnOnbellekTemizle.Text = "Önbellek Temizle";
            this.btnOnbellekTemizle.UseVisualStyleBackColor = false;
            this.btnOnbellekTemizle.Click += new System.EventHandler(this.BtnOnbellekTemizle_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPosition.Location = new System.Drawing.Point(12, 224);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(78, 17);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "İfade Yönü:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(497, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 46);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Çıkış";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FileRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOnbellekTemizle);
            this.Controls.Add(this.btnFileDialog);
            this.Controls.Add(this.rbInsertEnd);
            this.Controls.Add(this.rbInsertPre);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.listBoxFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FileRenameForm";
            this.Text = "File Rename Pro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbInsertPre;
        private System.Windows.Forms.RadioButton rbInsertEnd;
        private System.Windows.Forms.Button btnFileDialog;
        private System.Windows.Forms.Button btnOnbellekTemizle;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

