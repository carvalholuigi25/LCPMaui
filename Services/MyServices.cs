using System.Net.Http.Json;

namespace LCPMaui.Services
{
    public interface IMyServices
    {
        public Task<List<T>> Get<T>(string apiname);
        public Task<T> GetById<T>(string apiname, int id);
        public Task<T> Create<T>(string apiname, T item);
        public Task<T> UpdateById<T>(string apiname, int? id, T item);
        public Task DeleteById<T>(string apiname, int id);
    }

    public class MyServices : IMyServices
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://localhost:5002/api";

        public MyServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<T>> Get<T>(string apiname)
        {
            return await httpClient.GetFromJsonAsync<List<T>>($"{apiUrl}/{apiname}");
        }

        public async Task<T> GetById<T>(string apiname, int id)
        {
            return await httpClient.GetFromJsonAsync<T>($"{apiUrl}/{apiname}/{id}");
        }

        public async Task<T> Create<T>(string apiname, T item)
        {
            var response = await httpClient.PostAsJsonAsync<T>($"{apiUrl}/{apiname}", item);
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> UpdateById<T>(string apiname, int? id, T item)
        {
            var resp = await httpClient.PutAsJsonAsync<T>($"{apiUrl}/{apiname}/{id}", item);
            return await resp.Content.ReadFromJsonAsync<T>();
        }

        public async Task DeleteById<T>(string apiname, int id)
        {
            await httpClient.DeleteAsync($"{apiUrl}/{apiname}/{id}");
        }
    }
}
