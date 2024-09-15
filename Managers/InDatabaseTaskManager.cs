using ProductStarTaskManager.Repos;
using ProductStarTaskManager.Tasks;

namespace ProductStarTaskManager.Managers
{
    internal class InDatabaseTaskManager : ITaskManager
    {
        private readonly InMemoryRepository _repository;

        public InDatabaseTaskManager(InMemoryRepository repository)
        {
            _repository = repository;
        }

        public bool Complete(UserTask task)
        {
            throw new NotImplementedException();
        }

        public int Create(UserTask task)
        {
            throw new NotImplementedException();
        }

        public bool Delete(UserTask task)
        {
            throw new NotImplementedException();
        }

        public bool Edit(UserTask task)
        {
            throw new NotImplementedException();
        }

        public List<UserTask> GetAllTasks()
        {
            throw new NotImplementedException();
        }
    }
}
