using HomeworkViews.Models;

namespace HomeworkViews.Controllers
{
    internal class IndexViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public string SearchName { get; set; }
        public string SearchPosition { get; set; }
        public string CurrentSort { get; set; }
    }
}