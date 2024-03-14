using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RewardTaxLibraries.Entities
{
    public class Reward
    {
        public string? Email {  get; set; }
        public DateTime RewardDate { get; set; }
        public DateTime RewardStartDate { get; set; }
        public DateTime RewardEndDate { get; set; }
        public decimal RewardAmount { get; set; }
        public decimal RewardValue { get; set; }
        public string? Currency { get; set; }
        public double AnnualYield { get; set; }
        public double AverageStakedBalance { get; set; }
        public string? OperationId { get; set; }
    }
}
