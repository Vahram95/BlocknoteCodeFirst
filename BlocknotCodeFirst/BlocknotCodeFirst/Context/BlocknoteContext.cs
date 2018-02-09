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
            :base("name=Blocknote")
        {
            Database.SetInitializer(new BlocknoteInitializer());
        }

        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }

    }

    class BlocknoteInitializer : DropCreateDatabaseIfModelChanges<BlocknoteContext>
    {

        protected override void Seed(BlocknoteContext context)
        {
            context.Countries.AddRange(new Country[]
            {
                new Country() { Name = "Armenia" },
                new Country() { Name = "Georgia" },
                new Country() { Name = "Russia" },
                new Country() { Name = "Greece" },
                new Country() { Name = "USA" },
                new Country() { Name = "England" },
                new Country() { Name = "France" },
                new Country() { Name = "Canada" }
            });

            //context.Cities.AddRange(new City[]
            //{
            //    new City() { Name = "Yerevan", CountryID = context.Countries.Where( c => c.Name == "Armenia").First().ID }
            //});

            context.SaveChanges();

            base.Seed(context);
        }

    }

}
