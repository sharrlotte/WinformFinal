namespace DATA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReturnTicket")]
    public partial class ReturnTicket
    {
        [Key]
        [StringLength(10)]
        public string TicketId { get; set; }

        [Required]
        [StringLength(10)]
        public string BorrowTicketId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        [Required]
        [StringLength(10)]
        public string StateId { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeId { get; set; }

        public virtual BookState BookState { get; set; }

        public virtual BorrowTicket BorrowTicket { get; set; }
    }
}
