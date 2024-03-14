
namespace RewardTaxLibraries.Entities
{
    public class History
    {
        public DateTime Timestamp { get; set; }
        public required decimal Open { get; set; }
        public required decimal Close { get; set; }
        public required decimal Min { get; set; }
        public required decimal Max { get; set; }
    }
}
