using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Internal.HealthBrigde.Cleint.Models;

namespace Internal.HealthBrigde.Cleint.ViewModel
{
  public class InvoiceCreateViewModel
  {
    public int InvoiceId { get; set; }
    public int PatientId { get; set; }
    public DateTime InvoiceDate { get; set; }
    public string PatientName { get; set; }
    public double InvoiceTotal { get; set; }
    public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }

    public List<Patient> Patients { get; set; }

  }
}