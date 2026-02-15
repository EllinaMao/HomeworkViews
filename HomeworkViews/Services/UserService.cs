using HomeworkViews.Models;

namespace HomeworkViews.Services
{
    public class UserService
    {
        private readonly List<User> _users = new List<User>
            {
                new User { Name = "Ольга", Position = "Разработчик", Age = 25, Salary = 3000 },
                new User { Name = "Дмитрий", Position = "Дизайнер", Age = 30, Salary = 2500 },
                new User { Name = "Алексей", Position = "Менеджер", Age = 22, Salary = 2000 },
                new User {Name = "Анна", Position = "Разработчик", Age = 28, Salary = 3500 }
            };

        public IEnumerable<User> GetUsers(
            string? name,
            string? position,
            Func<User, object> keySelector, 
            bool isDescending)          
        {
            var users = _users.AsEnumerable();

            if (!string.IsNullOrEmpty(name))
                users = users.Where(u => u.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(position))
                users = users.Where(u => u.Position.Contains(position, StringComparison.OrdinalIgnoreCase));

            return isDescending
                ? users.OrderByDescending(keySelector)
                : users.OrderBy(keySelector);
        }

        public User? GetUser(Guid id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }
    }
}
