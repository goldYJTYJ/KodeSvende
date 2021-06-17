using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLibrary
{
    public class Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string ModelName { get; set; }
        [Required]
        [Range(1896, 2030)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public int Year { get; set; }

        public bool Is_Active { get; set; }
        [ForeignKey("ManufacturerId")]
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
