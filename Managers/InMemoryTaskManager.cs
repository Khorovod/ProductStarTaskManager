namespace ProductStarTaskManager.Managers
{
    internal class InMemoryTaskManager : ITaskManager
    {
        private List<UserTask> _tasks;

        public InMemoryTaskManager(List<UserTask> tasks)
        {
            _tasks = tasks;
        }

        public List<UserTask> GetAllTasks() => _tasks.OrderBy(t => t.Id).ToList();

        public int Create(UserTask task)
        {
            if (task is not null)
            {
                _tasks.Add(task);

                return task.Id;
            }

            throw new ArgumentNullException("Задача должна быть");
        }

        public bool Delete(UserTask task)
        {
            if (task is not null
                && _tasks.Any(t => t.Id == task.Id))
            {
                _tasks.Remove(task);
                return true;
            }

            return false;
        }

        public bool Edit(UserTask task)
        {
            if (task is not null
                && _tasks.Any(t => t.Id == task.Id))
            {
                Delete(task);
                Create(task);   
                return true;
            }

            return false;
        }

        public bool Complete(UserTask task)
        {
            if (task is not null
                && _tasks.Any(t => t.Id == task.Id))
            {
                _tasks.First(t => t.Id == task.Id).Done = true;
                return true;
            }

            return false;
        }
    }
}
