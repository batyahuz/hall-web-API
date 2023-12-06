using System.Net;
using System.Xml.Linq;

namespace Solid.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public bool Status { get; set; } = true;
        public List<Event> Events { get; set; } = new List<Event>();


        public Customer()
        {

        }
        public Customer(int id, string name, string phneNumber, string address, string email, string comments = "")
        {
            Id = id;
            Name = name;
            PhoneNum = phneNumber;
            Address = address;
            Email = email;
            Comments = comments;
        }
        public Customer(Customer customer)
        {
            this.Id = customer.Id;
            this.Name = customer.Name;
            this.PhoneNum = customer.PhoneNum;
            this.Address = customer.Address;
            this.Email = customer.Email;
            this.Comments = customer.Comments;
            customer.Events.ForEach(e => this.Events.Add(e));
            this.Status = customer.Status;
        }
    }
}
