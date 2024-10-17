using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using recyclingAPI.Data;
using recyclingAPI.DTOs;



namespace recyclingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly DataContext _context;
        public CalendarController(DataContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<CalendarEntry>>> GetAllEntries()
        {
            var calendarEntries = await _context.CalendarEntries.ToListAsync();

            return Ok(calendarEntries);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarEntry>> GetCalendarEntry(int id)
        {
            var calendarEntry = await _context.CalendarEntries.FindAsync(id);
            if (calendarEntry is null)
                return NotFound("calendarEntry not found.");

            return Ok(calendarEntry);
        }
        [HttpPost]
        public async Task<ActionResult<List<CalendarEntry>>> AddCalendarEntry(CalendarEntryDTO entry)
        {
            Data.CalendarEntry dbCalendarEntry = ConvertToDatabaseObject(entry);
            _context.CalendarEntries.Add(dbCalendarEntry);
            await _context.SaveChangesAsync();

            return Ok(await _context.CalendarEntries.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<CalendarEntry>>> UpdateCalendarEntry(CalendarEntry update)
        {
            var calendarEntry = await _context.CalendarEntries.FindAsync(update.Id);
            if (calendarEntry is null)
                return NotFound("calendarEntry not found.");

            calendarEntry.CompanyId = update.CompanyId;
            calendarEntry.Date = update.Date;
            calendarEntry.WasteType = update.WasteType;

            await _context.SaveChangesAsync();

            return Ok(await _context.CalendarEntries.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<CalendarEntry>>> DeleteEntry(int id)
        {
            var calendarEntry = await _context.CalendarEntries.FindAsync(id);
            if (calendarEntry is null)
                return NotFound("calendarEntry not found.");
            
            _context.CalendarEntries.Remove(calendarEntry);
            await _context.SaveChangesAsync();

            return Ok(await _context.CalendarEntries.ToListAsync());
        }

        Data.CalendarEntry ConvertToDatabaseObject(DTOs.CalendarEntryDTO entry)
        {
            Data.CalendarEntry newEntry = new CalendarEntry();
            newEntry.CompanyId = entry.CompanyId;
            newEntry.Date = entry.Date;
            newEntry.WasteType = new WasteType();
            newEntry.WasteType.Name = entry.WasteType.Name;
            newEntry.WasteType.IsADR = entry.WasteType.IsADR;
            return newEntry;
        }
    }
}
