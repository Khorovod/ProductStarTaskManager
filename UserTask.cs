
namespace ProductStarTaskManager
{
    internal class UserTask
    {
        public int Id { get; set; }
        public string? TaskText { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Done { get; set; }
        public DateTime? DoneDate { get; set; }

    }
}
