using System.Collections;

namespace ConsoleApp2.LessonEight
{
    internal class Program
    {
        internal static void Start()
        {
            List<User> people = new List<User>();
            people.Add(new User() { Id = 0, Name = "Vlad", Age = 20, Email = "Vlad20" });
            people.Add(new User() { Id = 1, Name = "Vlad", Age = 22, Email = "Vlad22" });
            people.Add(new User() { Id = 2, Name = "Andrey", Age = 24, Email = "Andrey24" });
            people.Add(new User() { Id = 3, Name = "Vasiliy", Age = 27, Email = "Vasiliy27" });
            people.Add(new User() { Id = 4, Name = "Artem", Age = 19, Email = "Artem19" });
            people.Add(new User() { Id = 5, Name = "Anatoliy", Age = 29, Email = "Anatoliy29" });
            people.Add(new User() { Id = 6, Name = "Vadim", Age = 28, Email = "Vadim28" });
            people.Add(new User() { Id = 7, Name = "Vadim", Age = 22, Email = "Vadim22" });
            people.Add(new User() { Id = 8, Name = "Vadim", Age = 21, Email = "Vadim21" });
            people.Add(new User() { Id = 9, Name = "Dmitriy", Age = 23, Email = "Dmitriy23" });

            //вход в приложение
            string name = "Vasiliy27";
            var user = people.FirstOrDefault(x => x.Email == name);
            if (user is not null)
            {
                Console.WriteLine($"Привет {user.Name}");
            }
            else
            {
                Console.WriteLine("Я тебя не знаю :)");
            }

            //листание списка пользователей
            GetUserByPage(0, people);

            GetUserByPage(1, people);

            GetUserByPage(2, people);

            bool isContains = people.Contains(user);
            Console.WriteLine(isContains);

            isContains = people.All(a => a.Age >= 18);
            Console.WriteLine(isContains);

            isContains = people.Any(a => a.Age >= 29);
            Console.WriteLine(isContains);
        }

        internal static void GetUserByPage(int page, List<User> people)
        {
            int count = 4;
            var partPeoples = people
                .Where(x => x.Age >= 20)
                .Skip(page * count)
                .Take(count);

            foreach (var part in partPeoples)
            {
                Console.WriteLine(part.Name);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация простого LinQ запроса
        /// </summary>
        internal static void LinqOne()
        {
            List<User> people = new List<User>();
            people.Add(new User() { Id = 0, Name = "Vlad", Age = 20 });
            people.Add(new User() { Id = 1, Name = "Vlad", Age = 22 });
            people.Add(new User() { Id = 2, Name = "Andrey", Age = 24 });
            people.Add(new User() { Id = 3, Name = "Vasiliy", Age = 27 });
            people.Add(new User() { Id = 4, Name = "Artem", Age = 19 });

            List<User> newPeople = people.Where(item => item.Age > 20).ToList();
            //List<string> newPeople = new List<string>();
            //foreach (var item in people)
            //{
            //    if (item.Length > 4)
            //    {
            //        newPeople.Add(item);
            //    }
            //}

            foreach (var item in newPeople)
            {
                Console.WriteLine(item.Name);
            }
        }

        /// <summary>
        /// Демонстрация отложенного выполнения
        /// </summary>
        internal static void LinqTwo()
        {
            List<User> people = new List<User>();
            people.Add(new User() { Id = 0, Name = "Vlad", Age = 20 });
            people.Add(new User() { Id = 1, Name = "Vlad", Age = 22 });
            people.Add(new User() { Id = 2, Name = "Andrey", Age = 24 });
            people.Add(new User() { Id = 3, Name = "Vasiliy", Age = 27 });
            people.Add(new User() { Id = 4, Name = "Artem", Age = 19 });

            var newPeople = people.Where(item => item.Age > 20);

            people.Add(new User() { Id = 5, Name = "Anatoliy", Age = 28 });

            foreach (var item in newPeople)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

            people.Add(new User() { Id = 5, Name = "Vadim", Age = 28 });

            foreach (var item in newPeople)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    /// <summary>
    /// Класс моего пользователя
    /// </summary>
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}