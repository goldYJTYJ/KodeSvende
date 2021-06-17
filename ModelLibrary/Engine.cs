using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLibrary
{
    public class Engine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Type { get; set; }
        [Required]
        [StringLength(100)]
        public string Size { get; set; }
        [Required]
        [StringLength(100)]
        public string Fuel { get; set; }
        public double WLTP { get; set; }
        public double NEDC { get; set; }
        public string Watt_Hours_Per_KM { get; set; }
        public bool Is_Electric { get; set; }
        public bool Is_Active { get; set; }

        [ForeignKey("ModelId")]
        public int ModelId { get; set; }
        public Model Model { get; set; }

    }
}
