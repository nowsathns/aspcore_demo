namespace HelloCore.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public TaskType TaskType { get; set; }
    }

    public enum TaskType
    {
        High,
        Low,
        Midaum
    }
}