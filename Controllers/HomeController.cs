using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using ViewComponentPartialView.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Newtonsoft.Json;

//calling api stackoverflow.com/questions/9620278/how-do-i-make-calls-to-a-rest-api-using-c
//stackoverflow.com/questions/55359047/how-to-make-http-call-from-controller-to-use-web-apis-asp-net-core-c-sharp
namespace ViewComponentPartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index1()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/?id=1");
            var jsonstring = await response.Content.ReadAsStringAsync();
            //www.tutorialsteacher.com/articles/convert-json-string-to-object-in-csharp
            IList<PostViewModel> csharpobj = JsonConvert.DeserializeObject<IList<PostViewModel>>(jsonstring);//cannot convert Tasks.Task<string> to string
            return View(csharpobj);
        }


        [HttpGet]
        public async Task<ActionResult<string>> GetDataFromAPI()
        {
            string url = "https://jsonplaceholder.typicode.com/posts/?id=1";
           // HttpClient client=new HttpClient();
            //client.BaseAddress = new Uri(url);
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response=client.GetAsync(url).Result;
            //if(response.IsSuccessStatusCode)
            //{
            //    var dataObjects =response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;
            //}



            //string url = "https://jsonplaceholder.typicode.com/posts/id="+"1";
            //  string urlparam = "?id=1";
            //using (HttpClient client = new HttpClient())
            //{
            //    return client.GetAsync(url);
            //}
            //  return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Post()
        {
           //Create a Post page to display the post
           //Access the post comments from the comment’s backend API at //jsonplaceholder.typicode.com/




            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
