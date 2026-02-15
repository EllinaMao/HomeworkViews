using HomeworkViews.Models;

namespace HomeworkViews.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; } = new List <User>();

        public string? SearchName { get; set; }
        public string? SearchPosition { get; set; }

        public string? CurrentSort { get; set; }


        public string AgeSortParam => CurrentSort == "Age" ? "age_desc" : "Age";
        public string SalarySortParam => CurrentSort == "Salary" ? "salary_desc" : "Salary";

        public string GetSortIcon(string columnName)
        {
            if (CurrentSort == columnName) return "▲";
            if (CurrentSort == $"{columnName}_desc") return "▼";
            return "";
        }
    }
}
