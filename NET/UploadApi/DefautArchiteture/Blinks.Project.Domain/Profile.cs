namespace Blinks.Project.Domain
{
    public class Profile : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
