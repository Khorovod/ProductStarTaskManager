namespace ProductStarTaskManager.Repos
{
    internal static class RepositoryFactory
    {

        public static IRepository GetRepository(string repo) => repo switch
        {
            "in-memory" => new InMemoryRepository(),
            _ => throw new ArgumentException($"Нет хранилища {repo ?? "хранилище неопределено"}"),
        };
    }
}
