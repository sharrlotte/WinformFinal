namespace DATA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            BookDetails = new HashSet<BookDetail>();
            BorrowTickets = new HashSet<BorrowTicket>();
        }

        [StringLength(10)]
        public string BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string BookName { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "date")]
        public DateTime PublishDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Cover { get; set; }

        [Required]
        [StringLength(10)]
        public string CategoryId { get; set; }

        [Required]
        [StringLength(10)]
        public string AuthorId { get; set; }

        [Required]
        [StringLength(10)]
        public string LanguageId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }

        public virtual Language Language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookDetail> BookDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowTicket> BorrowTickets { get; set; }
    }
}
