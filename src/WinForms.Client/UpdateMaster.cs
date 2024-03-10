using Library.Constants;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Client.Services;

namespace WinForms.Client
{
    public partial class UpdateMaster : Form
    {
        private readonly IMastersManager _mastersManager;

        private Master Master { get; set; }
        public UpdateMaster(Master master)
        {
            var servicesGenerator = new ServicesGenerator();

            Master = master;
            _mastersManager = servicesGenerator.CreateMastersManager();
            InitializeComponent();
        }

        private void UpdateMaster_Load(object sender, EventArgs e)
        {
            comboBoxExchange.Items.AddRange(MasterData.Exchange);
            comboBoxSafety.Items.AddRange(MasterData.Safety.Select(s => s.ToString()).ToArray());
            comboBoxRating.Items.AddRange(MasterData.Rating);
            comboBoxBank.Items.AddRange(MasterData.Bank.Select(b => b.ToString()).ToArray());
            comboBoxOutlook.Items.AddRange(MasterData.Outlook.Select(o => o.ToString()).ToArray());
            comboBoxRcmndation.Items.AddRange(MasterData.Rcmndation);
            comboBoxRisk.Items.AddRange(MasterData.Risk);

            textBoxCoName.Text = Master.CoName;
            comboBoxExchange.SelectedItem = Master.Exchange?.Replace(" ", string.Empty)!;
            textBoxCurPrice.Text = Master.CurPrice.ToString();
            textBoxYrlHigh.Text = Master.YrlHigh.ToString();
            textBoxYrlLow.Text = Master.YrlLow.ToString();
            textBoxPeratio.Text = Master.PERatio.ToString();
            textBoxBeta.Text = Master.Beta.ToString();
            textBoxProjgrth.Text = Master.ProjGrth.ToString();
            textBoxIndustry.Text = Master.Industry.ToString();
            textBoxPricechg.Text = Master.PriceChg.ToString();
            comboBoxSafety.SelectedItem = Master.Safety.ToString();
            comboBoxRating.SelectedItem = Master.Rating;
            comboBoxBank.SelectedItem = Master.Bank.ToString();
            comboBoxOutlook.SelectedItem = Master.Outlook.ToString();
            comboBoxRcmndation.SelectedItem = Master.Rcmndation;
            comboBoxRisk.SelectedItem = Master.Risk;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCoName.Text))
            {
                MessageBox.Show("Invalid company name");
                return;
            }
            if (string.IsNullOrEmpty(comboBoxExchange.SelectedItem.ToString()))
            {
                MessageBox.Show("Invalid exchange");
                return;
            }
            if (!decimal.TryParse(textBoxCurPrice.Text, out decimal curPrice))
            {
                MessageBox.Show("Invalid current price");
                return;
            }
            if (!decimal.TryParse(textBoxYrlHigh.Text, out decimal yrlHigh))
            {
                MessageBox.Show("Invalid yearly high");
                return;
            }
            if (!decimal.TryParse(textBoxYrlLow.Text, out decimal yrlLow))
            {
                MessageBox.Show("Invalid yearly low");
                return;
            }
            if (!decimal.TryParse(textBoxPeratio.Text, out decimal peratio))
            {
                MessageBox.Show("Invalid PE ratio");
                return;
            }
            if (!decimal.TryParse(textBoxBeta.Text, out decimal beta))
            {
                MessageBox.Show("Invalid beta");
                return;
            }
            if (!int.TryParse(textBoxProjgrth.Text, out int projgrth))
            {
                MessageBox.Show("Invalid projected growth");
                return;
            }
            if (!int.TryParse(textBoxIndustry.Text, out int industry))
            {
                MessageBox.Show("Invalid industry");
                return;
            }
            if (!int.TryParse(textBoxPricechg.Text, out int priceChg))
            {
                MessageBox.Show("Invalid price change");
                return;
            }
            if (!int.TryParse(comboBoxSafety.SelectedItem.ToString(), out int safety))
            {
                MessageBox.Show("Invalid safety");
                return;
            }
            if (string.IsNullOrEmpty(comboBoxRating.SelectedItem.ToString()))
            {
                MessageBox.Show("Invalid rating");
                return;
            }
            if (!int.TryParse(comboBoxBank.SelectedItem.ToString(), out int bank))
            {
                MessageBox.Show("Invalid bank");
                return;
            }
            if (!int.TryParse(comboBoxOutlook.SelectedItem.ToString(), out int outlook))
            {
                MessageBox.Show("Invalid outlook");
                return;
            }
            if (string.IsNullOrEmpty(comboBoxRcmndation.SelectedItem.ToString()))
            {
                MessageBox.Show("Invalid recommendation");
                return;
            }
            if (string.IsNullOrEmpty(comboBoxRisk.SelectedItem.ToString()))
            {
                MessageBox.Show("Invalid risk");
                return;
            }

            var masterToUpdate = new Master
            {
                Symbol = Master.Symbol,
                CoName = textBoxCoName.Text,
                Exchange = comboBoxExchange.SelectedItem.ToString(),
                CurPrice = curPrice,
                YrlHigh = yrlHigh,
                YrlLow = yrlLow,
                PERatio = peratio,
                Beta = beta,
                ProjGrth = projgrth,
                Industry = industry,
                PriceChg = priceChg,
                Safety = safety,
                Rating = comboBoxRating.SelectedItem.ToString(),
                Bank = bank,
                Outlook = outlook,
                Rcmndation = comboBoxRcmndation.SelectedItem.ToString(),
                Risk = comboBoxRisk.SelectedItem.ToString()
            };

            _mastersManager.UpdateAsync(masterToUpdate);
            MessageBox.Show("Master updated successfully");
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
