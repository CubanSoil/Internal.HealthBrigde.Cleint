using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Internal.HealthBrigde.Cleint.Models
{
  public class InvoiceLine
  {
    public int InvoiceLineId { get; set; }

    [Display(Name = "Qty")]
    public int Qty { get; set; }
    [Required]
    [Display(Name = "Code")]
    public string Code { get; set; }
    [Display(Name = "Description")]
    public string Description { get; set; }

    [Display(Name = "Total")]
    public double LineTotal { get; set; }


  }
}
