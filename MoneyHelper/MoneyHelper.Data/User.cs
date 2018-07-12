using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MoneyHelper.Data
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long? Id { get; set; }

        [Display(Name = "Primeiro Nome")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Necessário nome")]
        public string FirstName { get; set; }

        [Display(Name = "Sobre Nome")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Necessário sobrenome")]
        public string LastName { get; set; }

        [Display(Name = "Endereço de e-mail")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Necessário endereço de e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }        
                
        public Account Account { get; set; }

        public long AccountId { get; set; }

    }
}
