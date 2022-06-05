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
    public partial class Jobs : Form
    {
        private IEnumerable<FullTimeJob> _fullTimeJobs;
        private JobsService _jobsService;
        private int offset = 0;
        public Jobs()
        {
            InitializeComponent();
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            _jobsService = new FakeJobService(10);
            UpdateJobs();
            jobsGrid.Columns
                .Cast<DataGridViewColumn>()
                .Where(e => e.Name == "ID")
                .ToList()
                .ForEach(e => e.ReadOnly = true);
        }

        private void jobsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var item = (FullTimeJob)jobsGrid.Rows[e.RowIndex].DataBoundItem;
            _jobsService.Update(item);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedJobs = jobsGrid.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(row => (FullTimeJob)row.DataBoundItem)
                .ToList();

            if (selectedJobs.Count == 0)
            {
                MessageBox.Show("You need to select jobs to delete");
                return;
            }

            var dialog = MessageBox.Show($"Are you sure you want to delete {selectedJobs.Count} rows?", "Confirm deleting", MessageBoxButtons.YesNo);
            
            if (dialog == DialogResult.Yes)
            {
                _jobsService.Delete(selectedJobs.Select(e => e.ID));
                UpdateJobs();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var createJob = new CreateJob();
            var result = createJob.ShowDialog();
            _jobsService.Create(createJob.Result);
            UpdateJobs();
        }

        private void UpdateJobs()
        {
            _fullTimeJobs = _jobsService.Get();
            jobsGrid.DataSource = _fullTimeJobs;
        }
    }
}
