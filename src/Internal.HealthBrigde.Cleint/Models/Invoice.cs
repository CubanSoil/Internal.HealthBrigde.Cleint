using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internal.HealthBrigde.Cleint.Models
{
  public class Invoice
  {
    public int InvoiceId { get; set; }
    public DateTime InvoiceDate { get; set; }
    public int PatientId { get; set; }
    public double InvoiceTotal { get; set; }
    public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }


  }
}
