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
    public partial class RecordAction : Form
    {
        public RecordAction()
        {
            InitializeComponent();
            processTypes = ((ProcessType[])Enum.GetValues(typeof(ProcessType)))
               .ToDictionary(e => Enum.GetName(typeof(ProcessType), e) ?? "");
        }
        public FullWorkProcess Result { get; private set; }

        private Dictionary<string, ProcessType> processTypes = new Dictionary<string, ProcessType>();


        private void RecordAction_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(processTypes.Select(e => e.Key).ToArray());
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            startInput.Clear();
            endInput.Clear();
            nameInput.Clear();
            descriptionInput.Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

            if (end < start)
            {
                MessageBox.Show("End can't be earlier than start!");
                return;
            }

            Result = new FullWorkProcess
            {
                Start = DateTime.Today.Add(start),
                End = DateTime.Today.Add(end),
                Day = DateTime.Today,
                ProcessType = processTypes[(string)comboBox1.SelectedItem]
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
