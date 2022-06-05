using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models
{
    public class FullWorkProcess
    {
        public int ID { get; set;}

        public FullTimeJob Job { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public DateTime Day { get; set; }

        public ProcessType ProcessType { get; set; }

        public string Comment { get; set;}
    }
}
