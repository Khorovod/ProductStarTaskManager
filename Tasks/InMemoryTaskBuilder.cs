namespace ProductStarTaskManager.Tasks
{
    internal class InMemoryTaskBuilder : ITaskBuilder
    {
        private int _id = 1;

        public UserTask CreateTask(string description)
        {
            return new UserTask
            {
                Id = _id++,
                TaskText = description,
                CreationDate = DateTime.Now,
                Done = false,
            };
        }
    }
}
