using HomeworkViews.Models;

namespace HomeworkViews.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; } = new List<User>();

        public string? SearchName { get; set; }
        public string? SearchPosition { get; set; }

        public string? SortOrder { get; set; }

    }
}
