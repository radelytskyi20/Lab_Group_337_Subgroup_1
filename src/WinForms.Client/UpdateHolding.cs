using Library.Models;
using System.Data;
using WinForms.Client.Interfaces;
using WinForms.Client.Utils;

namespace WinForms.Client
{
    public partial class UpdateHolding : Form
    {
        private readonly IClientsManager _clientsManager;
        private readonly IHoldingsManager _holdingsManager;
        private readonly IMastersManager _mastersManager;

        public Holding Holding { get; set; }
        public UpdateHolding(Holding holding, IClientsManager clientsManager, IHoldingsManager holdingsManager, IMastersManager mastersManager)
        {
            Holding = holding;
            _clientsManager = clientsManager;
            _holdingsManager = holdingsManager;
            _mastersManager = mastersManager;
            InitializeComponent();
        }

        private async void UpdateHolding_Load(object sender, EventArgs e)
        {
            var clients = await _clientsManager.GetAllAsync();
            var masters = await _mastersManager.GetAllAsync();

            comboBoxAcctNbr.Items.AddRange(clients.Select(c => (object)c.AcctNbr).ToArray());
            comboBoxSymbol.Items.AddRange(masters.Select(m => (object)m.Symbol).ToArray());

            comboBoxAcctNbr.SelectedItem = Holding.AcctNbr;
            comboBoxSymbol.SelectedItem = Holding.Symbol;
            textBoxShares.Text = Holding.Shares.ToString();
            textBoxPurPrice.Text = Holding.PurPrice.ToString();
            dateTimePicker1.Value = Holding.PurDate;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(comboBoxAcctNbr?.SelectedItem?.ToString(), out int acctNbr))
            {
                MessageBox.Show("Invalid account number");
                return;
            }
            if (string.IsNullOrEmpty(comboBoxSymbol?.SelectedItem?.ToString()))
            {
                MessageBox.Show("Invalid symbol");
                return;
            }
            if (!int.TryParse(textBoxShares?.Text, out int shares))
            {
                MessageBox.Show("Invalid shares");
                return;
            }
            if (!decimal.TryParse(textBoxPurPrice?.Text, out decimal purPrice))
            {
                MessageBox.Show("Invalid purchase price");
                return;
            }

            var holdingToUpdate = new Holding
            {
                Id = Holding.Id,
                AcctNbr = acctNbr,
                Symbol = comboBoxSymbol.SelectedItem.ToString()!,
                Shares = shares,
                PurPrice = purPrice,
                PurDate = dateTimePicker1.Value
            };

            await _holdingsManager.UpdateAsync(holdingToUpdate);
            MessageBox.Show("Holding updated successfully!");
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void UpdateHolding_HelpRequested(object sender, HelpEventArgs hlpevent) => HelpUtils.ShowHelp(this, "content/holdings/update_holding.html");
    }
}
