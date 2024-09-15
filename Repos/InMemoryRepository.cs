namespace ProductStarTaskManager.Repos
{
    internal class InMemoryRepository : IRepository
    {
        public List<UserTask> GetUserTasks() => new();
    }
}
