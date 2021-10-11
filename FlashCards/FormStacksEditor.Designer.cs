
namespace FlashCards
{
    partial class FormStacksEditor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxNative = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelNative = new System.Windows.Forms.Label();
            this.textBoxForeign = new System.Windows.Forms.TextBox();
            this.labelForeign = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonCards = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonImgRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(73, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(330, 15);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(161, 23);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(210, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 15);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Tag = "TextTranslatable";
            this.labelTitle.Text = "Title:";
            // 
            // textBoxNative
            // 
            this.textBoxNative.Location = new System.Drawing.Point(330, 44);
            this.textBoxNative.Name = "textBoxNative";
            this.textBoxNative.Size = new System.Drawing.Size(161, 23);
            this.textBoxNative.TabIndex = 3;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(73, 18);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(67, 15);
            this.labelImage.TabIndex = 4;
            this.labelImage.Tag = "TextTranslatable";
            this.labelImage.Text = "Select icon:";
            // 
            // labelNative
            // 
            this.labelNative.AutoSize = true;
            this.labelNative.Location = new System.Drawing.Point(210, 47);
            this.labelNative.Name = "labelNative";
            this.labelNative.Size = new System.Drawing.Size(96, 15);
            this.labelNative.TabIndex = 5;
            this.labelNative.Tag = "TextTranslatable";
            this.labelNative.Text = "Native language:";
            // 
            // textBoxForeign
            // 
            this.textBoxForeign.Location = new System.Drawing.Point(330, 73);
            this.textBoxForeign.Name = "textBoxForeign";
            this.textBoxForeign.Size = new System.Drawing.Size(161, 23);
            this.textBoxForeign.TabIndex = 6;
            // 
            // labelForeign
            // 
            this.labelForeign.AutoSize = true;
            this.labelForeign.Location = new System.Drawing.Point(210, 76);
            this.labelForeign.Name = "labelForeign";
            this.labelForeign.Size = new System.Drawing.Size(102, 15);
            this.labelForeign.TabIndex = 7;
            this.labelForeign.Tag = "TextTranslatable";
            this.labelForeign.Text = "Foreign language:";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(330, 102);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(161, 23);
            this.textBoxComment.TabIndex = 8;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(210, 105);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(64, 15);
            this.labelComment.TabIndex = 9;
            this.labelComment.Tag = "TextTranslatable";
            this.labelComment.Text = "Comment:";
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(73, 167);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Tag = "TextTranslatable";
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(210, 167);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Tag = "TextTranslatable";
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.jpg";
            this.openFileDialog1.Filter = "Image files|*.jpg;*.png;*.gif|All files|*.*";
            this.openFileDialog1.Title = "Open picture...";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // buttonCards
            // 
            this.buttonCards.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.buttonCards.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCards.Location = new System.Drawing.Point(391, 131);
            this.buttonCards.Name = "buttonCards";
            this.buttonCards.Size = new System.Drawing.Size(100, 30);
            this.buttonCards.TabIndex = 15;
            this.buttonCards.Tag = "TextTranslatable";
            this.buttonCards.Text = "Open cards";
            this.buttonCards.UseVisualStyleBackColor = true;
            this.buttonCards.Click += new System.EventHandler(this.buttonCards_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(391, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Tag = "TextTranslatable";
            this.buttonDelete.Text = "Delete stack";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonImgRemove
            // 
            this.buttonImgRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.buttonImgRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.buttonImgRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonImgRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImgRemove.Location = new System.Drawing.Point(73, 102);
            this.buttonImgRemove.Name = "buttonImgRemove";
            this.buttonImgRemove.Size = new System.Drawing.Size(64, 23);
            this.buttonImgRemove.TabIndex = 17;
            this.buttonImgRemove.Text = "Clear";
            this.buttonImgRemove.UseVisualStyleBackColor = false;
            // 
            // FormStacksEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(568, 218);
            this.Controls.Add(this.buttonImgRemove);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCards);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelForeign);
            this.Controls.Add(this.textBoxForeign);
            this.Controls.Add(this.labelNative);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.textBoxNative);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormStacksEditor";
            this.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.Text = "FormStacksEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxNative;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelNative;
        private System.Windows.Forms.TextBox textBoxForeign;
        private System.Windows.Forms.Label labelForeign;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonCards;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonImgRemove;
    }
}