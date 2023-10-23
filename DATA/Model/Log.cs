namespace DATA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        [StringLength(10)]
        public string LogId { get; set; }

        [Required]
        [StringLength(10)]
        public string UserId { get; set; }

        [Required]
        [StringLength(150)]
        public string Message { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }

        public virtual Account Account { get; set; }
    }
}
