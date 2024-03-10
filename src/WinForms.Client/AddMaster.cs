using Library.Constants;
using Library.Models;
using System.Data;
using WinForms.Client.Interfaces;

namespace WinForms.Client
{
    public partial class AddMaster : Form
    {
        private readonly IMastersManager _mastersManager;

        public AddMaster(IMastersManager mastersManager)
        {
            _mastersManager = mastersManager;
            InitializeComponent();
        }

        private void AddMaster_Load(object sender, EventArgs e)
        {
            comboBoxExchange.Items.AddRange(MasterData.Exchange);
            comboBoxSafety.Items.AddRange(MasterData.Safety.Select(s => s.ToString()).ToArray());
            comboBoxRating.Items.AddRange(MasterData.Rating);
            comboBoxBank.Items.AddRange(MasterData.Bank.Select(b => b.ToString()).ToArray());
            comboBoxOutlook.Items.AddRange(MasterData.Outlook.Select(o => o.ToString()).ToArray());
            comboBoxRcmndation.Items.AddRange(MasterData.Rcmndation);
            comboBoxRisk.Items.AddRange(MasterData.Risk);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var masters = await _mastersManager.GetAllAsync();

            if (string.IsNullOrEmpty(textBoxSymbol?.Text))
            {
                MessageBox.Show("Invalid symbol");
                return;
            }
            if (masters.Any(c => c?.Symbol == textBoxSymbol.Text.ToUpper()))
            {
                MessageBox.Show("Symbol already exists");
                return;
            }
            if (string.IsNullOrEmpty(textBoxCoName?.Text))
            {
                MessageBox.Show("Invalid company name");
                return;
            }

            if (string.IsNullOrEmpty(comboBoxExchange?.SelectedItem?.ToString()))
            {
                MessageBox.Show("Invalid exchange");
                return;
            }

            if (!decimal.TryParse(textBoxCurPrice?.Text, out decimal curPrice))
            {
                MessageBox.Show("Invalid current price");
                return;
            }

            if (!decimal.TryParse(textBoxYrlHigh?.Text, out decimal yrlHigh))
            {
                MessageBox.Show("Invalid yearly high");
                return;
            }
            if (!decimal.TryParse(textBoxYrlLow?.Text, out decimal yrlLow))
            {
                MessageBox.Show("Invalid yearly low");
                return;
            }

            if (!decimal.TryParse(textBoxPeratio?.Text, out decimal peratio))
            {
                MessageBox.Show("Invalid PE ratio");
                return;
            }

            if (!decimal.TryParse(textBoxBeta?.Text, out decimal beta))
            {
                MessageBox.Show("Invalid beta");
                return;
            }

            if (!int.TryParse(textBoxProjgrth?.Text, out int projgrth))
            {
                MessageBox.Show("Invalid projected growth");
                return;
            }

            if (!int.TryParse(textBoxIndustry?.Text, out int industry))
            {
                MessageBox.Show("Invalid industry");
                return;
            }

            if (!int.TryParse(textBoxPricechg?.Text, out int pricechg))
            {
                MessageBox.Show("Invalid price change");
                return;
            }

            if (!int.TryParse(comboBoxSafety?.SelectedItem?.ToString(), out int safety))
            {
                MessageBox.Show("Invalid safety");
                return;
            }

            if (string.IsNullOrEmpty(comboBoxRating?.SelectedItem?.ToString()))
            {
                MessageBox.Show("Invalid rating");
                return;
            }

            if (!int.TryParse(comboBoxBank?.SelectedItem?.ToString(), out int bank))
            {
                MessageBox.Show("Invalid bank");
                return;
            }

            if (!int.TryParse(comboBoxOutlook?.SelectedItem?.ToString(), out int outlook))
            {
                MessageBox.Show("Invalid outlook");
                return;
            }    

            if (string.IsNullOrEmpty(comboBoxRcmndation?.SelectedItem?.ToString()))
            {
                MessageBox.Show("Invalid recommendation");
                return;
            }

            if (string.IsNullOrEmpty(comboBoxRisk?.SelectedItem?.ToString()))
            {
                MessageBox.Show("Invalid risk");
                return;
            }

            var master = new Master
            {
                Symbol = textBoxSymbol.Text.ToUpper(),
                CoName = textBoxCoName.Text.ToUpper(),
                Exchange = comboBoxExchange.SelectedItem.ToString(),
                CurPrice = curPrice,
                YrlHigh = yrlHigh,
                YrlLow = yrlLow,
                PERatio = peratio,
                Beta = beta,
                ProjGrth = projgrth,
                Industry = industry,
                PriceChg = pricechg,
                Safety = safety,
                Rating = comboBoxRating.SelectedItem.ToString(),
                Bank = bank,
                Outlook = outlook,
                Rcmndation = comboBoxRcmndation.SelectedItem.ToString(),
                Risk = comboBoxRisk.SelectedItem.ToString()
            };

            await _mastersManager.AddAsync(master);
            MessageBox.Show("Master added successfully!");
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
