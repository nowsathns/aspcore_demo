namespace HelloCore.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public Typex TaskType { get; set; }
    }

    public enum Typex
    {
        High,
        Low,
        Midaum
    }
}