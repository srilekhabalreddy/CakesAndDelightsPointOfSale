namespace CakesAndDelightsPos
{


    public class Cake
    {
        public int CakeId { get; set; }
        public string Name { get; set; }       // Cake Name
        public decimal Price { get; set; }     // Price per cake
        public string Description { get; set; }      // Short description
        public Boolean IsAvailable { get; set; }   //availability
    }

}

