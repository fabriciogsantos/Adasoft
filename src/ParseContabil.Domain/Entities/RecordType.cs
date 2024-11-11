namespace ParseContabil.Domain.Entities
{
    public class RecordType : Entity
    {
        public char Type { get; set; }
        public int PositionType { get; set; }
        public string? Description { get; set; }
        public string? FileOutPutName { get; set; }
        public virtual IEnumerable<Template>? Templates { get; set; }
    }
}
