
namespace FlashCards
{
    partial class FormQuiz
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.labelWord = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonKnown = new System.Windows.Forms.Button();
            this.buttonUnknown = new System.Windows.Forms.Button();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.labelLang = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.SystemColors.Window;
            this.panelCard.Controls.Add(this.labelWord);
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Location = new System.Drawing.Point(86, 64);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(400, 100);
            this.panelCard.TabIndex = 0;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWord.Location = new System.Drawing.Point(164, 36);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(67, 30);
            this.labelWord.TabIndex = 2;
            this.labelWord.Text = "Word";
            this.labelWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelWord_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitle.Location = new System.Drawing.Point(86, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 30);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "labelTitle";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKnown
            // 
            this.buttonKnown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.buttonKnown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonKnown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKnown.Location = new System.Drawing.Point(386, 184);
            this.buttonKnown.Name = "buttonKnown";
            this.buttonKnown.Size = new System.Drawing.Size(100, 30);
            this.buttonKnown.TabIndex = 11;
            this.buttonKnown.Tag = "TextTranslatable";
            this.buttonKnown.Text = "Known!";
            this.buttonKnown.UseVisualStyleBackColor = true;
            this.buttonKnown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonKnown_MouseClick);
            // 
            // buttonUnknown
            // 
            this.buttonUnknown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.buttonUnknown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonUnknown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnknown.Location = new System.Drawing.Point(250, 184);
            this.buttonUnknown.Name = "buttonUnknown";
            this.buttonUnknown.Size = new System.Drawing.Size(100, 30);
            this.buttonUnknown.TabIndex = 12;
            this.buttonUnknown.Tag = "TextTranslatable";
            this.buttonUnknown.Text = "Unknown!";
            this.buttonUnknown.UseVisualStyleBackColor = true;
            this.buttonUnknown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonUnknown_MouseClick);
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Location = new System.Drawing.Point(86, 191);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(82, 23);
            this.comboBoxLang.TabIndex = 13;
            this.comboBoxLang.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang_SelectedIndexChanged);
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(86, 173);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(60, 15);
            this.labelLang.TabIndex = 14;
            this.labelLang.Tag = "TextTranslatable";
            this.labelLang.Text = "Card face:";
            // 
            // labelCounter
            // 
            this.labelCounter.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCounter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCounter.Location = new System.Drawing.Point(386, 18);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(100, 30);
            this.labelCounter.TabIndex = 15;
            this.labelCounter.Text = "00";
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(568, 401);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.labelLang);
            this.Controls.Add(this.comboBoxLang);
            this.Controls.Add(this.buttonUnknown);
            this.Controls.Add(this.buttonKnown);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelCard);
            this.Name = "FormQuiz";
            this.Text = "FormQuiz";
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonKnown;
        private System.Windows.Forms.Button buttonUnknown;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.Label labelCounter;
    }
}