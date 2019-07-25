using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Internal.HealthBrigde.Cleint.Models
{
  public class Patient
  {
    public int PatientId { get; set; }
    [Required]
    [StringLength(255)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required]
    [StringLength(255)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [Display(Name = "Identity Number")]
    public int IdNumber { get; set; }
  }
}
