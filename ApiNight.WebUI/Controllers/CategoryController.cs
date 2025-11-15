using ApiNight.WebUI.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ApiNight.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> CategoryList()
        {
            var client=_httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("https://localhost:7124/api/Categories");
            if (responsemessage.IsSuccessStatusCode)
            { 
                var jsondata=await responsemessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
