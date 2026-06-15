using System.ComponentModel.DataAnnotations;

namespace RazorTemp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display (Name = "Category Name")]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range (1, int.MaxValue, ErrorMessage = "Display Order must be greater than 0")]
        public int DisplayOrder { get; set; }


    }
}
