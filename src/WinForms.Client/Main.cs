using Library.Data;
using Library.Models;
using Library.Services;

namespace WinForms.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) => await UpdateForm();

        private async void AddClientButton_Click(object sender, EventArgs e)
        {
            var form = new AddClient();
            form.ShowDialog();
            await UpdateForm();
        }

        private void btnClientsFirst_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveFirst();
            UpdateDataGridView(clientsGridView, clientsBindingSource);
        }

        private void btnClientsPrevious_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MovePrevious();
            UpdateDataGridView(clientsGridView, clientsBindingSource);
        }

        private void btnClientsNext_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveNext();
            UpdateDataGridView(clientsGridView, clientsBindingSource);
        }

        private void btnClientsLast_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveLast();
            UpdateDataGridView(clientsGridView, clientsBindingSource);
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
        private async Task UpdateForm()
        {
            using var context = new ApplicationDbContext();
            IClientsManagerService clientsManagerService = new ClientsManagerService(context);
            var clients = await clientsManagerService.GetAllAsync();
            clientsGridView.DataSource = clients;
            clientsGridView.Columns["Holdings"].Visible = false;
            clientsBindingSource.DataSource = clientsGridView.DataSource;
        }
        private void UpdateDataGridView(DataGridView dataGridView, BindingSource bindingSource)
        {
            dataGridView.ClearSelection();
            dataGridView.Rows[bindingSource.Position].Selected = true;
        }
    }
}
