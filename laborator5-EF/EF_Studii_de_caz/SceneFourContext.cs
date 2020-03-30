using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Studii_de_caz
{
    public class SceneFourContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }

        public SceneFourContext()
            : base("name=SceneFourContext")
        { }
    }
}
