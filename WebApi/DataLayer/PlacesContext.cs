using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PlacesContext: DbContext
    {
        public PlacesContext()
            : base("PlacesDb")
        {
        }

        public DbSet<Place> Places { get; set; }
    }
}
