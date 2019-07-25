using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Internal.HealthBrigde.Cleint.Models;
using Internal.HealthBrigde.Cleint.ViewModel;

namespace Internal.HealthBrigde.Cleint.Controllers
{
  public class InvoiceController : Controller
  {
    // GET: Invoice
    public ActionResult Index()
    {
      var invoices = new List<Invoice>
      {
        new Invoice
        {
          PatientId = 1,
          InvoiceDate = DateTime.Now,
          InvoiceId = 123,
          InvoiceTotal = 500,
          InvoiceLines = new List<InvoiceLine>
          {
            new InvoiceLine
            {
              Code = "TT20",
              Description = "consult",
              InvoiceLineId = 100,
              LineTotal = 300,
              Qty = 1,

            },
            new InvoiceLine
            {
              Code = "TT21",
              Description = "Cough syrup",
              InvoiceLineId = 101,
              LineTotal = 2,
              Qty = 1,

            }
          }
        },
        new Invoice
        {
          PatientId = 2,
          InvoiceDate = DateTime.Now,
          InvoiceId = 124,
          InvoiceTotal = 600,
          InvoiceLines = new List<InvoiceLine>
          {
            new InvoiceLine
            {
              Code = "TT23",
              Description = "consult",
              InvoiceLineId = 104,
              LineTotal = 300,
              Qty = 1,

            },
            new InvoiceLine
            {
              Code = "TT24",
              Description = "Cough syrup",
              InvoiceLineId = 105,
              LineTotal = 300,
              Qty = 1,

            }
          }
        }
      };
      return View(invoices);
    }

    // GET: Invoice/Details/5
    public ActionResult Details(int id)
    {
      return View();
    }


    public ActionResult New()
    {
      var patients = new List<Patient>
      {
        new Patient
        {
          PatientId = 1,
          FirstName = "Sethu",
          LastName = "Mazibuko",
          IdNumber = 8922
        },
        new Patient
        {
          PatientId = 2,
          FirstName = "Lucky",
          LastName = "Zulu",
          IdNumber = 8922
        },
        new Patient
        {
          PatientId = 3,
          FirstName = "Zama",
          LastName = "Gumbi",
          IdNumber = 8922
        },
        new Patient
        {
          PatientId = 4,
          FirstName = "Menzi",
          LastName = "Peterson",
          IdNumber = 8922
        },
        new Patient
        {
          PatientId = 5,
          FirstName = "Luke",
          LastName = "Swan",
          IdNumber = 8922
        }
      };
      var viewModel = new InvoiceCreateViewModel()
      {
        
        InvoiceLines = new List<InvoiceLine>
        {
          new InvoiceLine
          {
            Code = "TT25",
            Description = "RMI",
            InvoiceLineId = 109,
            LineTotal = 1000,
            Qty = 1,

          },
          new InvoiceLine
          {
            Code = "TT29",
            Description = "Lung Scan",
            InvoiceLineId = 110,
            LineTotal = 289,
            Qty = 1,

          }
      },
        Patients = patients
      };

      return View("New", viewModel);
    }

    // GET: Invoice/Edit/5
    public ActionResult Edit(int id)
    {
      var invoices = new List<Invoice>
      {
        new Invoice
        {
          PatientId = 1,
          InvoiceDate = DateTime.Now,
          InvoiceId = 123,
          InvoiceTotal = 500,
          InvoiceLines = new List<InvoiceLine>
          {
            new InvoiceLine
            {
              Code = "TT20",
              Description = "consult",
              InvoiceLineId = 100,
              LineTotal = 300,
              Qty = 1,

            },
            new InvoiceLine
            {
              Code = "TT21",
              Description = "Cough syrup",
              InvoiceLineId = 101,
              LineTotal = 200,
              Qty = 1,

            }
          }
        },
        new Invoice
        {
          PatientId = 2,
          InvoiceDate = DateTime.Now,
          InvoiceId = 124,
          InvoiceTotal = 600,
          InvoiceLines = new List<InvoiceLine>
          {
            new InvoiceLine
            {
              Code = "TT23",
              Description = "consult",
              InvoiceLineId = 104,
              LineTotal = 300,
              Qty = 1,

            },
            new InvoiceLine
            {
              Code = "TT24",
              Description = "Cough syrup",
              InvoiceLineId = 105,
              LineTotal = 300,
              Qty = 1,

            }
          }
        }
      };
      var patients = new List<Patient>
      {
        new Patient
        {
          PatientId = 1,
          FirstName = "Sethu",
          LastName = "Mazibuko",
          IdNumber = 8922
        },
        new Patient
        {
          PatientId = 2,
          FirstName = "Lucky",
          LastName = "Zulu",
          IdNumber = 8922
        },
        new Patient
        {
          PatientId = 3,
          FirstName = "Zama",
          LastName = "Gumbi",
          IdNumber = 8922
        },
        new Patient
        {
          PatientId = 4,
          FirstName = "Menzi",
          LastName = "Peterson",
          IdNumber = 8922
        },
        new Patient
        {
          PatientId = 5,
          FirstName = "Luke",
          LastName = "Swan",
          IdNumber = 8922
        }
      };
      var invoice = invoices.SingleOrDefault(p => p.InvoiceId == id);
      var viewModel = new InvoiceViewModel
      {
        InvoiceDate = invoice.InvoiceDate,
        InvoiceTotal = invoice.InvoiceTotal,
        PatientName = invoice.PatientId.ToString(),
        InvoiceLines = invoice.InvoiceLines,
        Patient = patients.SingleOrDefault(p =>p.PatientId == invoice.PatientId)
      };
      return View("InvoiceForm", viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Save(Patient patient)
    {
      return RedirectToAction("Index", "Invoice");
    }

  }
}
