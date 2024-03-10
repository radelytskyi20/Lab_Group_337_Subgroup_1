using Library.Constants;
using Library.Models;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Client.Services;

namespace WinForms.Client
{
    public partial class AddClient : Form
    {
        private readonly IClientsManager _clientManager;
        public AddClient(IClientsManager clientsManager)
        {
            _clientManager = clientsManager;
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            comboBoxState.Items.AddRange(ClientData.State);
            comboBoxRiskLevel.Items.AddRange(ClientData.RiskLevel);
        }

        private async void AddClientFormButton_Click(object sender, EventArgs e)
        {
            var clients = await _clientManager.GetAllAsync();

            if (!int.TryParse(AcctNbrTextBox?.Text, out int acctNbr))
            {
                MessageBox.Show("Invalid account number");
                return;
            }
            if (clients.Any(c => c?.AcctNbr == acctNbr))
            {
                MessageBox.Show("Account number already exists");
                return;
            }
            if (string.IsNullOrEmpty(FirstNameTextBox?.Text))
            {
                MessageBox.Show("Invalid first name");
                return;
            }
            if (string.IsNullOrEmpty(LastNameTextBox?.Text))
            {
                MessageBox.Show("Invalid last name");
                return;
            }
            if (string.IsNullOrEmpty(AddressTextBox?.Text))
            {
                MessageBox.Show("Invalid address");
                return;
            }
            if (string.IsNullOrEmpty(CityTextBox?.Text))
            {
                MessageBox.Show("Invalid city");
                return;
            }
            if (string.IsNullOrEmpty(comboBoxState?.SelectedItem?.ToString()))
            {
                MessageBox.Show("Invalid state");
                return;
            }
            if (string.IsNullOrEmpty(ZipTextBox?.Text))
            {
                MessageBox.Show("Invalid zip");
                return;
            }
            if (string.IsNullOrEmpty(PhoneTextBox?.Text))
            {
                MessageBox.Show("Invalid phone");
                return;
            }
            if (!int.TryParse(SsNumberTextBox?.Text, out int ssNumber))
            {
                MessageBox.Show("Invalid social security number");
                return;
            }
            if (string.IsNullOrEmpty(comboBoxRiskLevel?.SelectedItem?.ToString()))
            {
                MessageBox.Show("Invalid risk level");
                return;
            }
            if (string.IsNullOrEmpty(OccupationTextBox?.Text))
            {
                MessageBox.Show("Invalid occupation");
                return;
            }
            if (string.IsNullOrEmpty(ObjectivesTextBox?.Text))
            {
                MessageBox.Show("Invalid objectives");
                return;
            }
            if (string.IsNullOrEmpty(InterestsTextBox?.Text))
            {
                MessageBox.Show("Invalid interests");
                return;
            }

            var client = new Library.Models.Client
            {
                AcctNbr = acctNbr,
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Address = AddressTextBox.Text,
                City = CityTextBox.Text,
                State = comboBoxState.SelectedItem.ToString(),
                Zip = ZipTextBox.Text,
                Phone = PhoneTextBox.Text,
                DateOpen = DateTime.Now,
                SsNumber = ssNumber,
                BirthDate = dateTimePickerBirthDate.Value,
                RiskLevel = comboBoxRiskLevel.SelectedItem.ToString(),
                Occupation = OccupationTextBox.Text,
                Objectives = ObjectivesTextBox.Text,
                Interests = InterestsTextBox.Text
            };

            await _clientManager.AddAsync(client);
            MessageBox.Show("Client added successfully!");
            Close();
        }

        private void ExitAddClientFormButton_Click(object sender, EventArgs e) => Close();
    }
}
