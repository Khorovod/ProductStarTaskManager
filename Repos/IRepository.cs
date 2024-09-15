using ProductStarTaskManager.Tasks;

namespace ProductStarTaskManager.Repos
{
    internal interface IRepository
    {
        List<UserTask> GetUserTasks();
    }
}