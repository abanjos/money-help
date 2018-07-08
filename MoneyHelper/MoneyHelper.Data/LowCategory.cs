using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyHelper.Data
{
    public class LowCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long? LowCategoryId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}