using System.Collections.Generic;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Flavor flavor { get; set; }
    public ICollection<TreatFlavor> TreatFlavors { get; set; }
  }
}