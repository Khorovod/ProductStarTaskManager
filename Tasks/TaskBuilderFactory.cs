using ProductStarTaskManager.Repos;

namespace ProductStarTaskManager.Tasks
{
    internal static class TaskBuilderFactory
    {
        public static ITaskBuilder GetTaskBuilder(IRepository repo) => repo switch
        {
            InMemoryRepository => new InMemoryTaskBuilder(),
            _ => throw new ArgumentException($"Нет менеджера {nameof(repo)}"),
        };
    }
}
