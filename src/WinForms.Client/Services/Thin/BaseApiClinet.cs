using Newtonsoft.Json;
using System.Text;

namespace WinForms.Client.Services.Thin
{
    public abstract class BaseApiClinet<TEntity>
    {
        public HttpClient HttpClient { get; init; }
        public BaseApiClinet(HttpClient httpClient)
        {
            HttpClient = httpClient;
            HttpClient.BaseAddress = new Uri("https://localhost:7122"); //api address
        }

        public async Task AddAsync(string path, TEntity entity) => await SendPostRequestAsync(path, entity);
        public async Task UpdateAsync(string path, TEntity entity) => await SendPostRequestAsync(path, entity);
        public async Task<IEnumerable<TEntity>> GetAllAsync(string path)
        {
            var response = await HttpClient.GetAsync(path);
            IEnumerable<TEntity>? entitites = Enumerable.Empty<TEntity>();

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                entitites = JsonConvert.DeserializeObject<IEnumerable<TEntity>>(content);
            }

            return entitites ?? Enumerable.Empty<TEntity>();
        }

        private async Task SendPostRequestAsync(string path, TEntity entity)
        {
            var json = JsonConvert.SerializeObject(entity);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await HttpClient.PostAsync(path, data);
            await HandleResponseAsync(response);
        }

        private async Task HandleResponseAsync(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                MessageBox.Show(content);
            }
        }
    }
}
