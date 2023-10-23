namespace DATA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BorrowTicket")]
    public partial class BorrowTicket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BorrowTicket()
        {
            ReturnTickets = new HashSet<ReturnTicket>();
        }

        [Key]
        [StringLength(10)]
        public string TicketId { get; set; }

        [Required]
        [StringLength(10)]
        public string UserId { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeId { get; set; }

        [Required]
        [StringLength(10)]
        public string BookId { get; set; }

        [Required]
        [StringLength(10)]
        public string StateId { get; set; }

        [Column(TypeName = "date")]
        public DateTime BorrowDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        public bool Retuned { get; set; }

        public virtual Account Account { get; set; }

        public virtual Account Account1 { get; set; }

        public virtual Book Book { get; set; }

        public virtual BookState BookState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnTicket> ReturnTickets { get; set; }
    }
}
