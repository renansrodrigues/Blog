using Blog.Models;
using Blog.Service.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogPostService _blogPostService;
        private readonly IHostingEnvironment _env;
        public HomeController(ILogger<HomeController> logger, IBlogPostService blogPostService, IHostingEnvironment env)
        {
            _logger = logger;
            _blogPostService = blogPostService;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public JsonResult LatestBlogPosts()
        {
                  
            return Json(_blogPostService.GetLatestPosts());
        }


        public ContentResult Post(string link)
        {
                        
            var blogPostView = _blogPostService.GetPostText(link);
            var text = System.IO.File.ReadAllText($"{_env.ContentRootPath}/wwwroot/Posts/{blogPostView.PostId}_post.md");
            return Content(text);
        }



    }
}
