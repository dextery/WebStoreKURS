using System.Net.Http.Json;
using System.Text.Json.Nodes;
using System.Text;
using WebStoreApi.Contract;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace WebStoreApi.Client
{
	public class WebStoreApiClient : IDisposable
	{
		public void Dispose()
		{
			_httpClient.Dispose();
		}

		private HttpClient _httpClient;

		public WebStoreApiClient(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<RoleContract[]> GetAll()
		{
			var response = await _httpClient.GetAsync("api/Roles/GetAll").ConfigureAwait(false);
			response.EnsureSuccessStatusCode();

			return await response.Content.ReadFromJsonAsync<RoleContract[]>().ConfigureAwait(false);
		}

		public async Task Update(EditRoleContract contract)
		{
			using var content = new StringContent(JsonSerializer.Serialize(contract), Encoding.UTF8, "application/json");
			var response = await _httpClient.PostAsync("api/Roles/Update", content).ConfigureAwait(false);
			response.EnsureSuccessStatusCode();
		}

	}
}