using recyclingAPI.DTOs;
using System;

namespace recyclingAPI.Data
{
    public class CalendarEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CompanyId { get; set; }
        public WasteType WasteType { get; set; }

        public CalendarEntry(CalendarEntryDTO entry)
        {
            CompanyId = entry.CompanyId;
            Date = entry.Date;
            WasteType = new WasteType();
            WasteType.Name = entry.WasteType.Name;
            WasteType.IsADR = entry.WasteType.IsADR;
        }

        public CalendarEntry()
        {
          
        }


        /**
         
          {
          "id": 3,
          "date": "2024-10-17T18:40:36.451Z",
          "companyId": 0,
          "wasteType": {
            "id": 0,
            "name": "string",
            "unit": "string",
            "isADR": true
          }
        }
         
         */
    }
}