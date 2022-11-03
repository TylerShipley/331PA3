namespace api.Models
{
    public class Drivers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateHired {get;set;}
        public int Rating {get;set;}
        public Boolean Active {get;set;}
    }
}