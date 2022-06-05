namespace Tracker
{
    partial class RecordAction
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endInput = new System.Windows.Forms.MaskedTextBox();
            this.startInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.inputPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.inputPanel.Controls.Add(this.saveButton);
            this.inputPanel.Controls.Add(this.cancelButton);
            this.inputPanel.Controls.Add(this.panel2);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.panel1);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.descriptionInput);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Controls.Add(this.nameInput);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(524, 464);
            this.inputPanel.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveButton.Location = new System.Drawing.Point(374, 400);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 64);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(449, 400);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 64);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50, 12, 50, 12);
            this.panel2.Size = new System.Drawing.Size(524, 60);
            this.panel2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 50);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type Of Action";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // RecordAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 464);
            this.Controls.Add(this.inputPanel);
            this.Name = "RecordAction";
            this.Text = "RecordAction";
            this.Load += new System.EventHandler(this.RecordAction_Load);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel inputPanel;
        private Button saveButton;
        private Button cancelButton;
        private Panel panel1;
        private MaskedTextBox endInput;
        private MaskedTextBox startInput;
        private Label label3;
        private TextBox descriptionInput;
        private Label label2;
        private TextBox nameInput;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label4;
    }
}