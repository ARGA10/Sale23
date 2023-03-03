using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sales.Shared.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }

        [Display(Name = "Categoria de producto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caractéres")]
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Product>? Products { get; set; }
        public int ProductsNumber => Products == null ? 0 : Products.Count;
    }
}
