namespace ProductStarTaskManager.Repos
{
    internal interface IRepository
    {
        List<UserTask> GetUserTasks();
    }
}