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

        public string Name { get; set; }

        public string Email { get; set; }        

        public Account Account { get; set; }

        public long AccountId { get; set; }

    }
}
