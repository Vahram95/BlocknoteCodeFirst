using BlocknotCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotCodeFirst.Context
{
    class BlocknoteContext : DbContext
    { 
        public BlocknoteContext()
            :base("name=BlocknoteDB")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BlocknoteContext>());
        }

        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }

    }
}
