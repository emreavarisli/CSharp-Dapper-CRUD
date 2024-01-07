using System.ComponentModel.DataAnnotations;

namespace CrudDapper.Entity
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
