using System.ComponentModel.DataAnnotations;


namespace RestaurantOrderAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
    }
}