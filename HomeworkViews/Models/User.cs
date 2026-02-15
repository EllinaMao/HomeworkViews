/*
На странице сайта вывести список пользователей (объекты класса «User»). На странице реализовать возможности:

⦁ Поиск по имени

⦁ Поиск по должности

⦁ Сортировка по возрасту

⦁ Сортировка по заработной плате

При желании, можно использовать AJAX для обработки поиска и сортировки без перезагрузки страницы.
 */

namespace HomeworkViews.Models
{
    public class User
    {
        public Guid Id { get; set; } =  new Guid();
        public string Name { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public decimal Salary { get; set; }   = 0;  

    }
}
