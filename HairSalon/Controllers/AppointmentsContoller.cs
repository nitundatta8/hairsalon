using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace HairSalon.Controllers
{
  public class AppointmentsController : Controller
  {
    private readonly HairSalonContext _db;
    public AppointmentsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {

      List<Appointment> model = _db.Appointments.Include(appointments => appointments.Client).ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.ClientId = new SelectList(_db.Clients, "ClientId", "ClientName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Appointment appointment)
    {
      List<Appointment> app = _db.Appointments.Where(appointments => appointments.AppointmentTime == appointment.AppointmentTime &
      appointments.AppointmentDate == appointment.AppointmentDate &
      appointments.ClientId == appointment.ClientId).ToList();
      // // ViewBag.data = app;
      // Console.WriteLine(ViewBag.data.Count + " ViewBag.data");
      if (app.Count == 0)
      {
        _db.Appointments.Add(appointment);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      else
      {
        ViewBag.data = app;
        ViewBag.ClientId = new SelectList(_db.Clients, "ClientId", "ClientName");
        return View("Create");
      }



    }
    public ActionResult Details(int id)
    {

      Appointment appointment = _db.Appointments.Include(appointments => appointments.Client).FirstOrDefault(appointments => appointments.AppointmentId == id);

      return View(appointment);
    }
  }
}