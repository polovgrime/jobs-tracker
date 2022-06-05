namespace Tracker
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.aboutMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.aboutMenuButton = new System.Windows.Forms.Button();
            this.trackerMenu = new System.Windows.Forms.Panel();
            this.jobsButton = new System.Windows.Forms.Button();
            this.workProcessButton = new System.Windows.Forms.Button();
            this.trackerMenuButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.childDisplay = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.sideMenuPanel.SuspendLayout();
            this.aboutMenu.SuspendLayout();
            this.trackerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.AutoScroll = true;
            this.sideMenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sideMenuPanel.Controls.Add(this.aboutMenu);
            this.sideMenuPanel.Controls.Add(this.aboutMenuButton);
            this.sideMenuPanel.Controls.Add(this.trackerMenu);
            this.sideMenuPanel.Controls.Add(this.trackerMenuButton);
            this.sideMenuPanel.Controls.Add(this.panelLogo);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(250, 475);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // aboutMenu
            // 
            this.aboutMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.aboutMenu.Controls.Add(this.button4);
            this.aboutMenu.Controls.Add(this.button5);
            this.aboutMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutMenu.Location = new System.Drawing.Point(0, 288);
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(250, 98);
            this.aboutMenu.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(0, 40);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // aboutMenuButton
            // 
            this.aboutMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutMenuButton.FlatAppearance.BorderSize = 0;
            this.aboutMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.aboutMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.aboutMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutMenuButton.Location = new System.Drawing.Point(0, 243);
            this.aboutMenuButton.Name = "aboutMenuButton";
            this.aboutMenuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.aboutMenuButton.Size = new System.Drawing.Size(250, 45);
            this.aboutMenuButton.TabIndex = 2;
            this.aboutMenuButton.Text = "About";
            this.aboutMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutMenuButton.UseVisualStyleBackColor = true;
            this.aboutMenuButton.Click += new System.EventHandler(this.aboutMenuButton_Click);
            // 
            // trackerMenu
            // 
            this.trackerMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.trackerMenu.Controls.Add(this.jobsButton);
            this.trackerMenu.Controls.Add(this.workProcessButton);
            this.trackerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackerMenu.Location = new System.Drawing.Point(0, 145);
            this.trackerMenu.Name = "trackerMenu";
            this.trackerMenu.Size = new System.Drawing.Size(250, 98);
            this.trackerMenu.TabIndex = 1;
            // 
            // jobsButton
            // 
            this.jobsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobsButton.FlatAppearance.BorderSize = 0;
            this.jobsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.jobsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.jobsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.jobsButton.Location = new System.Drawing.Point(0, 40);
            this.jobsButton.Name = "jobsButton";
            this.jobsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.jobsButton.Size = new System.Drawing.Size(250, 40);
            this.jobsButton.TabIndex = 1;
            this.jobsButton.Text = "Jobs";
            this.jobsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jobsButton.UseVisualStyleBackColor = true;
            this.jobsButton.Click += new System.EventHandler(this.jobsButton_Click);
            // 
            // workProcessButton
            // 
            this.workProcessButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.workProcessButton.FlatAppearance.BorderSize = 0;
            this.workProcessButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.workProcessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.workProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workProcessButton.ForeColor = System.Drawing.SystemColors.Control;
            this.workProcessButton.Location = new System.Drawing.Point(0, 0);
            this.workProcessButton.Name = "workProcessButton";
            this.workProcessButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.workProcessButton.Size = new System.Drawing.Size(250, 40);
            this.workProcessButton.TabIndex = 0;
            this.workProcessButton.Text = "Work Process";
            this.workProcessButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.workProcessButton.UseVisualStyleBackColor = true;
            this.workProcessButton.Click += new System.EventHandler(this.workProcessButton_Click);
            // 
            // trackerMenuButton
            // 
            this.trackerMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackerMenuButton.FlatAppearance.BorderSize = 0;
            this.trackerMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.trackerMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.trackerMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trackerMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.trackerMenuButton.Location = new System.Drawing.Point(0, 100);
            this.trackerMenuButton.Name = "trackerMenuButton";
            this.trackerMenuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.trackerMenuButton.Size = new System.Drawing.Size(250, 45);
            this.trackerMenuButton.TabIndex = 0;
            this.trackerMenuButton.Text = "Tracker";
            this.trackerMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trackerMenuButton.UseVisualStyleBackColor = true;
            this.trackerMenuButton.Click += new System.EventHandler(this.trackerMenuButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // childDisplay
            // 
            this.childDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childDisplay.Location = new System.Drawing.Point(250, 0);
            this.childDisplay.Name = "childDisplay";
            this.childDisplay.Size = new System.Drawing.Size(1135, 475);
            this.childDisplay.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 475);
            this.Controls.Add(this.childDisplay);
            this.Controls.Add(this.sideMenuPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Main";
            this.Text = "Tracker";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.sideMenuPanel.ResumeLayout(false);
            this.aboutMenu.ResumeLayout(false);
            this.trackerMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bindingSource1;
        private Panel sideMenuPanel;
        private Panel trackerMenu;
        private Button jobsButton;
        private Button workProcessButton;
        private Button trackerMenuButton;
        private Panel panelLogo;
        private Panel aboutMenu;
        private Button button4;
        private Button button5;
        private Button aboutMenuButton;
        private Panel childDisplay;
    }
}