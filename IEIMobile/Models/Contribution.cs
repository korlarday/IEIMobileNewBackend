namespace IEIMobile.Models
{
    public class Contribution
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public decimal CompCurrentValue { get; set; }
        public decimal CompTotalContribution { get; set; }
        public decimal CompNetContribution { get; set; }
        public decimal CompGrowth { get; set; }
        public decimal CompUnitPrice { get; set; }
        public decimal CompTotalUnits { get; set; }

        public decimal VolCurrentValue { get; set; }
        public decimal VolTotalContribution { get; set; }
        public decimal VolNetContribution { get; set; }
        public decimal VolGrowth { get; set; }
        public decimal VolUnitPrice { get; set; }
        public decimal VolTotalUnits { get; set; }
    }
}