using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models
{
    public class FullTimeJob
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; } 

        public TimeSpan Start { get; set;}

        public TimeSpan End { get; set;}
    }
}
