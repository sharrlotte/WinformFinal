namespace DATA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookState")]
    public partial class BookState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookState()
        {
            BookDetails = new HashSet<BookDetail>();
            BorrowTickets = new HashSet<BorrowTicket>();
            ReturnTickets = new HashSet<ReturnTicket>();
        }

        [Key]
        [StringLength(10)]
        public string StateId { get; set; }

        [Required]
        [StringLength(50)]
        public string StateName { get; set; }

        [Required]
        [StringLength(150)]
        public string StateDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookDetail> BookDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowTicket> BorrowTickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnTicket> ReturnTickets { get; set; }
    }
}
