namespace WinForms.Client.Services
{
    public class ServicesGenerator
    {
        public IClientsManager CreateClientsManager() => new ClientsManager();
        public IHoldingsManager CreateHoldingsManager() => new HoldingsManager();
        public IMastersManager CreateMastersManager() => new MastersManager();
    }
}
