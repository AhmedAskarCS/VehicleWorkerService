using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleWorkerService.Models
{
    public class VehicleLog
    {
        public int Id { get; set; }
        public string RadarUnit { get; set; }
        public DateTime TicketDate { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleOwnerAddress { get; set; } 
        public string VehicleOwner { get; set; }
        public string TicketDescription { get; set; }
        public string TicketWitness { get; set; }
        public int Speed { get; set; }
        public string TicketLocation { get; set; }
        public string ImageNumber { get; set; }
        public string RadarNumber { get; set; }
        public byte[] PlateImage { get; set; }
        public byte[] MainImage { get; set; }

    }
}
