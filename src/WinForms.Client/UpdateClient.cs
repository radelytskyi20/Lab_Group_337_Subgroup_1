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
    public partial class UpdateClient : Form
    {
        private Library.Models.Client Client { get; set; }
        private readonly IClientManager _clientManager;
        public UpdateClient(Library.Models.Client client)
        {
            _clientManager = new ClientManager();
            Client = client;
            InitializeComponent();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = Client.FirstName;
            LastNameTextBox.Text = Client.LastName;
            AddressTextBox.Text = Client.Address;
            CityTextBox.Text = Client.City;
            StateTextBox.Text = Client.State;
            ZipTextBox.Text = Client.Zip;
            PhoneTextBox.Text = Client.Phone;
            DateOpenTextBox.Text = Client.DateOpen.ToString();
            SsNumberTextBox.Text = Client.SsNumber.ToString();
            BirthDateTextBox.Text = Client.BirthDate.ToString();
            RiskLevelTextBox.Text = Client.RiskLevel;
            OccupationTextBox.Text = Client.Occupation;
            ObjectivesTextBox.Text = Client.Objectives;
            InterestsTextBox.Text = Client.Interests;
        }
        private void ExitAddClientFormButton_Click(object sender, EventArgs e) => Close();

        private void UpdateClientFormButton_Click(object sender, EventArgs e)
        {
            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameTextBox.Text;
            var address = AddressTextBox.Text;
            var city = CityTextBox.Text;
            var state = StateTextBox.Text;
            var zip = ZipTextBox.Text;
            var phone = PhoneTextBox.Text;
            var dateOpen = DateOpenTextBox.Text;
            var ssNumber = SsNumberTextBox.Text;
            var birthDate = BirthDateTextBox.Text;
            var riskLevel = RiskLevelTextBox.Text;
            var occupation = OccupationTextBox.Text;
            var objectives = ObjectivesTextBox.Text;
            var interests = InterestsTextBox.Text;
            
            var clientToUpdate = new Library.Models.Client
            {
                AcctNbr = Client.AcctNbr,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                State = state,
                Zip = zip,
                Phone = phone,
                DateOpen = DateTime.ParseExact(dateOpen, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                SsNumber = int.Parse(ssNumber),
                BirthDate = DateTime.ParseExact(birthDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                RiskLevel = riskLevel,
                Occupation = occupation,
                Objectives = objectives,
                Interests = interests
            };

            
            MessageBox.Show("Client updated successfully!");
            Close();
        }
    }
}
