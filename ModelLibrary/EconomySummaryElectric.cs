using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLibrary
{
    public class EconomySummaryElectric
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Reported_Full_Range { get; set; }
        public double Manufacturer_Full_Range { get; set; }
        public double Reported_Watt_Hours_Per_100Km { get; set; }
        public double Manufacturer_Watt_Hours_Per_100Km { get; set; }
        public int Amount_Of_Reports { get; set; }

        [ForeignKey("EngineId")]
        public int EngineId { get; set; }
        public Engine Engine { get; set; }
    }
}
