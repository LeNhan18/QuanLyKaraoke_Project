namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PLAYLIST")]
    public partial class PLAYLIST
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Names { get; set; }

        [Required]
        public string FilePath { get; set; }
    }
}
