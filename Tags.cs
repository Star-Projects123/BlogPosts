namespace BlogPost.Web.Models.Domain
{
    public class Tags
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String DisplayName { get; set; }

        public ICollection<Blogs> Blogs { get; set; }
    }
}
