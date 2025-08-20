namespace Domain.SQLite.Bases
{
    public class Base
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastChange { get; set; }
    }
}
