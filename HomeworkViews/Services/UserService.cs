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

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
        public IEnumerable<User> SearchByName(string name)
        {
            return _users.Where(u => u.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
        public IEnumerable<User> SearchByPosition(string position)
        {
            return _users.Where(u => u.Position.Contains(position, StringComparison.OrdinalIgnoreCase));
        }
        public IEnumerable<User> SortByAge(bool ascending = true)
        {
            return ascending ? _users.OrderBy(u => u.Age) : _users.OrderByDescending(u => u.Age);
        }
        public IEnumerable<User> SortBySalary(bool ascending = true)
        {
            return ascending ? _users.OrderBy(u => u.Salary) : _users.OrderByDescending(u => u.Salary);
        }

        public User? GetUser(Guid id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }
    }
}
