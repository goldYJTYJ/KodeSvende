using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [RegularExpression(@"^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+))@([A-Za-z0-9]+)(([.-‌​]?[a-zA-Z0-9]+)).([A-Za-z]{2,})$", ErrorMessage = "Email is not valid")]
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        public DateTime AccountCreation { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Administrator { get; set; }

    }
}
