using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLibrary
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [ForeignKey("UserId")]
        public int UserID { get; set; }
        public User User { get; set; }
        [Required]
        public string UserName { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        [StringLength(3000)]
        public string CommentContent { get; set; }
        [Required]
        public string Engine { get; set; }
        public bool Is_Active { get; set; }
        
        [ForeignKey("ModelId")]
        public int ModelID { get; set; }
        public Model Model { get; set; }

    }
}
