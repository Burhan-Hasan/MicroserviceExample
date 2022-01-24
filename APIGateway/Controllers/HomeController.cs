using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIGateway.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public HomeController(IHttpClientFactory httpClientFactory)
        {
            HttpClientFactory = httpClientFactory;
        }

        public IHttpClientFactory HttpClientFactory { get; }

        [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            var authClient = HttpClientFactory.CreateClient();
            var discoveryDocument = await authClient.GetDiscoveryDocumentAsync("https://localhost:10001");

            var tokenResponce = await authClient.RequestClientCredentialsTokenAsync(
                new ClientCredentialsTokenRequest
                {
                    Address = discoveryDocument.TokenEndpoint,
                    ClientId = "client_id",
                    ClientSecret = "client_secrets",
                    Scope = "OrdersApi"
                });
            string token = tokenResponce.AccessToken;

            var ordersClient = HttpClientFactory.CreateClient();
            ordersClient.SetBearerToken(token);
            var response = await ordersClient.GetAsync("https://localhost:5002/api/orders");
            ViewBag.Message = response.StatusCode.ToString();
            return View();
        }
    }
}
