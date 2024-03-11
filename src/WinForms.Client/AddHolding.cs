using System.Data;
using WinForms.Client.Interfaces;

namespace WinForms.Client
{
    public partial class AddHolding : Form
    {
        private readonly IHoldingsManager _holdingsManager;
        private readonly IClientsManager _clientsManager;
        private readonly IMastersManager _mastersManager;

        public AddHolding(IHoldingsManager holdingsManager, IClientsManager clientsManager, IMastersManager mastersManager)
        {
            _holdingsManager = holdingsManager;
            _clientsManager = clientsManager;
            _mastersManager = mastersManager;

            InitializeComponent();
        }

        private async void AddHolding_Load(object sender, EventArgs e)
        {
            var clients = await _clientsManager.GetAllAsync();
            if (clients.Any())
                comboBoxAcctNbr.Items.AddRange(clients.Select(c => (object)c.AcctNbr).ToArray());

            var masters = await _mastersManager.GetAllAsync();
            if (masters.Any())
                comboBoxSymbol.Items.AddRange(masters.Select(m => (object)m.Symbol).ToArray());
        }

        private async void btnAdd_Click(object sender, EventArgs e)
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
            var holding = new Library.Models.Holding
            {
                Id = Guid.NewGuid(),
                AcctNbr = acctNbr,
                Symbol = comboBoxSymbol.SelectedItem.ToString()!,
                Shares = shares,
                PurPrice = purPrice,
                PurDate = dateTimePicker1.Value
            };

            await _holdingsManager.AddAsync(holding);
            MessageBox.Show("Holding added successfully!");
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
