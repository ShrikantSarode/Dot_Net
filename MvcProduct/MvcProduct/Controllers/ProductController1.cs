using Microsoft.AspNetCore.Mvc;
using MvcProduct.Models;
using Newtonsoft.Json;
using System.Text;


namespace MvcProduct.Controllers
{
    public class ProductController1 : Controller
    {
        private string url = "https://localhost:7180/api/ProductApi";
        private HttpClient client = new HttpClient();

        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();

            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;    

                var data= JsonConvert.DeserializeObject<List<Product>>(result);

                if(data != null)
                {
                    products=data;
                }
            }
            return View(products);
        }

        [HttpGet]
        public IActionResult create(Product product)
        {
            string data = JsonConvert.SerializeObject(product);
            StringContent content = new StringContent(data,Encoding.UTF8,"application/json");
            HttpResponseMessage response = client.PostAsync(url,content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["insert_message"] = "Product Added..";
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product pro = new Product();
            return View();
        }
       
    }
}
