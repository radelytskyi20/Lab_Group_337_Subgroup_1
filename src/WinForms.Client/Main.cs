using Library.Data;
using Library.Services;

namespace WinForms.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using var context = new ApplicationDbContext();
            IClientsManagerService clientsManagerService = new ClientsManagerService(context);
            var clients = await clientsManagerService.GetAllAsync();
            clientsGridView.DataSource = clients;
            clientsGridView.Columns["Holdings"].Visible = false;
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            var form = new AddClient();
            form.ShowDialog();
            Form1_Load(sender, e);
        }
    }
}
