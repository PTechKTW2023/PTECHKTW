using System;

namespace recyclingAPI.Data
{
    public class CalendarEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CompanyId { get; set; }
        public WasteType WasteType { get; set; }
    }
}