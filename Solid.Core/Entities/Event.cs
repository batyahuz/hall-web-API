using System.Xml.Linq;

namespace Solid.Core.Entities
{
    public enum EVENT_KIND { OTHER = 1, BRIT, SHEVA_BRACHOS, BAR_MITZVA, WEDDING };
    public enum EVENT_TIME { MORNING = 1, NOON, AFTER_NOON, EVENING };
    public class Event
    {
        //private Event value;
        private static int id = 1;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public EVENT_TIME Time { get; set; }
        public EVENT_KIND Kind { get; set; } = EVENT_KIND.OTHER;
        public int PriceHasPaid { get; set; } = 0;
        public int FinallSum { get => AmountOfPortions * Catering.PriceForPlate + 2500 * (int)Kind; }
        public int SumToPay { get => FinallSum - PriceHasPaid; }
        public Catering Catering { get; set; }
        public Customer Customer { get; set; }
        public string Comments { get; set; }
        public int AmountOfPortions { get; set; } = 10;

        public Event()
        {

        }
        public Event(int id, DateTime date, EVENT_TIME time, EVENT_KIND kind, Catering? catering, Customer? customer, int amountOfPortions = 10, string comments = "")
        {
            Id = Event.id++;
            Date = date;
            Time = time;
            Kind = kind;
            Catering = catering;
            Customer = customer;
            Comments = comments;
            AmountOfPortions = amountOfPortions;
        }

        public Event(Event value)
        {
            this.Id = value.Id;
            this.Date = value.Date;
            this.Time = value.Time;
            this.Kind = value.Kind;
            this.Catering = value.Catering;
            this.Customer = value.Customer;
            this.Comments = value.Comments;
            this.AmountOfPortions = value.AmountOfPortions;
        }
        public override bool Equals(object? obj)
        {
            return obj != null && obj.GetType() != this.GetType() && Id == ((Event)obj).Id;
        }
    }
}
