namespace Tracker
{
    partial class Jobs
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
            this.jobsGrid = new System.Windows.Forms.DataGridView();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jobsGrid)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobsGrid
            // 
            this.jobsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobsGrid.Location = new System.Drawing.Point(0, 0);
            this.jobsGrid.Name = "jobsGrid";
            this.jobsGrid.RowTemplate.Height = 25;
            this.jobsGrid.Size = new System.Drawing.Size(800, 450);
            this.jobsGrid.TabIndex = 0;
            this.jobsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobsGrid_CellEndEdit);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.controlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlPanel.Controls.Add(this.createButton);
            this.controlPanel.Controls.Add(this.deleteButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(585, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(215, 450);
            this.controlPanel.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteButton.Location = new System.Drawing.Point(0, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(215, 61);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete Job";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createButton.Location = new System.Drawing.Point(0, 61);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(215, 61);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create Job";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.jobsGrid);
            this.Name = "Jobs";
            this.Text = "Jobs";
            this.Load += new System.EventHandler(this.Jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobsGrid)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView jobsGrid;
        private Panel controlPanel;
        private Button deleteButton;
        private Button createButton;
    }
}