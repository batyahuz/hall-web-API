//using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using System.Formats.Asn1;
using System.Globalization;

namespace Solid.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Catering> Caterings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }
        #region before DataBase
        //public List<Catering> Caterings { get; set; }
        //public List<Customer> Customers { get; set; }
        //public List<Event> Events { get; set; }

        //public DataContext()
        //{
        //    #region שימוש בדטה-בייס
        //    //using (var reader = new StreamReader("DataBase/cateringData.csv"))
        //    //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //    //{
        //    //    Caterings = csv.GetRecords<Catering>().ToList();
        //    //}
        //    //using (var reader = new StreamReader("DataBase/customerData.csv"))
        //    //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //    //{
        //    //    Customers = csv.GetRecords<Customer>().ToList();
        //    //}
        //    //using (var reader = new StreamReader("DataBase/eventData.csv"))
        //    //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //    //{
        //    //    Events = csv.GetRecords<Event>().ToList();
        //    //}
        //    #endregion

        //    Caterings = new List<Catering>()
        //    {
        //        new Catering(1,"משמחים",FOOD_TYPE.PARVE|FOOD_TYPE.DAIRY,70),
        //        new Catering(2, "הכי טעים בעיר",FOOD_TYPE.FLASHIC,50),
        //        new Catering(3,"בתאבון",FOOD_TYPE.PARVE,150),
        //        new Catering(4,"מנוחה ושמחה",FOOD_TYPE.FLASHIC,10)
        //    };

        //    Customers = new List<Customer>()
        //    {
        //        new Customer(1,"Reuven","0527129272","Ami 9","hutzler@g.jct.ac.il"),
        //        new Customer(2,"Batyush","0583225546","R Akiva 13","batyahuz@gamil.com"),
        //        new Customer(3,"Yaeli","0548567903","Ben Petachia 20","hutzler@g.jct.ac.il")
        //    };

        //    Events = new List<Event>()
        //    {
        //        new Event(1,new DateTime(2023,11,20),EVENT_TIME.MORNING,EVENT_KIND.BRIT,Caterings.Find(c=>c.Id==1),Customers.Find(c=>c.Id==2),40),
        //        new Event(2,new DateTime(2023,11,10),EVENT_TIME.NOON,EVENT_KIND.BAR_MITZVA,Caterings.Find(c=>c.Id==2),Customers.Find(c=>c.Id==1)),
        //        new Event(3,new DateTime(2023,11,20),EVENT_TIME.EVENING,EVENT_KIND.WEDDING,Caterings.Find(c=>c.Id==4),Customers.Find(c=>c.Id==3),300),
        //        new Event(4,new DateTime(2023,11,10),EVENT_TIME.EVENING,EVENT_KIND.BAR_MITZVA,Caterings.Find(c=>c.Id==3),Customers.Find(c=>c.Id==2),100)
        //    };
        #endregion
    }
}
