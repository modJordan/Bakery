namespace Bakery.Models
{
  public class TreatFlavor
  {
    public int FlavorId { get; set; }
    public Flavor flavor { get; set; }
    public int TreatId { get; set; }
    public Treat treat { get; set; }
  }
}