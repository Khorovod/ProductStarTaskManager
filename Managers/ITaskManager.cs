using ProductStarTaskManager.Tasks;

namespace ProductStarTaskManager.Managers
{
    internal interface ITaskManager
    {
        List<UserTask> GetAllTasks();
        bool Complete(UserTask task);
        int Create(UserTask task);
        bool Delete(UserTask task);
        bool Edit(UserTask task);
    }
}