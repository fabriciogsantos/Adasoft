namespace ParseContabil.Domain.Entities
{
    public class ProcessTaskLog : Entity
    {
        public short Status { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string? Result { get; set; }
    }
}
