
using TodoListAppp.Managers;

namespace TodoListAppp
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Your Personal To-Do Manager");
=======
            Console.WriteLine("Welcome to the Enhanced To - Do List!");
>>>>>>> feature/add-task

            // Создаем экземпляр менеджера списка дел
            var todoManager = new TodoListManager();

            // Теперь вызываем методы через экземпляр менеджера
            todoManager.DisplayTodoList();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
