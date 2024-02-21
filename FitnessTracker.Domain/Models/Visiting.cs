using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.Models
{
    public class Visiting
    {
        public int Id { get; set; }
        public IList<User> Users { get; set; }
        public IList<Schedule> Schedules { get; set; }
        public bool IsCheckining { get; set; }


    }
}
