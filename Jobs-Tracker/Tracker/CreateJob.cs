using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracker.Models;

namespace Tracker
{
    public partial class CreateJob : Form
    {
        public FullTimeJob Result { get; private set;}
        public CreateJob()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var start = new TimeSpan(now.Hour, now.Minute, now.Second);
            var end = new TimeSpan(now.Hour, now.Minute, now.Second);
            if (TimeSpan.TryParseExact(startInput.Text, @"hh\:mm", null, out start) == false)
            {
                MessageBox.Show("Please, use correct hh:mm in Start input!");
                return;
            }
            
            if (TimeSpan.TryParseExact(endInput.Text, @"hh\:mm", null, out end) == false)
            {
                MessageBox.Show("Please, use correct hh:mm in End input!");
                return;
            }

            Result = new FullTimeJob 
            { 
                Name = nameInput.Text,
                Description = descriptionInput.Text,
                Start = start,
                End = end
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            startInput.Clear();
            endInput.Clear();
            nameInput.Clear();
            descriptionInput.Clear();
        }

        private void CreateJob_Load(object sender, EventArgs e)
        {
            startInput.BeepOnError = true;  
        }

        private void startInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            startInput.Undo();
        }

        private void startInput_KeyDown(object sender, KeyEventArgs e)
        {
            var test = startInput.ValidateText();
        }
    }

    
}
