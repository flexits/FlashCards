
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelNavi = new System.Windows.Forms.Panel();
            this.menuItemSettings = new FlashCards.ControlMenuItem();
            this.menuItemQiuz = new FlashCards.ControlMenuItem();
            this.menuItemStacks = new FlashCards.ControlMenuItem();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelNavi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.panelHeader.Controls.Add(this.buttonMaximize);
            this.panelHeader.Controls.Add(this.buttonMinimize);
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 48);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Location = new System.Drawing.Point(697, 6);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(36, 36);
            this.buttonMaximize.TabIndex = 3;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Visible = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::FlashCards.Properties.Resources.minimize_light;
            this.buttonMinimize.Location = new System.Drawing.Point(655, 6);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(36, 36);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.MouseEnter += new System.EventHandler(this.buttonMinimize_MouseEnter);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.buttonMinimize_MouseLeave);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::FlashCards.Properties.Resources.close_light;
            this.buttonClose.Location = new System.Drawing.Point(739, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(36, 36);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.labelTitle.Location = new System.Drawing.Point(12, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(164, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "FlashCards";
            // 
            // panelNavi
            // 
            this.panelNavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.panelNavi.Controls.Add(this.menuItemSettings);
            this.panelNavi.Controls.Add(this.menuItemQiuz);
            this.panelNavi.Controls.Add(this.menuItemStacks);
            this.panelNavi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavi.Location = new System.Drawing.Point(0, 48);
            this.panelNavi.Name = "panelNavi";
            this.panelNavi.Size = new System.Drawing.Size(200, 413);
            this.panelNavi.TabIndex = 4;
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.BackColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.menuItemSettings.BackColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.menuItemSettings.BackColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.menuItemSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuItemSettings.ImageDefault = global::FlashCards.Properties.Resources.settings_green;
            this.menuItemSettings.ImageHover = global::FlashCards.Properties.Resources.settings_light;
            this.menuItemSettings.ImageSelected = global::FlashCards.Properties.Resources.settings_light;
            this.menuItemSettings.Location = new System.Drawing.Point(0, 128);
            this.menuItemSettings.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuItemSettings.Size = new System.Drawing.Size(200, 64);
            this.menuItemSettings.TabIndex = 5;
            this.menuItemSettings.Tag = "TextTranslatable";
            this.menuItemSettings.Text = "Settings";
            this.menuItemSettings.ItemClickPerformed += new System.EventHandler(this.menuItemSettings_ItemClickPerformed);
            this.menuItemSettings.SelectionChanged += new System.EventHandler(this.MenuItemSelectChanged);
            // 
            // menuItemQiuz
            // 
            this.menuItemQiuz.BackColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.menuItemQiuz.BackColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.menuItemQiuz.BackColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.menuItemQiuz.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuItemQiuz.Enabled = false;
            this.menuItemQiuz.ImageDefault = global::FlashCards.Properties.Resources.quiz_green;
            this.menuItemQiuz.ImageHover = global::FlashCards.Properties.Resources.quiz_light;
            this.menuItemQiuz.ImageSelected = global::FlashCards.Properties.Resources.quiz_light;
            this.menuItemQiuz.Location = new System.Drawing.Point(0, 64);
            this.menuItemQiuz.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.menuItemQiuz.Name = "menuItemQiuz";
            this.menuItemQiuz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuItemQiuz.Size = new System.Drawing.Size(200, 64);
            this.menuItemQiuz.TabIndex = 4;
            this.menuItemQiuz.Tag = "TextTranslatable";
            this.menuItemQiuz.Text = "Learn!";
            this.menuItemQiuz.ItemClickPerformed += new System.EventHandler(this.menuItemQiuz_ItemClickPerformed);
            this.menuItemQiuz.SelectionChanged += new System.EventHandler(this.MenuItemSelectChanged);
            // 
            // menuItemStacks
            // 
            this.menuItemStacks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.menuItemStacks.BackColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.menuItemStacks.BackColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.menuItemStacks.BackColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.menuItemStacks.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuItemStacks.ImageDefault = global::FlashCards.Properties.Resources.stack_green;
            this.menuItemStacks.ImageHover = global::FlashCards.Properties.Resources.stack_light;
            this.menuItemStacks.ImageSelected = global::FlashCards.Properties.Resources.stack_light;
            this.menuItemStacks.Location = new System.Drawing.Point(0, 0);
            this.menuItemStacks.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.menuItemStacks.Name = "menuItemStacks";
            this.menuItemStacks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuItemStacks.Size = new System.Drawing.Size(200, 64);
            this.menuItemStacks.TabIndex = 3;
            this.menuItemStacks.Tag = "TextTranslatable";
            this.menuItemStacks.Text = "Stacks";
            this.menuItemStacks.ItemClickPerformed += new System.EventHandler(this.menuItemStacks_ItemClickPerformed);
            this.menuItemStacks.SelectionChanged += new System.EventHandler(this.MenuItemSelectChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(200, 451);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(584, 10);
            this.panelBottom.TabIndex = 6;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 48);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(584, 403);
            this.panelContainer.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelNavi);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "FlashCards";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelNavi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelNavi;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelContainer;
        private ControlMenuItem menuItemStacks;
        private ControlMenuItem menuItemQiuz;
        private ControlMenuItem menuItemSettings;
    }
}

