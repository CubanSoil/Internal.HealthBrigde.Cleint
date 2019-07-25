using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Internal.HealthBrigde.Cleint.Models;

namespace Internal.HealthBrigde.Cleint.Controllers.Api
{
  public class PatientsController : ApiController
  {
    // GET: api/Patients
    public IHttpActionResult Get()
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
      return Ok(patients);
    }

    // GET: api/Patients/5
    public IHttpActionResult Get(int id)
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
      var patient = patients.SingleOrDefault(p => p.PatientId == id);
      return Ok(patient);
    }

    // POST: api/Patients
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/Patients/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE: api/Patients/5
    public IHttpActionResult Delete(int id)
    {
      return Ok();
    }
  }
}
