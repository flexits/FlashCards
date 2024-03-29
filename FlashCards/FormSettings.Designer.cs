﻿
namespace FlashCards
{
    partial class FormSettings
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
            this.labelLang = new System.Windows.Forms.Label();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelRestartWarning = new System.Windows.Forms.Label();
            this.labelCardFace = new System.Windows.Forms.Label();
            this.comboBoxCardFace = new System.Windows.Forms.ComboBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.comboBoxCommentSide = new System.Windows.Forms.ComboBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(12, 15);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(59, 15);
            this.labelLang.TabIndex = 0;
            this.labelLang.Text = "Language";
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Items.AddRange(new object[] {
            "English",
            "Русский"});
            this.comboBoxLang.Location = new System.Drawing.Point(261, 12);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(109, 23);
            this.comboBoxLang.TabIndex = 1;
            this.comboBoxLang.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(12, 205);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Tag = "TextTranslatable";
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRestartWarning
            // 
            this.labelRestartWarning.AutoSize = true;
            this.labelRestartWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.labelRestartWarning.Location = new System.Drawing.Point(386, 15);
            this.labelRestartWarning.Name = "labelRestartWarning";
            this.labelRestartWarning.Size = new System.Drawing.Size(232, 15);
            this.labelRestartWarning.TabIndex = 3;
            this.labelRestartWarning.Text = "Restart program for changes to take effect!";
            this.labelRestartWarning.Visible = false;
            // 
            // labelCardFace
            // 
            this.labelCardFace.AutoSize = true;
            this.labelCardFace.Location = new System.Drawing.Point(12, 44);
            this.labelCardFace.Name = "labelCardFace";
            this.labelCardFace.Size = new System.Drawing.Size(112, 15);
            this.labelCardFace.TabIndex = 4;
            this.labelCardFace.Tag = "TextTranslatable";
            this.labelCardFace.Text = "Card face language:";
            // 
            // comboBoxCardFace
            // 
            this.comboBoxCardFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.comboBoxCardFace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCardFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCardFace.FormattingEnabled = true;
            this.comboBoxCardFace.Location = new System.Drawing.Point(261, 41);
            this.comboBoxCardFace.Name = "comboBoxCardFace";
            this.comboBoxCardFace.Size = new System.Drawing.Size(109, 23);
            this.comboBoxCardFace.TabIndex = 5;
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(328, 205);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(133, 30);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = " © Alexander Korostelin\r\n4d.41.49.4c@gmail.com";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(203, 205);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(64, 30);
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "FlashCards\r\nv.1b01";
            // 
            // comboBoxCommentSide
            // 
            this.comboBoxCommentSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.comboBoxCommentSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCommentSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCommentSide.FormattingEnabled = true;
            this.comboBoxCommentSide.Location = new System.Drawing.Point(261, 70);
            this.comboBoxCommentSide.Name = "comboBoxCommentSide";
            this.comboBoxCommentSide.Size = new System.Drawing.Size(109, 23);
            this.comboBoxCommentSide.TabIndex = 8;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(12, 73);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(136, 15);
            this.labelComment.TabIndex = 9;
            this.labelComment.Tag = "TextTranslatable";
            this.labelComment.Text = "Card comment refers to:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.comboBoxCommentSide);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.comboBoxCardFace);
            this.Controls.Add(this.labelCardFace);
            this.Controls.Add(this.labelRestartWarning);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxLang);
            this.Controls.Add(this.labelLang);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelRestartWarning;
        private System.Windows.Forms.Label labelCardFace;
        private System.Windows.Forms.ComboBox comboBoxCardFace;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.ComboBox comboBoxCommentSide;
        private System.Windows.Forms.Label labelComment;
    }
}