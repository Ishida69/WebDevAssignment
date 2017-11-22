using System.Collections.Generic;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data
{
    public class ItemSearchContext : DbContext
    {
      public ItemSearchContext(DbContextOptions<ItemSearchContext> options) : base(options)
      {

      }
      public string SearchItemName { get; set; }
      public string SearchFilter { get; set; }
      public string SearchItemInformation { get; set; }
      public string SearchItemAvailability { get; set; }
      public ICollection<ItemSearch> AllItems { get; set; }

    }
}
