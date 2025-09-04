using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Employee.Api.Model
{
    public class EmployeeData
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string firtName { get; set; }
        [Required]
        [MaxLength(50)]
        public string lastName { get; set; }
        public string email { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string contactNo { get; set; }
        public string city { get; set; }
        public string adress { get; set; }

    }
}
