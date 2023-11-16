namespace Cucolas_Anamaria_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Fullname
        {
            get { return $" {firstName} {lastName}"; }
        }
        public ICollection<Book>? Books { get; set; }
    }
}
