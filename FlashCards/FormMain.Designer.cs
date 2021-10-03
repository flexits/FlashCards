
namespace FlashCards
{
    partial class FormMain
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelNavi = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonStacks = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelNavi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 48);
            this.panelHeader.TabIndex = 2;
            // 
            // panelNavi
            // 
            this.panelNavi.Controls.Add(this.buttonSettings);
            this.panelNavi.Controls.Add(this.buttonStacks);
            this.panelNavi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavi.Location = new System.Drawing.Point(0, 48);
            this.panelNavi.Name = "panelNavi";
            this.panelNavi.Size = new System.Drawing.Size(200, 402);
            this.panelNavi.TabIndex = 4;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(0, 68);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(200, 68);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Tag = "TextTranslatable";
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonStacks
            // 
            this.buttonStacks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStacks.Location = new System.Drawing.Point(0, 0);
            this.buttonStacks.Name = "buttonStacks";
            this.buttonStacks.Size = new System.Drawing.Size(200, 68);
            this.buttonStacks.TabIndex = 0;
            this.buttonStacks.Tag = "TextTranslatable";
            this.buttonStacks.Text = "Stacks";
            this.buttonStacks.UseVisualStyleBackColor = true;
            this.buttonStacks.Click += new System.EventHandler(this.buttonStacks_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 48);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(600, 402);
            this.panelContainer.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelNavi);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "FlashCards";
            this.panelNavi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelNavi;
        private System.Windows.Forms.Button buttonStacks;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelContainer;
    }
}

