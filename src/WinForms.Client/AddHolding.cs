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
    public partial class AddHolding : Form
    {
        IHoldingsManager _holdingsManager;
        IClientsManager _clientsManager;
        IMastersManager _mastersManager;

        public AddHolding()
        {
            var serviceGenerator = new ServicesGenerator();
            _holdingsManager = serviceGenerator.CreateHoldingsManager();
            _clientsManager = serviceGenerator.CreateClientsManager();
            _mastersManager = serviceGenerator.CreateMastersManager();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var acctNbr = int.Parse(comboBoxAcctNbr.Text);
            var symbol = comboBoxSymbol.Text;
            var shares = int.Parse(textBoxShares.Text);
            var purPrice = decimal.Parse(textBoxPurPrice.Text);
            var purDate = dateTimePicker1.Value;

            var holding = new Library.Models.Holding
            {
                AcctNbr = acctNbr,
                Symbol = symbol,
                Shares = shares,
                PurPrice = purPrice,
                PurDate = purDate
            };

            _holdingsManager.AddAsync(holding);
            MessageBox.Show("Holding added successfully!");
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
