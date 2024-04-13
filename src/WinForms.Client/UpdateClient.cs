using Library.Constants;
using WinForms.Client.Interfaces;
using WinForms.Client.Utils;

namespace WinForms.Client
{
    public partial class UpdateClient : Form
    {
        private Library.Models.Client Client { get; set; }
        private readonly IClientsManager _clientManager;
        public UpdateClient(Library.Models.Client client, IClientsManager clientsManager)
        {
            _clientManager = clientsManager;
            Client = client;
            InitializeComponent();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            comboBoxRiskLevel.Items.AddRange(ClientData.RiskLevel);
            comboBoxState.Items.AddRange(ClientData.State);

            FirstNameTextBox.Text = Client.FirstName;
            LastNameTextBox.Text = Client.LastName;
            AddressTextBox.Text = Client.Address;
            CityTextBox.Text = Client.City;
            comboBoxState.SelectedItem = Client.State;
            ZipTextBox.Text = Client.Zip;
            PhoneTextBox.Text = Client.Phone;
            SsNumberTextBox.Text = Client.SsNumber.ToString();
            dateTimePickerBirthDate.Value = Client.BirthDate;
            comboBoxRiskLevel.SelectedItem = Client.RiskLevel;
            OccupationTextBox.Text = Client.Occupation;
            ObjectivesTextBox.Text = Client.Objectives;
            InterestsTextBox.Text = Client.Interests;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
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

            var clientToUpdate = new Library.Models.Client
            {
                AcctNbr = Client.AcctNbr,
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Address = AddressTextBox.Text,
                City = CityTextBox.Text,
                State = comboBoxState.SelectedItem.ToString(),
                Zip = ZipTextBox.Text,
                Phone = PhoneTextBox.Text,
                SsNumber = ssNumber,
                BirthDate = dateTimePickerBirthDate.Value,
                RiskLevel = comboBoxRiskLevel.SelectedItem.ToString(),
                Occupation = OccupationTextBox.Text,
                Objectives = ObjectivesTextBox.Text,
                Interests = InterestsTextBox.Text
            };

            await _clientManager.UpdateAsync(clientToUpdate);
            MessageBox.Show("Client updated successfully!");
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void UpdateClient_HelpRequested(object sender, HelpEventArgs hlpevent) => HelpUtils.ShowHelp(this, "content/clients/update_client.html");
    }
}
