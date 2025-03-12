namespace CostDashboard.Models
{
    public class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
    
    public class Filters
    {
        public string Region { get; set; } = "all";
        public string ServiceType { get; set; } = "all";
        public string Account { get; set; } = "all";
    }
    
    public class CostData
    {
        public string Service { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Region { get; set; } = string.Empty;
        public string Account { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
    
    public class CostBreakdownItem
    {
        public string Service { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string Account { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public decimal Change { get; set; }
        public string Status => Change > 0 ? "Increase" : "Decrease";
    }
}