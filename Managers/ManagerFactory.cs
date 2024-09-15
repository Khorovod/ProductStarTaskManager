using ProductStarTaskManager.Repos;

namespace ProductStarTaskManager.Managers
{
    internal static class ManagerFactory
    {

        public static ITaskManager GetManager(IRepository repo) => repo switch
        {
            InMemoryRepository => new InMemoryTaskManager(repo.GetUserTasks()),
            _ => throw new ArgumentException($"Нет менеджера {nameof(repo)}"),
        };
    }
}
