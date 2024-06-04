namespace recyclingAPI.Data
{
    public class MonthlyWasteReport
    {
        public int Id {  get; set; }
        public WasteType Waste  { get; set; }

        public decimal Cost()
        {
            // Method logic here
            return 0m;
        }

        public double Size { get; set; }
        public List<WasteCollectionReportRow> Positions { get; set; }
    }
}