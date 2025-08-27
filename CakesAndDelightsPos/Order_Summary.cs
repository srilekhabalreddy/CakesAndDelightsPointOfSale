using System.ComponentModel;

namespace CakesAndDelightsPos
{
    public class Order_Summary
    {
        [Browsable(false)]
        public int CakeId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
    }
}
