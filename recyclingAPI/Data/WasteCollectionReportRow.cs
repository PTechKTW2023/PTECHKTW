
using System;


namespace recyclingAPI.Data
{
    public class WasteCollectionReportRow
    {
        public int Id { get; set; }
        // when exactly it was collected
        public DateTime Date { get; set; }

        // who did that
        public int CompanyId { get; set; }

        // the volumen of wastes
        public double Size { get; set; }

        // the Waste Type
        public WasteType Waste { get; set; }

        // Cost of this particular action
        public decimal Cost { get; set; }

        
    }
}