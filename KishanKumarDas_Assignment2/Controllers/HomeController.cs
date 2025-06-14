using System.Diagnostics;
using KishanKumarDas_Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KishanKumarDas_Assignment2.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext context {  get; set; }

        public HomeController(AppDbContext ctx)
        {
            context = ctx;
        }

        [Route("")]
        [Route("topic/{topic}/category/{category}/")]
        [Route("topic/{topic}/")]
        [Route("category/{category}/")]
        public IActionResult Index(string topic, string category)
        {
            var faqs = context.Faqs
                .Include(f => f.Topic)
                .Include(f => f.Category)
                .AsQueryable();

            if (!string.IsNullOrEmpty(topic))
                faqs = faqs.Where(f => f.TopicId == topic);

            if (!string.IsNullOrEmpty(category))
                faqs = faqs.Where(f => f.CategoryId == category);

            ViewBag.Topics = context.Topics.ToList();
            ViewBag.Categories = context.Categories.ToList();
            ViewBag.SelectedTopic = topic;
            ViewBag.SelectedCategory = category;

            return View(faqs.ToList());
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
    }
}
