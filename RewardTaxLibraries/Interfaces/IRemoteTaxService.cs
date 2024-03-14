using RewardTaxLibraries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardTaxLibraries.Interfaces
{
    public interface IRemoteTaxService
    {
        MDXHistory GetHistoryData(string ticker, DateTime date);
    }
}
