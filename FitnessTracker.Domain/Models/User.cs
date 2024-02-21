using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UsersIdInBot { get; set; }
        public int VisitingId { get; set; }
        public Visiting Visiting { get; set; }
    }
}
