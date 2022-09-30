using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    // public int Id { get; }
    // public List<Item> Items { get; set; }

    public Vendor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
      _instances.Add(this);
      // Id = _instances.Count;
      // Items = new List<Item>{};
    }

//     public static void ClearAll()
//     {
//       _instances.Clear();
//     }

//     public static List<Category> GetAll()
//     {
//       return _instances;
//     }

//     public static Category Find(int searchId)
//     {
//       return _instances[searchId-1];
//     }

//     public void AddItem(Item item)
//     {
//       Items.Add(item);
//     }
  }
}