using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyHelper.Data
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public TransactionType TransactionType { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }
                
        public long CategoryId { get; set; }

        public Bill Bill { get; set; }
                
        public long BillId { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Consolidated { get; set; }

    }
}
