using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Data
{
    public class Order
    {
        [Key]
        public int? OrderID { get; set; }
        [Required]
        public string CustomerID { get; set; }
        [Required]
        public int EmployeeID { get; set; }
        [Required]
        public decimal Freight { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ShipCountry { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipName { get; set; }
    }
}
