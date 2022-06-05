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
    public partial class Tracker : Form
    {
        private WorkProgressService _workProgressService = new FakeWorkProgressService();
        private List<FullWorkProcess> _procesess = new List<FullWorkProcess>();
        public Tracker()
        {
            InitializeComponent();
        }

        private void Tracker_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void recordActionButton_Click(object sender, EventArgs e)
        {
            var recordAction = new RecordAction();
            var result = recordAction.ShowDialog();
            _workProgressService.Create(recordAction.Result);
            UpdateProgress();
            //_jobsService.Create(createJob.Result);
            //UpdateJobs();
        }
        private void UpdateProgress()
        {
            _procesess = _workProgressService.Get(DateTime.Today).ToList();
            dataGridView1.DataSource = _procesess;
        }
    }
}
