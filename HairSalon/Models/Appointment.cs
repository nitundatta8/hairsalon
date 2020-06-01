
namespace HairSalon.Models
{
  public class Appointment
  {
    public int AppointmentId { get; set; }

    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public Client Client { get; set; }
    public Stylist Stylist { get; set; }
    public string AppointmentDate { get; set; }
    public string AppointmentTime { get; set; }


  }
}