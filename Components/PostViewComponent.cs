using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using ViewComponentPartialView.Models;

namespace ViewComponentPartialView.Components
{
    public class PostViewComponent : ViewComponent
    {/*public IViewComponentResult Invoke()
        {
            List<string> stringlist = new List<string>();
            stringlist.Add("good");
            stringlist.Add("better");
            stringlist.Add("best");

            return View("~/Views/Components/_comment.cshtml", stringlist);

        }
        public async Task<IViewComponentResult> InvokeAsync1()
        {
            List<string> stringlist = new List<string>();
            stringlist.Add("good");
            stringlist.Add("better");
            stringlist.Add("best");

            return View("~/Views/Components/_comment.cshtml", stringlist);

        }*/
        //public async Task<IViewComponentResult> Invoke()
        //{
        //    List<PostViewModel> postlist;
        //    HttpClient client = new HttpClient();
        //    var response=await client.GetAsync("https://jsonplaceholder.typicode.com/posts/?id=1");
        //    var jsondata =await response.Content.ReadAsStringAsync();
        //    postlist=JsonConvert.DeserializeObject<List<PostViewModel>>(jsondata);//jsondata
        //    return View("~/Views/Components/_post.cshtml",postlist);
        //}

    }
}
