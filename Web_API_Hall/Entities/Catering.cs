using System.Xml.Linq;

namespace Web_API_Hall.Entities
{
    public enum FOOD_TYPE { DAIRY, FLASHIC, PARVE };
    public class Catering
    {
        private Catering value;

        public int Id { get; set; }
        public string Name { get; set; }
        public FOOD_TYPE FoodType { get; set; }
        public int PriceForPlate { get; set; } = 50;

        public Catering()
        {

        }
        public Catering(int id, string name, FOOD_TYPE foodType, int priceForPlate = 50)
        {
            Id = id;
            Name = name;
            FoodType = foodType;
            PriceForPlate = priceForPlate;
        }

        public Catering(Catering value)
        {
            this.Id = value.Id;
            this.Name = value.Name;
            this.FoodType = value.FoodType;
            this.PriceForPlate = value.PriceForPlate;
        }
    }
}
