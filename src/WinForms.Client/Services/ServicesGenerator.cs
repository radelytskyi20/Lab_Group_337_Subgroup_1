namespace WinForms.Client.Services
{
    public class ServicesGenerator
    {
        public IClientsManager CreateClientManager() => new ClientsManager();
        public IHoldingsManager CreateHoldingsManager() => new HoldingsManager();
    }
}
