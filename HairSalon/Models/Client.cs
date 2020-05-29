namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public string ClientName { get; set; }
    public string ClientPhoneNum { get; set; }
    public virtual Stylist Cuisine { get; set; }


  }
}