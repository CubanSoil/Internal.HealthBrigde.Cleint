using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Internal.HealthBrigde.Cleint.Models;

namespace Internal.HealthBrigde.Cleint.Controllers.Api
{
    public class InvoicesController : ApiController
    {
    // GET: api/Invoices
    public IHttpActionResult Get()
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
      return Ok(invoices);
    }
    // GET: api/Invoices/5
    public string Get(int id)
        {
            return "value";
        }

        // POST: api/Invoices
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Invoices/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Invoices/5
        public void Delete(int id)
        {
        }
    }
}
