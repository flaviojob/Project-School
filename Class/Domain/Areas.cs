namespace School.Class.Domain
{
    public class Areas
    {
        public int Id { get; set; } 
        public string Title { get; set; }  
        public Areas()
        {

        }
        public Areas(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }
    }
}