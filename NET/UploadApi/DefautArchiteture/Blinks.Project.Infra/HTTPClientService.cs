using Blinks.Project.Domain;
using Newtonsoft.Json;
using System.Net.Http.Formatting;

namespace Blinks.Project.Infra
{
    public static class HTTPClientService<TEntity> where TEntity : BaseEntity
    {
        public static async Task<TEntity> Get(string url)
        {
            TEntity result = null;
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(new Uri(url)).Result;

                response.EnsureSuccessStatusCode();
                await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) => result = JsonConvert.DeserializeObject<TEntity>(x.Result));
            }

            return result;
        }

        public static async Task<TEntity> PostRequest(string apiUrl, TEntity postObject)
        {
            TEntity result = null;

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(apiUrl, postObject, new JsonMediaTypeFormatter()).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                {
                    if (x.IsFaulted)
                        throw x.Exception;

                    result = JsonConvert.DeserializeObject<TEntity>(x.Result);
                });
            }

            return result;
        }

        public static async Task PutRequest(string apiUrl, TEntity putObject)
        {
            using var client = new HttpClient();
            var response = await client.PutAsync(apiUrl, putObject, new JsonMediaTypeFormatter()).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
        }
    }
}
