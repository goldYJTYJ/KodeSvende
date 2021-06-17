using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLibrary
{
    public class EconomySummaryICE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Reported_Motorway { get; set; }
        public double Reported_City { get; set; }
        [Required]
        public double Reported_Average { get; set; }
        public int Amount_Of_Reports { get; set; }
        [Required]
        public double Manufacturer_Average { get; set; }

        [ForeignKey("EngineId")]
        public int EngineId { get; set; }
        public Engine Engine { get; set; }
    }
}
