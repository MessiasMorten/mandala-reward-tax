using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardTaxLibraries.Entities
{
    public class MDXHistory
    {
        public required string Currency { get; set; }
        public required List<History> History { get; set; }
    }
}
