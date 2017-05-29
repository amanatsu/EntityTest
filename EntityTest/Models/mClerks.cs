namespace EntityTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mClerks
    {
        [Key]
        [StringLength(4)]
        public string scClerkCode { get; set; }

        [StringLength(20)]
        public string sClerkPassword { get; set; }

        [StringLength(4)]
        public string scHtlcod { get; set; }

        public int? nClerkSeq { get; set; }

        [StringLength(20)]
        public string sClerkName { get; set; }

        [StringLength(50)]
        public string sDisplayName { get; set; }

        public int? nDisplayFlagID { get; set; }

        public DateTime? dtUpdate { get; set; }

        [StringLength(4)]
        public string scClerkMenuType { get; set; }
    }
}
