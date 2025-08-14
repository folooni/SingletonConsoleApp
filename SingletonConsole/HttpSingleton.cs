using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsole
{
    public class HttpSingleton
    {
        private static readonly HttpSingleton httpSingleton = new HttpSingleton();

        private HttpSingleton()
        {

        }

        public static HttpSingleton HttpSingletonInstance()
        {
            return httpSingleton;
        }

        public async Task<string> GetJsonFromEndpoint(string endpoint)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(endpoint);
            var response = await client.GetAsync(endpoint);
            if(response == null)
                return null;
            return await response.Content.ReadAsStringAsync();
        }
    }

}
