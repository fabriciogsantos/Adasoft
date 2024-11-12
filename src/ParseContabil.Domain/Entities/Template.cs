namespace ParseContabil.Domain.Entities
{
    public class Template: Entity
    {
        public Guid RecordTypeId { get; set; }
        public int Order { get; set; }
        public int Size { get; set; }
        public string? TypeData { get; set; }
        public string? Head { get; set; }
        public virtual RecordType? RecordType { get; set; }
    }
}
