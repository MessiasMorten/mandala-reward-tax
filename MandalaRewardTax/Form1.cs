using RewardTaxLibraries;
using RewardTaxLibraries.Entities;
using System.Formats.Asn1;
using System.Globalization;
using System;
using CsvHelper;
using static System.Windows.Forms.DataFormats;
using RewardTaxLibraries.Entities.EntityMaps;
using System.Windows.Forms;
using System.Configuration;
using CsvHelper.Configuration;

namespace MandalaRewardTax
{
    public partial class Form1 : Form
    {
        private IList<Reward> rewardsList = new List<Reward>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rewardService = new RewardTaxService();

            if (ofd1.FileName == null)
                return;

            var rewards = readAllRewardsFromFile(ofd1.FileName);

            progressBar.Minimum = 0;
            progressBar.Maximum = rewards.Count;
            progressBar.Step = 1;

            foreach (var reward in rewards)
            {
                var mdxHistory = rewardService.GetHistoryData(reward.Currency, reward.RewardStartDate);
                reward.RewardValue = Math.Round(mdxHistory.History[0].Close * reward.RewardAmount, 4);
                rewardsList.Add(reward);
                progressBar.PerformStep();
                lb1.Items.Add(DateTime.Now + ": Calculated reward value for " + reward.RewardDate.ToShortDateString());
                w8();
            }
        }

        private IList<Reward> readAllRewardsFromFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                //The efficiency can be debated, but the use-case for this programme is not extensive
                csv.Context.RegisterClassMap<RewardMap>();
                return csv.GetRecords<Reward>().ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofd1.ShowDialog();
        }

        private void w8()
        {
            Application.DoEvents();
            Thread.Sleep(300);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            progressBar.Value = 0;
            ofd1.FileName = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sfd1.FileName = "MandalaRewardTax_" + DateTime.Now.ToShortDateString();
            sfd1.Filter = "CSV | *.csv";
            sfd1.ShowDialog();

            if (sfd1.FileName != "")
            {
                using (var stream = File.OpenWrite(sfd1.FileName))
                using (var writer = new StreamWriter(stream))
                {
                    var header = "Email,Date (UTC),Period Start Date  (UTC),Period End Date  (UTC),Reward,RewardValue,Currency,Annual Yield,Avg Staked Balance,Operation id";
                    writer.WriteLine(header);
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ",", HasHeaderRecord = false };
                    var csvWriter = new CsvWriter(writer, config);
                    csvWriter.WriteRecords(rewardsList);
                }
            }
        }
    }
}
