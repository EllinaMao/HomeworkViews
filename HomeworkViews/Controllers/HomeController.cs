using HomeworkViews.Models;
using HomeworkViews.Services;
using HomeworkViews.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeworkViews.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService _userService;

        public HomeController(UserService userService)
        {
            _userService = userService;
        }


        public IActionResult Index(string searchName, string searchPosition, string sortOrder)
        {
            bool isDesc = sortOrder?.EndsWith("_desc") ?? false;

            Func<User, object> sortSelector = sortOrder switch
            {
                "Age" or "age_desc" => u => u.Age,
                "Salary" or "salary_desc" => u => u.Salary,
                "Position" => u => u.Position,
                _ => u => u.Name 
            };

            var users = _userService.GetUsers(searchName, searchPosition, sortSelector, isDesc);

            var model = new UserViewModel
            {
                Users = users,
                SearchName = searchName,
                SearchPosition = searchPosition,
                SortOrder = sortOrder 
            };

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("UserTable", model);
            }
            return View(model);
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
