using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotCodeFirst.Entities
{
    class Country : Entity
    {
        [Index(IsUnique =true)]
        [StringLength(450)]
        [Required]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
