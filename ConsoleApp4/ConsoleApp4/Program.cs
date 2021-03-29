using System;
<<<<<<< HEAD
=======
using System.Linq;
>>>>>>> e0cd0c4 (29.04.21)

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello World!");
=======
            using (helloappdbContext db = new helloappdbContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Users u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            Console.ReadKey();
>>>>>>> e0cd0c4 (29.04.21)
        }
    }
}
