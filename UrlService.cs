using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

public class YourController : Controller
{
    private readonly HttpClient _httpClient;

    public YourController()
    {
        _httpClient = new HttpClient();
    }

    

    public async Task<int?> GetStatusCodeFromUrlAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            return (int)response.StatusCode;
        }
        catch (HttpRequestException)
        {
            return null;
        }
    }
}
