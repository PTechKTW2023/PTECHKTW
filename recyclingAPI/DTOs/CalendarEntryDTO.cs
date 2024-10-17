using System;

namespace recyclingAPI.DTOs
{
    public class CalendarEntryDTO
    {     
        public DateTime Date { get; set; }
        public int CompanyId { get; set; }
        public WasteTypeDTO WasteType { get; set; }

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