
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
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Items.AddRange(new object[] {
            "English",
            "Русский"});
            this.comboBoxLang.Location = new System.Drawing.Point(107, 12);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(109, 23);
            this.comboBoxLang.TabIndex = 1;
            this.comboBoxLang.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 205);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRestartWarning
            // 
            this.labelRestartWarning.AutoSize = true;
            this.labelRestartWarning.ForeColor = System.Drawing.Color.Salmon;
            this.labelRestartWarning.Location = new System.Drawing.Point(232, 15);
            this.labelRestartWarning.Name = "labelRestartWarning";
            this.labelRestartWarning.Size = new System.Drawing.Size(232, 15);
            this.labelRestartWarning.TabIndex = 3;
            this.labelRestartWarning.Text = "Restart program for changes to take effect!";
            this.labelRestartWarning.Visible = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}