using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace BlazorCRUDWebApp.Models
{
    [Table("people")]
    public class Employee
    {

        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "Field 'name' is required")]
        public string Name { get; set; } = String.Empty;

        [Column("gender")]
        [Required(ErrorMessage = "Field 'gender' is required")]
        public string Gender { get; set; } = String.Empty;

        [Column("position")]
        [Required(ErrorMessage = "Field 'position' is required")]
        public string Position { get; set; } = String.Empty;

        [Column("birthdate")]
        [Required(ErrorMessage = "Field 'birthyear' is required")]
        public int Birthdate { get; set; }

        [Column("salary")]
        [Required(ErrorMessage = "Field 'salary' is required")]
        public double Salary { get; set; }
    }
}
