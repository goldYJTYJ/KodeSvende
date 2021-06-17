using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLibrary
{
    public class EconomyReportICE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Motorway { get; set; }
        public double City { get; set; }
        [Required]
        public double Average { get; set; }
        public int UserID { get; set; }
        public bool Is_Active { get; set; }

        [ForeignKey("EngineId")]
        public int EngineId { get; set; }
        public Engine Engine { get; set; }

    }
}
