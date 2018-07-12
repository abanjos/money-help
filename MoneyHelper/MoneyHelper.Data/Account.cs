using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyHelper.Data
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long? Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome de usuário necessário")]
        public string UserName { get; set; }

        [MinLength(6, ErrorMessage = "Mínimo de 6 caracteres")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password necessário")]
        public string PasswordHash { get; set; }

    }
}
