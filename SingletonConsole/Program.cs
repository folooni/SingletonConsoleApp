// See https://aka.ms/new-console-template for more information

using SingletonConsole;

static class Program
{
    static TableServers host1List = TableServers.GetTableServers();
    static TableServers host2List = TableServers.GetTableServers();

    static HttpSingleton httpClient = HttpSingleton.HttpSingletonInstance();

    static async Task Main(string[] args)
    {
       //string coinDeskResult = await httpClient.GetJsonFromEndpoint(@"https://api.coindesk.com/v1/bpi/currentprice.json");
        //Console.WriteLine("coinDeskResult: " + coinDeskResult);

        //string boredResult = await httpClient.GetJsonFromEndpoint(@"https://www.boredapi.com/api/activity");
        //Console.WriteLine("boredResult: " + boredResult);

        for (int i = 0; i < 5; i++)
        {
            Host1GetNextServer();
            Host2GetNextServer();
        }
    }
    static void Host1GetNextServer()
    {
        Console.WriteLine("The next server is: " + host1List.GetNextServer());
    }
    static void Host2GetNextServer()
    {
        Console.WriteLine("The next server is: " + host2List.GetNextServer());
    }

    //static async Task<string> CallApiEndpoint()
    //{
    //    string endpoint = @"https://api.coindesk.com/v1/bpi/currentprice.json";
    //    HttpClient client = new HttpClient();
    //    client.BaseAddress = new Uri(endpoint);
    //    var response = await client.GetAsync(endpoint);
    //    var result =  await response.Content.ReadAsStringAsync();
    //    return result;
    //}
}


