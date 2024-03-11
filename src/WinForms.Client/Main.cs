using Library.Models;
using WinForms.Client.Interfaces;

namespace WinForms.Client
{
    public partial class Main : Form
    {
        private readonly IClientsManager _clientManager;
        private readonly IHoldingsManager _holdingsManager;
        private readonly IMastersManager _mastersManager;
        public Main(IClientsManager clientsManager, IHoldingsManager holdingsManager, IMastersManager mastersManager)
        {
            _clientManager = clientsManager;
            _holdingsManager = holdingsManager;
            _mastersManager = mastersManager;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) => await UpdateForm();

        private async void AddClientButton_Click(object sender, EventArgs e)
        {
            var form = new AddClient(_clientManager);
            form.ShowDialog();
            await UpdateForm();
        }

        private async void btnClientsFirst_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveFirst();
            holdingsBindingSource.Clear();
            mastersBindingSource.Clear();
            await UpdateAfterClientSelect(clientsGridView, clientsBindingSource);
        }

        private async void btnClientsPrevious_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MovePrevious();
            holdingsBindingSource.Clear();
            mastersBindingSource.Clear();
            await UpdateAfterClientSelect(clientsGridView, clientsBindingSource);
        }

        private async void btnClientsNext_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveNext();
            holdingsBindingSource.Clear();
            mastersBindingSource.Clear();
            await UpdateAfterClientSelect(clientsGridView, clientsBindingSource);
        }

        private async void btnClientsLast_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveLast();
            holdingsBindingSource.Clear();
            mastersBindingSource.Clear();
            await UpdateAfterClientSelect(clientsGridView, clientsBindingSource);
        }
        private async void btnClientsUpdate_Click(object sender, EventArgs e)
        {
            if (clientsBindingSource.Current is Library.Models.Client client)
            {
                var form = new UpdateClient(client, _clientManager);
                form.ShowDialog();
                await UpdateForm();
            }
        }
        private async Task UpdateAfterClientSelect(DataGridView dataGridView, BindingSource bindingSource)
        {
            UpdateDataGridView(dataGridView, bindingSource);
            await UpdateHoldingsGridView();
            await UpdateMastersGridView();
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

        private async Task UpdateMastersGridView()
        {
            if (clientsBindingSource.Current is Library.Models.Client client)
            {
                var holdings = await _holdingsManager.GetAllAsync(client.AcctNbr);
                var masters = await _mastersManager.GetAllAsync();
                masters = masters.Where(m => holdings.Any(h => h.Symbol == m.Symbol)).ToList();
                mastersGridView.DataSource = masters;
                mastersGridView.Columns["Holdings"].Visible = false;
                mastersBindingSource.DataSource = mastersGridView.DataSource;
            }
        }

        private async Task UpdateClientsGridView()
        {
            var clients = await _clientManager.GetAllAsync();
            clientsGridView.DataSource = clients;
            clientsGridView.Columns["Holdings"].Visible = false;
            clientsBindingSource.DataSource = clientsGridView.DataSource;
        }

        private async Task UpdateForm()
        {
            await UpdateClientsGridView();
            await UpdateHoldingsGridView();
            await UpdateMastersGridView();
        }
        private void UpdateDataGridView(DataGridView dataGridView, BindingSource bindingSource)
        {
            dataGridView.ClearSelection();

            if (bindingSource.Position != -1)
                dataGridView.Rows[bindingSource.Position].Selected = true;
        }
        private async void btnClinetsDelete_Click(object sender, EventArgs e)
        {
            if (clientsBindingSource.Current is Library.Models.Client client)
            {
                await _clientManager.DeleteAsync(client.AcctNbr);
                MessageBox.Show("Client deleted successfully!");
                await UpdateForm();
            }
        }

        private async void btnAddHolding_Click(object sender, EventArgs e)
        {
            var form = new AddHolding(_holdingsManager, _clientManager, _mastersManager);
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

        private async void btnUpdateHolding_Click(object sender, EventArgs e)
        {
            if (holdingsBindingSource.Current is Holding holding)
            {
                var form = new UpdateHolding(holding, _clientManager, _holdingsManager, _mastersManager);
                form.ShowDialog();
                await UpdateForm();
            }
        }

        private async void btnDeleteHolding_Click(object sender, EventArgs e)
        {
            if (holdingsBindingSource.Current is Holding holding)
            {
                await _holdingsManager.DeleteAsync(holding.Id);
                MessageBox.Show("Holding deleted successfully!");
                await UpdateForm();
            }
        }

        private async void btnAddMaster_Click(object sender, EventArgs e)
        {
            var form = new AddMaster(_mastersManager);
            form.ShowDialog();
            await UpdateForm();
        }

        private void btnMastersFirst_Click(object sender, EventArgs e)
        {
            mastersBindingSource.MoveFirst();
            UpdateDataGridView(mastersGridView, mastersBindingSource);
        }

        private void btnMastersPrevious_Click(object sender, EventArgs e)
        {
            mastersBindingSource.MovePrevious();
            UpdateDataGridView(mastersGridView, mastersBindingSource);
        }

        private void btnMastersNext_Click(object sender, EventArgs e)
        {
            mastersBindingSource.MoveNext();
            UpdateDataGridView(mastersGridView, mastersBindingSource);
        }

        private void btnMastersLast_Click(object sender, EventArgs e)
        {
            mastersBindingSource.MoveLast();
            UpdateDataGridView(mastersGridView, mastersBindingSource);
        }

        private async void btnUpdateMaster_Click(object sender, EventArgs e)
        {
            if (mastersBindingSource.Current is Master master)
            {
                var form = new UpdateMaster(master, _mastersManager);
                form.ShowDialog();
                await UpdateForm();
            }
        }

        private async void btnDeleteMaster_Click(object sender, EventArgs e)
        {
            if (mastersBindingSource.Current is Master master)
            {
                await _mastersManager.DeleteAsync(master.Symbol);
                MessageBox.Show("Master deleted successfully!");
                await UpdateForm();
            }
        }

        private async void btnAllMasters_Click(object sender, EventArgs e)
        {
            var masters = await _mastersManager.GetAllAsync();
            mastersGridView.DataSource = masters;
            mastersGridView.Columns["Holdings"].Visible = false;
            mastersBindingSource.DataSource = mastersGridView.DataSource;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) =>
            MessageBox.Show(
                "Yaroslav Radelytskyi\n" +
                "Veronika Glotova\n" +
                "Nastya Borzenko"
                );
    }
}
