using Devs2Blu.ProjetosAula.CSharpMVCRevisao.Models;
using System.Net.Http;

namespace Devs2Blu.ProjetosAula.CSharpMVCRevisao.Services
{
    public class ServiceAPI
    {
        private readonly HttpClient _httpClient;

        public ServiceAPI()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Drinks> GetListDrinks()
        {
            var listCards = await Get<Drinks>(URL_API);
            return listCards;
        }

        public async Task<Drinks> GetDrinkByName(string name)
        {
            var listCards = await Get<Drinks>(URL_API_SEARCH + name);
            return listCards;
        }


        #region BaseMethods

        public async Task<T> Get<T>(string url)
        {
            var objHttp = await GetAsync(url);

            if (!objHttp.IsSuccessStatusCode)
                return (T)(object)url;

            return await objHttp.Content.ReadFromJsonAsync<T>();

        }

        public async Task<List<T>> GetList<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return new List<T>();

            return await listHttp.Content.ReadFromJsonAsync<List<T>>();

        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            var getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            return await _httpClient.SendAsync(getRequest);
        }
        #endregion


        #region CONSTS

        private const string URL_API = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Alcoholic";
        public const string URL_API_SEARCH = "http://www.thecocktaildb.com/api/json/v1/1/search.php?s=";

        #endregion
    }
}
