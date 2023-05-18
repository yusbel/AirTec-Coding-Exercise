using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTec_CodingExercise.Domain
{
    internal class Schedule
    {
        public int Id { get; set; }
        public DateTime Departure { get; set; } = DateTime.Now;
        public DateTime Arrival { get; set;} = DateTime.Now;
    }
}
