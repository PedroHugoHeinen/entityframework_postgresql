using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entityframework_postgresql.Models.Entities
{
    [Table("Peoples")]
    public class People
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string RecoveryEmail { get; set; }

        public string? Contact { get; set; }

        [Required]
        public DateTimeOffset BirthDate { get; set; }

        [Required]
        public DateTimeOffset CreateDateTime { get; set; }

        public DateTimeOffset? UpdateDateTime { get; set;}
    }
}
