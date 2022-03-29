namespace WebApplication1.Entites
{
    public class Company
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string Country { get; set; }

        public string Designation { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
