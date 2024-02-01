using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ViewComponentPartialView.Models;

namespace ViewComponentPartialView.Controllers
{
    public class ArticleController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<PostViewModel> postlist;
            HttpClient client = new HttpClient();
            var response=await client.GetAsync("https://jsonplaceholder.typicode.com/posts/?id=1");
            var jsondata=await response.Content.ReadAsStringAsync();
            postlist=JsonConvert.DeserializeObject<List<PostViewModel>>(jsondata);
            return View(postlist);
        }

        public IActionResult InvokeViewComponent()
        {

            // return ViewComponent("CommentViewComponent",n1);
            return ViewComponent("CommentViewComponent", new { id=1 });
        }
    }
}
 