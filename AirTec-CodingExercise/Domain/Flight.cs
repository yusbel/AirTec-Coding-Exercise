using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTec_CodingExercise.Domain
{
    internal class Flight
    {
        public string Id { get; set; } = string.Empty;
        public string Day { get; set; } = string.Empty;
        public AirPort AirPortFrom { get; set; } = new AirPort();
        public AirPort AirPortTo { get; set; } = new AirPort();
        public Schedule Schedule { get; set; } = new Schedule();
        public int FlightNum { get; set; }
        public int AmountOfOrder { get; set; }

    }
}
