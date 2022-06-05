using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Models;

namespace Tracker
{
    public abstract class JobsService
    {
        public abstract IEnumerable<FullTimeJob> Get();

        public abstract void Update(FullTimeJob job);

        public abstract void Delete(IEnumerable<int> ids);

        public abstract void Create(FullTimeJob job);

    }

    public class FakeJobService : JobsService
    {
        private const string JobNamePrefix = "Test Job #";
        private int _jobsCount;
        private List<FullTimeJob> _jobs;
        public FakeJobService(int jobsCount)
        {
            _jobsCount = jobsCount;
            var number = 1;
            var rnd = new Random();
            _jobs = Enumerable
                .Repeat<int>(0, _jobsCount)
                .Select(e => new FullTimeJob
                {
                    Name = JobNamePrefix + number,
                    Start = new TimeSpan(rnd.Next(8, 12), 0, 0),
                    End = new TimeSpan(rnd.Next(16, 18), 0, 0),
                    Description = "test",
                    ID = number++
                })
                .OrderBy(e => e.ID)
                .ToList();
        }

        public override IEnumerable<FullTimeJob> Get()
        {
            return _jobs.ToList();
        }

        public override void Create(FullTimeJob data) 
        { 
            var lastID = _jobs.OrderByDescending(e => e.ID).Select(e => e.ID).First();
            data.ID = lastID + 1;
            _jobs.Add(data);
        }

        public override void Update(FullTimeJob data) 
        { 
            var job = _jobs.First(e => e.ID == data.ID);
            _jobs.Remove(job);
            _jobs.Add(data);
        }

        public override void Delete(IEnumerable<int> ids) 
        {
            _jobs = _jobs
                .Except(_jobs.Where(e => ids.Contains(e.ID)))
                .ToList();
        }
    }
}
