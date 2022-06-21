using System;
using System.Collections.Generic;
using System.Text;

namespace LeviEpcUpcConverter.Models
{
    class Summary
    {
        public string PoNumber { get; set; }
        public string BookingNumber { get; set; }
        public string Shipper { get; set; }
        public string PlaceOfDelivery { get; set; }
        public int CartonToBeScanned { get; set; }
        public int ReadUnits { get; set; }

        public PoModel PoModel { get; set; }
        
    }
}
