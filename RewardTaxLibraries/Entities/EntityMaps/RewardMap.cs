using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardTaxLibraries.Entities.EntityMaps
{
    public class RewardMap : ClassMap<Reward>
    {
        public RewardMap()
        {
            Map(m => m.Email).Name("Email");
            Map(m => m.RewardDate).Name("Date (UTC)");
            Map(m => m.RewardStartDate).Name("Period Start Date  (UTC)");
            Map(m => m.RewardEndDate).Name("Period End Date  (UTC)");
            Map(m => m.RewardAmount).Name("Reward");
            Map(m => m.Currency).Name("Currency");
            Map(m => m.AnnualYield).Name("Annual Yield");
            Map(m => m.AverageStakedBalance).Name("Avg Staked Balance");
            Map(m => m.OperationId).Name("Operation id");
        }
    }
}
