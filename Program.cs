using ProductStarTaskManager;
using ProductStarTaskManager.Managers;
using ProductStarTaskManager.Repos;



string connectionString = "in-memory";
var repo = RepositoryFactory.GetRepository(connectionString);
var manager = ManagerFactory.GetManager(repo);

int _id = 1;
const string create = "создать";
const string delete = "удалить";
const string update = "изменить";
const string done = "выполнить";


Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ?");
while (true)
{
    Console.WriteLine("-------------------------------------------" + Environment.NewLine
        + "Список доступных команд:" + Environment.NewLine 
        + "   " + create + Environment.NewLine
        + "   " + delete + Environment.NewLine
        + "   " + update + Environment.NewLine
        + "   " + done + Environment.NewLine
        + "Что нужно сделать?");

    var tasks = manager.GetAllTasks();

    if (tasks.Any())
    {
        foreach (var task in tasks)
        {
            Console.WriteLine(Environment.NewLine + "--------------------" + Environment.NewLine
                + "№" + task.Id + Environment.NewLine
                + "создана: " + task.CreationDate + Environment.NewLine
                + task.TaskText + Environment.NewLine
                + " статус: " + (task.Done ? "ВЫПОЛНЕНА" : "НЕ ВЫПОЛНЕНА") + Environment.NewLine 
                + "--------------------");
        }
    }

    var command = Console.ReadLine();

    switch (command?.ToLower())
    {
        case create:
            Console.WriteLine("---Введите описание: ");
            var taskText = Console.ReadLine();
            var task = new UserTask
            {
                Id = _id++,
                TaskText = taskText,
                CreationDate = DateTime.Now,
                Done = false,
            };

            manager.Create(task);

            Console.WriteLine("---Задача создана!" + Environment.NewLine + Environment.NewLine);
            break;
        case delete:
            Console.WriteLine("---Введите номер задачи для удаления: ");
            var number = Console.ReadLine();

            var deleted = manager.Delete(tasks.FirstOrDefault(t => t.Id == int.Parse(number)));
            if (deleted)
            {
                Console.WriteLine("---Задача удалена!" + Environment.NewLine + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("---Ошибка при удалении задачи!" + Environment.NewLine + Environment.NewLine);
            }
            break;
        case update:
            Console.WriteLine("---Введите номер задачи для редактирования: ");
            number = Console.ReadLine();
            task = tasks.FirstOrDefault(t => t.Id == int.Parse(number));

            Console.WriteLine("---Введите новое описание: ");
            var taskNewText = Console.ReadLine();
            task.TaskText = taskNewText;

            manager.Edit(task);
            Console.WriteLine("---Задача изменена!" + Environment.NewLine + Environment.NewLine);
            break;
        case done:
            Console.WriteLine("---Введите номер задачи для выполнения: ");
            number = Console.ReadLine();
            task = tasks.FirstOrDefault(t => t.Id == int.Parse(number));
            task.DoneDate = DateTime.Now;

            manager.Complete(task);
            Console.WriteLine("---Задача выполнена!" + Environment.NewLine + Environment.NewLine);
            break;
        default:
            Console.WriteLine("---Некорректный ввод!" + Environment.NewLine + Environment.NewLine);
            break;
    }


}
