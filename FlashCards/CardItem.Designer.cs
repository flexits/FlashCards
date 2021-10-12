
namespace FlashCards
{
    partial class CardItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelNative = new System.Windows.Forms.Label();
            this.labelForeign = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.textBoxComment);
            this.panel1.Controls.Add(this.textBoxTranslation);
            this.panel1.Controls.Add(this.textBoxWord);
            this.panel1.Controls.Add(this.labelComment);
            this.panel1.Controls.Add(this.labelNative);
            this.panel1.Controls.Add(this.labelForeign);
            this.panel1.Controls.Add(this.labelImage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 106);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            // 
            // textBoxComment
            // 
            this.textBoxComment.AllowDrop = true;
            this.textBoxComment.Location = new System.Drawing.Point(225, 70);
            this.textBoxComment.MaxLength = 128;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(195, 23);
            this.textBoxComment.TabIndex = 11;
            this.textBoxComment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            this.textBoxComment.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.AllowDrop = true;
            this.textBoxTranslation.Location = new System.Drawing.Point(225, 41);
            this.textBoxTranslation.MaxLength = 128;
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.Size = new System.Drawing.Size(195, 23);
            this.textBoxTranslation.TabIndex = 10;
            this.textBoxTranslation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            this.textBoxTranslation.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxWord
            // 
            this.textBoxWord.AllowDrop = true;
            this.textBoxWord.Location = new System.Drawing.Point(225, 12);
            this.textBoxWord.MaxLength = 128;
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(195, 23);
            this.textBoxWord.TabIndex = 9;
            this.textBoxWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            this.textBoxWord.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(151, 73);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(64, 15);
            this.labelComment.TabIndex = 8;
            this.labelComment.Tag = "TextTranslatable";
            this.labelComment.Text = "Comment:";
            this.labelComment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            // 
            // labelNative
            // 
            this.labelNative.AutoSize = true;
            this.labelNative.Location = new System.Drawing.Point(151, 44);
            this.labelNative.Name = "labelNative";
            this.labelNative.Size = new System.Drawing.Size(67, 15);
            this.labelNative.TabIndex = 7;
            this.labelNative.Tag = "TextTranslatable";
            this.labelNative.Text = "Translation:";
            this.labelNative.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            // 
            // labelForeign
            // 
            this.labelForeign.AutoSize = true;
            this.labelForeign.Location = new System.Drawing.Point(151, 15);
            this.labelForeign.Name = "labelForeign";
            this.labelForeign.Size = new System.Drawing.Size(39, 15);
            this.labelForeign.TabIndex = 6;
            this.labelForeign.Tag = "TextTranslatable";
            this.labelForeign.Text = "Word:";
            this.labelForeign.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(20, 10);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(67, 15);
            this.labelImage.TabIndex = 5;
            this.labelImage.Tag = "TextTranslatable";
            this.labelImage.Text = "Select icon:";
            this.labelImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.jpg";
            this.openFileDialog1.Filter = "Image files|*.jpg;*.png;*.gif|All files|*.*";
            this.openFileDialog1.Title = "Open picture...";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // CardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CardItem";
            this.Size = new System.Drawing.Size(454, 116);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnItemSelection);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelNative;
        private System.Windows.Forms.Label labelForeign;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
