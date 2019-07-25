using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Internal.HealthBrigde.Cleint.Models;
using Internal.HealthBrigde.Cleint.ViewModel;

namespace Internal.HealthBrigde.Cleint.Controllers
{
  public class PatientsController : Controller
  {
    public ActionResult Index()
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
      return View(patients);
    }



    public ActionResult New()
    {
      var viewModel = new PatientViewModel
      {
        Patient = new Patient()
      };

      var s = new Patient();

      return View("PatientForm", viewModel);
    }

    public ActionResult Edit(int id)
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
      var viewModel = new PatientViewModel
      {
        Patient = patient
      };

      return View("PatientForm", viewModel);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Save(Patient patient)
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
      
      patients.Add(patient);
      return RedirectToAction("Index", "Patients");
    }
  
  }
}