namespace ProductStarTaskManager.Tasks
{
    internal interface ITaskBuilder
    {
        UserTask CreateTask(string description);
    }
}