
namespace RewardTaxLibraries.Entities
{
    public class MDXHistory
    {
        public required string Currency { get; set; }
        public required List<History> History { get; set; }
    }
}
