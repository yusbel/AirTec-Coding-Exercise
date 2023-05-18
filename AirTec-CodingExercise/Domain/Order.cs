using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTec_CodingExercise.Domain
{
    internal class Order
    {
        public string Id { get; set; } = string.Empty;

        public string AirPortDestinationCode { get; set; } = string.Empty;
        public string AirPortDepartureName { get; set; } = string.Empty;
    }
}
