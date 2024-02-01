using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ViewComponentPartialView.Models;

namespace ViewComponentPartialView.Components
{
    public class CommentViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            //hit the api-done
            //get json--done
            //convert to view(convert json to model)
            //return the model to view
            List<CommentViewModel> commentlist;
            HttpClient client= new HttpClient();
            var response=await client.GetAsync("https://jsonplaceholder.typicode.com/comments/?postId="+id);
            var jsondata=await response.Content.ReadAsStringAsync();//content will get set jsondata
            //JsonConvert.DeserializeObject<to specific object>
            commentlist =JsonConvert.DeserializeObject<List<CommentViewModel>>(jsondata);
               return View("~/Views/Components/_commentsofpost.cshtml", commentlist);
            //return View("_commentsofpost.cshtml", commentlist);
        }
      

    }
}
