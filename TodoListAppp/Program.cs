
using System.ComponentModel.Design;
using TodoListAppp.Managers;

namespace TodoListAppp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Your Ultimate To-Do List!");


            // Создаем экземпляр менеджера списка дел
            var todoManager = new TodoListManager();

            RunInteractive(todoManager); // Запускаем основной интерактивный режим

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }


        static void RunInteractive(TodoListManager manager)
        {
            while (true)
            {
                manager.DisplayTodoList(); // Показываем текущий список дел
                Console.WriteLine("\nAvailable commands: add, toggle, exit");
                Console.Write("Enter command: ");
                string command = Console.ReadLine().Trim().ToLower();
                bool operationSuccessful = false; // Флаг для индикации успеха операции

                switch (command)
                {
                    case "add":
                        Console.Write("Enter the description for the new task: ");
                        string description = Console.ReadLine();
                        operationSuccessful = manager.AddTask(description);
                        break;

                    case "toggle":                        
                        Console.Write("Enter the ID of the task to toggle completion: ");
                        string taskIdInput = Console.ReadLine();
                        if (int.TryParse(taskIdInput, out int taskId))
                        {
                            operationSuccessful = manager.ToggleTaskCompletion(taskId);
                        }
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Error: Unknown command. Please try again.");
                        operationSuccessful = false;
                        break;
                }
                if (operationSuccessful || command == "add" || command == "toggle" || command == "exit" || command == null)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
    }
}