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
        private readonly IClientManager _clientManager;
        public AddClient()
        {
            var serviceGenerator = new ServicesGenerator();

            _clientManager = serviceGenerator.CreateClientManager();
            InitializeComponent();
        }

        private async void AddClientFormButton_Click(object sender, EventArgs e)
        {
            var acctNbr = AcctNbrTextBox.Text;
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

            var client = new Library.Models.Client
            {
                AcctNbr = int.Parse(acctNbr),
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                State = state,
                Zip = zip,
                Phone = phone,
                DateOpen = DateTime.ParseExact(dateOpen, "dd.MM.yyyy", CultureInfo.InvariantCulture),
                SsNumber = int.Parse(ssNumber),
                BirthDate = DateTime.ParseExact(birthDate, "dd.MM.yyyy", CultureInfo.InvariantCulture),
                RiskLevel = riskLevel,
                Occupation = occupation,
                Objectives = objectives,
                Interests = interests
            };

            await _clientManager.AddAsync(client);
            MessageBox.Show("Client added successfully!");
            Close();
        }

        private void ExitAddClientFormButton_Click(object sender, EventArgs e) => Close();
    }
}
