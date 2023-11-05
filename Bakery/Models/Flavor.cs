using System.Collections.Generic;

namespace Bakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<TreatFlavor> TreatFlavors { get; set; }

    public Treat treat { get; set; }
  }
}