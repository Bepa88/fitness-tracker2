using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
