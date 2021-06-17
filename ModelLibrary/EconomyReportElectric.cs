using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLibrary
{
    public class EconomyReportElectric
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Full_Range { get; set; }
        public int UserID { get; set; }
        public bool Is_Active { get; set; }

        [ForeignKey("EngineId")]
        public int EngineId { get; set; }
        public Engine Engine { get; set; }

    }
}
