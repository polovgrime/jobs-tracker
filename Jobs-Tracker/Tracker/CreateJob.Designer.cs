namespace Tracker
{
    partial class CreateJob
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
            this.inputPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endInput = new System.Windows.Forms.MaskedTextBox();
            this.startInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.inputPanel.Controls.Add(this.saveButton);
            this.inputPanel.Controls.Add(this.cancelButton);
            this.inputPanel.Controls.Add(this.panel1);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.descriptionInput);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Controls.Add(this.nameInput);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(524, 332);
            this.inputPanel.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveButton.Location = new System.Drawing.Point(374, 290);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 42);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(449, 290);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 42);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.endInput);
            this.panel1.Controls.Add(this.startInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 12, 50, 12);
            this.panel1.Size = new System.Drawing.Size(524, 60);
            this.panel1.TabIndex = 7;
            // 
            // endInput
            // 
            this.endInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.endInput.Location = new System.Drawing.Point(324, 12);
            this.endInput.Mask = "00:00";
            this.endInput.MaximumSize = new System.Drawing.Size(150, 50);
            this.endInput.MinimumSize = new System.Drawing.Size(0, 30);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(150, 30);
            this.endInput.TabIndex = 2;
            this.endInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endInput.ValidatingType = typeof(System.DateTime);
            // 
            // startInput
            // 
            this.startInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.startInput.Location = new System.Drawing.Point(50, 12);
            this.startInput.Mask = "00:00";
            this.startInput.MaximumSize = new System.Drawing.Size(150, 50);
            this.startInput.MinimumSize = new System.Drawing.Size(0, 30);
            this.startInput.Name = "startInput";
            this.startInput.Size = new System.Drawing.Size(150, 30);
            this.startInput.TabIndex = 1;
            this.startInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startInput.ValidatingType = typeof(System.DateTime);
            this.startInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.startInput_MaskInputRejected);
            this.startInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startInput_KeyDown);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Time - End Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionInput.Location = new System.Drawing.Point(0, 140);
            this.descriptionInput.MaximumSize = new System.Drawing.Size(0, 50);
            this.descriptionInput.MinimumSize = new System.Drawing.Size(0, 40);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(524, 40);
            this.descriptionInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInput
            // 
            this.nameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameInput.Location = new System.Drawing.Point(0, 50);
            this.nameInput.MaximumSize = new System.Drawing.Size(0, 50);
            this.nameInput.MinimumSize = new System.Drawing.Size(0, 40);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(524, 40);
            this.nameInput.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateJob
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(524, 332);
            this.Controls.Add(this.inputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateJob";
            this.Text = "CreateJob";
            this.Load += new System.EventHandler(this.CreateJob_Load);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel inputPanel;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox descriptionInput;
        private MaskedTextBox endInput;
        private MaskedTextBox startInput;
        private Button cancelButton;
        private Button saveButton;
        private TextBox nameInput;
    }
}