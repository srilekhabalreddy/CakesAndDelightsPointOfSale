using System.ComponentModel;

namespace CakesAndDelightsPos
{


    public class Cake
    {
        public int CakeId { get; set; }
        public string Name { get; set; }       // Cake Name
        public decimal Price { get; set; }     // Price per cake
        public string Description { get; set; }      // Short description

        [Browsable(false)] // Hides it from the DataGridView binding
        public bool IsAvailable { get; set; }   //availability

        public string Available => IsAvailable ? "Yes" : "No";
    }

}

