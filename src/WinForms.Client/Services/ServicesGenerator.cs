namespace WinForms.Client.Services
{
    public class ServicesGenerator
    {
        public IClientManager CreateClientManager() => new ClientManager();
    }
}
