using Library.Data;
using Library.Models;
using Library.Services;
using System.Windows.Forms;
using WinForms.Client.Services;

namespace WinForms.Client
{
    public partial class Main : Form
    {
        private readonly IClientsManager _clientManager;
        private readonly IHoldingsManager _holdingsManager;
        public Main()
        {
            var serviceGenerator = new ServicesGenerator();

            _holdingsManager = serviceGenerator.CreateHoldingsManager();
            _clientManager = serviceGenerator.CreateClientManager();
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) => await UpdateForm();

        private async void AddClientButton_Click(object sender, EventArgs e)
        {
            var form = new AddClient();
            form.ShowDialog();
            await UpdateForm();
        }

        private async void btnClientsFirst_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveFirst();
            await UpdateAfterClientSelect(clientsGridView, clientsBindingSource);
        }

        private async void btnClientsPrevious_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MovePrevious();
            await UpdateAfterClientSelect(clientsGridView, clientsBindingSource);
        }

        private async void btnClientsNext_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveNext();
            await UpdateAfterClientSelect(clientsGridView, clientsBindingSource);
        }

        private async void btnClientsLast_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveLast();
            await UpdateAfterClientSelect(clientsGridView, clientsBindingSource);
        }
        private async void btnClientsUpdate_Click(object sender, EventArgs e)
        {
            if (clientsBindingSource.Current is Library.Models.Client client)
            {
                using var context = new ApplicationDbContext();
                IClientsManagerService clientsManagerService = new ClientsManagerService(context);
                var form = new UpdateClient(client);
                form.ShowDialog();
                await UpdateForm();
            }
        }
        private async Task UpdateAfterClientSelect(DataGridView dataGridView, BindingSource bindingSource)
        {
            UpdateDataGridView(dataGridView, bindingSource);
            await UpdateHoldingsGridView();
        }
        private async Task UpdateHoldingsGridView()
        {
            if (clientsBindingSource.Current is Library.Models.Client client)
            {
                var holdings = await _holdingsManager.GetAllAsync(client.AcctNbr);
                holdingsGridView.DataSource = holdings;
                holdingsGridView.Columns["Client"].Visible = false;
                holdingsGridView.Columns["Master"].Visible = false;
                holdingsBindingSource.DataSource = holdingsGridView.DataSource;
            }
        }
        private async Task UpdateForm()
        {
            var clients = await _clientManager.GetAllAsync();
            clientsGridView.DataSource = clients;
            clientsGridView.Columns["Holdings"].Visible = false;
            clientsBindingSource.DataSource = clientsGridView.DataSource;
        }
        private void UpdateDataGridView(DataGridView dataGridView, BindingSource bindingSource)
        {
            dataGridView.ClearSelection();
            dataGridView.Rows[bindingSource.Position].Selected = true;
        }

        private async void btnClinetsDelete_Click(object sender, EventArgs e)
        {
            if (clientsBindingSource.Current is Library.Models.Client client)
            {
                await _clientManager.DeletetAsync(client.AcctNbr);
                await UpdateForm();
            }
        }

        private async void btnAddHolding_Click(object sender, EventArgs e)
        {
            var form = new AddHolding();
            form.ShowDialog();
            await UpdateForm();
        }

        private void btnHoldingsFirst_Click(object sender, EventArgs e)
        {
            holdingsBindingSource.MoveFirst();
            UpdateDataGridView(holdingsGridView, holdingsBindingSource);
        }

        private void btnHoldingsPrevious_Click(object sender, EventArgs e)
        {
            holdingsBindingSource.MovePrevious();
            UpdateDataGridView(holdingsGridView, holdingsBindingSource);
        }

        private void btnHoldingsNext_Click(object sender, EventArgs e)
        {
            holdingsBindingSource.MoveNext();
            UpdateDataGridView(holdingsGridView, holdingsBindingSource);
        }

        private void btnHoldingsLast_Click(object sender, EventArgs e)
        {
            holdingsBindingSource.MoveLast();
            UpdateDataGridView(holdingsGridView, holdingsBindingSource);
        }
    }
}
