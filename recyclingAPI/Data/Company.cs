using System.ComponentModel.DataAnnotations;

namespace recyclingAPI.Data
{
    /*
     A class, that is representing the Company entity
     it is describing what types of wastes are handled by it
     there is also overall Cost of service and monthly limit
    */

    public class Company
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public List<WasteType> WasteType { get; set; }

         /*
            We heard there is a cost for particular type of waste            
        */
        public decimal Cost()
        {
            // Method logic here
            return 0;
        }

        /*
            We heard there is a limit for particular type of waste            
        */
        public double Limit()
        {
            // Method logic here
            return 0;
        }
    }
}