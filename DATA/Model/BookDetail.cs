namespace DATA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookDetail")]
    public partial class BookDetail
    {
        [StringLength(10)]
        public string Id { get; set; }

        [Required]
        [StringLength(10)]
        public string BookId { get; set; }

        [Required]
        [StringLength(10)]
        public string StorageId { get; set; }

        [Required]
        [StringLength(10)]
        public string StateId { get; set; }

        public int Amount { get; set; }

        public virtual Book Book { get; set; }

        public virtual BookState BookState { get; set; }

        public virtual Storage Storage { get; set; }
    }
}
