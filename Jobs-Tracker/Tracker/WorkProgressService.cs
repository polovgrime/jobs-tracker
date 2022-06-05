using Tracker.Models;
using System.Linq;

namespace Tracker
{
    public abstract class WorkProgressService
    {
        public abstract IEnumerable<FullWorkProcess> Get(DateTime date);

        public abstract void Update(FullWorkProcess data);

        public abstract void Delete(IEnumerable<int> ids);

        public abstract void Create(FullWorkProcess data);
    }

    public class FakeWorkProgressService : WorkProgressService
    {
        private List<FullWorkProcess> progress = new List<FullWorkProcess>();

        public override IEnumerable<FullWorkProcess> Get(DateTime date)
        {
            date = date.Date;
            return progress.Where(e => e.Day == date).ToList();
        }

        public override void Create(FullWorkProcess data)
        {
            progress.Add(data);
        }

        public override void Update(FullWorkProcess data)
        { 
            progress.Remove(progress.First(e => e.Start == data.Start));
            progress.Add(data);
        }

        public override void Delete(IEnumerable<int> ids)
        {
            progress = progress.Where(e => ids.Contains(e.ID) == false).ToList();
        }
    }
}
