namespace Class_9_ch1
{
    partial class Form1
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
            this.ButtonAddFile = new System.Windows.Forms.Button();
            this.ButtonRemoveFile = new System.Windows.Forms.Button();
            this.ButtonAddDirBox2 = new System.Windows.Forms.Button();
            this.checkBox1ForDir1 = new System.Windows.Forms.CheckBox();
            this.checkBox2forDir2 = new System.Windows.Forms.CheckBox();
            this.listBoxForDir1 = new System.Windows.Forms.ListBox();
            this.listBoxForDir2 = new System.Windows.Forms.ListBox();
            this.textBoxForfileOperation = new System.Windows.Forms.TextBox();
            this.ButtonAddDirBox1 = new System.Windows.Forms.Button();
            this.ButtonSynchronize = new System.Windows.Forms.Button();
            this.labelDir1 = new System.Windows.Forms.Label();
            this.labelDir2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAddFile
            // 
            this.ButtonAddFile.Location = new System.Drawing.Point(430, 43);
            this.ButtonAddFile.Name = "ButtonAddFile";
            this.ButtonAddFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddFile.TabIndex = 0;
            this.ButtonAddFile.Text = "Add";
            this.ButtonAddFile.UseVisualStyleBackColor = true;
            this.ButtonAddFile.Click += new System.EventHandler(this.ButtonAddFile_Click);
            // 
            // ButtonRemoveFile
            // 
            this.ButtonRemoveFile.Location = new System.Drawing.Point(430, 72);
            this.ButtonRemoveFile.Name = "ButtonRemoveFile";
            this.ButtonRemoveFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemoveFile.TabIndex = 1;
            this.ButtonRemoveFile.Text = "Remove";
            this.ButtonRemoveFile.UseVisualStyleBackColor = true;
            this.ButtonRemoveFile.Click += new System.EventHandler(this.ButtonRemoveFile_Click);
            // 
            // ButtonAddDirBox2
            // 
            this.ButtonAddDirBox2.Location = new System.Drawing.Point(335, 160);
            this.ButtonAddDirBox2.Name = "ButtonAddDirBox2";
            this.ButtonAddDirBox2.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddDirBox2.TabIndex = 2;
            this.ButtonAddDirBox2.Text = "Add Dir";
            this.ButtonAddDirBox2.UseVisualStyleBackColor = true;
            this.ButtonAddDirBox2.Click += new System.EventHandler(this.ButtonAddDirBox2_Click);
            // 
            // checkBox1ForDir1
            // 
            this.checkBox1ForDir1.AutoSize = true;
            this.checkBox1ForDir1.Location = new System.Drawing.Point(41, 160);
            this.checkBox1ForDir1.Name = "checkBox1ForDir1";
            this.checkBox1ForDir1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1ForDir1.TabIndex = 3;
            this.checkBox1ForDir1.Text = "Base Dir";
            this.checkBox1ForDir1.UseVisualStyleBackColor = true;
            this.checkBox1ForDir1.CheckedChanged += new System.EventHandler(this.checkBox1ForDir1_CheckedChanged);
            // 
            // checkBox2forDir2
            // 
            this.checkBox2forDir2.AutoSize = true;
            this.checkBox2forDir2.Location = new System.Drawing.Point(240, 160);
            this.checkBox2forDir2.Name = "checkBox2forDir2";
            this.checkBox2forDir2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2forDir2.TabIndex = 4;
            this.checkBox2forDir2.Text = "Basa Dir";
            this.checkBox2forDir2.UseVisualStyleBackColor = true;
            this.checkBox2forDir2.CheckedChanged += new System.EventHandler(this.checkBox2forDir2_CheckedChanged);
            // 
            // listBoxForDir1
            // 
            this.listBoxForDir1.FormattingEnabled = true;
            this.listBoxForDir1.HorizontalScrollbar = true;
            this.listBoxForDir1.Location = new System.Drawing.Point(41, 33);
            this.listBoxForDir1.Name = "listBoxForDir1";
            this.listBoxForDir1.Size = new System.Drawing.Size(173, 121);
            this.listBoxForDir1.TabIndex = 5;
            this.listBoxForDir1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxForDir2
            // 
            this.listBoxForDir2.FormattingEnabled = true;
            this.listBoxForDir2.HorizontalScrollbar = true;
            this.listBoxForDir2.Location = new System.Drawing.Point(240, 33);
            this.listBoxForDir2.Name = "listBoxForDir2";
            this.listBoxForDir2.Size = new System.Drawing.Size(170, 121);
            this.listBoxForDir2.TabIndex = 6;
            this.listBoxForDir2.SelectedIndexChanged += new System.EventHandler(this.listBoxForDir2_SelectedIndexChanged);
            // 
            // textBoxForfileOperation
            // 
            this.textBoxForfileOperation.Location = new System.Drawing.Point(523, 43);
            this.textBoxForfileOperation.Name = "textBoxForfileOperation";
            this.textBoxForfileOperation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxForfileOperation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxForfileOperation.Size = new System.Drawing.Size(121, 20);
            this.textBoxForfileOperation.TabIndex = 7;
            // 
            // ButtonAddDirBox1
            // 
            this.ButtonAddDirBox1.Location = new System.Drawing.Point(139, 160);
            this.ButtonAddDirBox1.Name = "ButtonAddDirBox1";
            this.ButtonAddDirBox1.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddDirBox1.TabIndex = 8;
            this.ButtonAddDirBox1.Text = "Add Dir";
            this.ButtonAddDirBox1.UseVisualStyleBackColor = true;
            this.ButtonAddDirBox1.Click += new System.EventHandler(this.ButtonAddDirBox1_Click);
            // 
            // ButtonSynchronize
            // 
            this.ButtonSynchronize.Location = new System.Drawing.Point(430, 101);
            this.ButtonSynchronize.Name = "ButtonSynchronize";
            this.ButtonSynchronize.Size = new System.Drawing.Size(75, 23);
            this.ButtonSynchronize.TabIndex = 9;
            this.ButtonSynchronize.Text = "Synchronize";
            this.ButtonSynchronize.UseVisualStyleBackColor = true;
            this.ButtonSynchronize.Click += new System.EventHandler(this.ButtonSynchronize_Click);
            // 
            // labelDir1
            // 
            this.labelDir1.AutoSize = true;
            this.labelDir1.Location = new System.Drawing.Point(38, 17);
            this.labelDir1.Name = "labelDir1";
            this.labelDir1.Size = new System.Drawing.Size(26, 13);
            this.labelDir1.TabIndex = 10;
            this.labelDir1.Text = "Dir1";
            // 
            // labelDir2
            // 
            this.labelDir2.AutoSize = true;
            this.labelDir2.Location = new System.Drawing.Point(237, 17);
            this.labelDir2.Name = "labelDir2";
            this.labelDir2.Size = new System.Drawing.Size(26, 13);
            this.labelDir2.TabIndex = 11;
            this.labelDir2.Text = "Dir2";
            this.labelDir2.Click += new System.EventHandler(this.labelDir2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 198);
            this.Controls.Add(this.labelDir2);
            this.Controls.Add(this.labelDir1);
            this.Controls.Add(this.ButtonSynchronize);
            this.Controls.Add(this.ButtonAddDirBox1);
            this.Controls.Add(this.textBoxForfileOperation);
            this.Controls.Add(this.listBoxForDir2);
            this.Controls.Add(this.listBoxForDir1);
            this.Controls.Add(this.checkBox2forDir2);
            this.Controls.Add(this.checkBox1ForDir1);
            this.Controls.Add(this.ButtonAddDirBox2);
            this.Controls.Add(this.ButtonRemoveFile);
            this.Controls.Add(this.ButtonAddFile);
            this.Name = "Form1";
            this.Text = "Class9ch1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddFile;
        private System.Windows.Forms.Button ButtonRemoveFile;
        private System.Windows.Forms.Button ButtonAddDirBox2;
        private System.Windows.Forms.CheckBox checkBox1ForDir1;
        private System.Windows.Forms.CheckBox checkBox2forDir2;
        private System.Windows.Forms.ListBox listBoxForDir1;
        private System.Windows.Forms.ListBox listBoxForDir2;
        private System.Windows.Forms.TextBox textBoxForfileOperation;
        private System.Windows.Forms.Button ButtonAddDirBox1;
        private System.Windows.Forms.Button ButtonSynchronize;
        private System.Windows.Forms.Label labelDir1;
        private System.Windows.Forms.Label labelDir2;
    }
}

